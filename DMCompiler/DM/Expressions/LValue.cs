using OpenDreamShared.Compiler;
using OpenDreamShared.Dream;
using OpenDreamShared.Dream.Procs;

namespace DMCompiler.DM.Expressions {
    abstract class LValue : DMExpression {
        public override DreamPath? Path => _path;
        DreamPath? _path;

        public LValue(Location location, DreamPath? path) : base(location) {
            _path = path;
        }

        public override void EmitPushValue(DMObject dmObject, DMProc proc) {
            string endLabel = proc.NewLabelName();

            DMReference reference = EmitReference(dmObject, proc, endLabel);
            proc.PushReferenceValue(reference);

            proc.AddLabel(endLabel);
        }

        public virtual void EmitPushInitial(DMObject dmObject, DMProc proc) {
            throw new CompileErrorException(Location, $"Can't get initial value of {this}");
        }
    }

    // global
    class Global : LValue {
        public Global(Location location)
            : base(location, null) { }

        public override DMReference EmitReference(DMObject dmObject, DMProc proc, string endLabel, ShortCircuitMode shortCircuitMode) {
            throw new CompileErrorException(Location, $"attempt to use `global` as a reference");
        }
    }

    // src
    class Src : LValue {
        public Src(Location location, DreamPath? path)
            : base(location, path)
        {}

        public override DMReference EmitReference(DMObject dmObject, DMProc proc, string endLabel, ShortCircuitMode shortCircuitMode) {
            return DMReference.Src;
        }

        public override string GetNameof(DMObject dmObject, DMProc proc) {
            return "src";
        }
    }

    // usr
    class Usr : LValue {
        public Usr(Location location)
            : base(location, DreamPath.Mob)
        {}

        public override DMReference EmitReference(DMObject dmObject, DMProc proc, string endLabel, ShortCircuitMode shortCircuitMode) {
            return DMReference.Usr;
        }
    }

    // args
    class Args : LValue {
        public Args(Location location)
            : base(location, DreamPath.List)
        {}

        public override DMReference EmitReference(DMObject dmObject, DMProc proc, string endLabel, ShortCircuitMode shortCircuitMode) {
            return DMReference.Args;
        }
    }

    // Identifier of local variable
    class Local : LValue {
        DMProc.LocalVariable LocalVar { get; }

        public Local(Location location, DMProc.LocalVariable localVar)
            : base(location, localVar.Type) {
            LocalVar = localVar;
        }

        public override DMReference EmitReference(DMObject dmObject, DMProc proc, string endLabel, ShortCircuitMode shortCircuitMode) {
            if (LocalVar.IsParameter) {
                return DMReference.CreateArgument(LocalVar.Id);
            } else {
                return DMReference.CreateLocal(LocalVar.Id);
            }
        }

        public override bool TryAsConstant(out Constant constant) {
            if (LocalVar is DMProc.LocalConstVariable constVar) {
                constant = constVar.Value;
                return true;
            }

            constant = null;
            return false;
        }

        public override void EmitPushInitial(DMObject dmObject, DMProc proc) {
            // This happens silently in BYOND
            DMCompiler.Emit(WarningCode.PointlessBuiltinCall, Location, "calling initial() on a local variable returns the current value");
            EmitPushValue(dmObject, proc);
        }

        public override string GetNameof(DMObject dmObject, DMProc proc) {
            return LocalVar.IsParameter ? proc.Parameters[LocalVar.Id] : proc.GetLocalVarName(LocalVar.Id);
        }
    }

    // Identifier of field
    class Field : LValue {
        public readonly DMVariable Variable;

        public Field(Location location, DMVariable variable)
            : base(location, variable.Type) {
            Variable = variable;
        }

        public override void EmitPushInitial(DMObject dmObject, DMProc proc) {
            proc.PushReferenceValue(DMReference.Src);
            proc.PushString(Variable.Name);
            proc.Initial();
        }

        public void EmitPushIsSaved(DMProc proc) {
            proc.PushReferenceValue(DMReference.Src);
            proc.PushString(Variable.Name);
            proc.IsSaved();
        }

        public override DMReference EmitReference(DMObject dmObject, DMProc proc, string endLabel, ShortCircuitMode shortCircuitMode) {
            return DMReference.CreateSrcField(Variable.Name);
        }

        public override bool TryAsConstant(out Constant constant) {
            if (Variable.IsConst && Variable.Value != null) {
                return Variable.Value.TryAsConstant(out constant);
            }

            constant = null;
            return false;
        }
    }

    // Id of global field
    class GlobalField : LValue {
        int Id { get; }

        public GlobalField(Location location, DreamPath? path, int id)
            : base(location, path) {
            Id = id;
        }

        public void EmitPushIsSaved(DMProc proc) {
            throw new CompileErrorException(Location, "issaved() on globals is unimplemented");
        }

        public override DMReference EmitReference(DMObject dmObject, DMProc proc, string endLabel, ShortCircuitMode shortCircuitMode) {
            return DMReference.CreateGlobal(Id);
        }

        public override void EmitPushInitial(DMObject dmObject, DMProc proc) {
            // This happens silently in BYOND
            DMCompiler.Emit(WarningCode.PointlessBuiltinCall, Location, "calling initial() on a global returns the current value");
            EmitPushValue(dmObject, proc);
        }

        public override string GetNameof(DMObject dmObject, DMProc proc) {
            DMVariable global = DMObjectTree.Globals[Id];
            return global.Name;
        }

        public override bool TryAsConstant(out Constant constant) {
            DMVariable global = DMObjectTree.Globals[Id];
            if (global.IsConst) {
                return global.Value.TryAsConstant(out constant);
            }

            constant = null;
            return false;
        }
    }

    class GlobalVars : LValue
    {
        public GlobalVars(Location location)
            : base(location, null) {
        }

        public override void EmitPushValue(DMObject dmObject, DMProc proc) {
            proc.PushGlobalVars();
        }
    }

}
