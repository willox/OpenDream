using OpenDreamShared.Compiler;
using DMCompiler.Compiler.DM;
using OpenDreamShared.Dream;
using OpenDreamShared.Dream.Procs;
using System;

namespace DMCompiler.DM.Expressions {
    // x.y.z
    // x[y][z]
    // x.f().y.g()[2]
    // etc.
    class Deref : LValue {
        public struct Operation {
            public DMASTDeref.OperationKind Kind;

            // Field*, Call*
            public string Identifier;

            // Field*
            public int? GlobalId;

            // Index*
            public DMExpression Index;

            // Call*
            public ArgumentList Parameters;

            public DreamPath? Path;
        }

        DMExpression _expression;
        Operation[] _operations;

        public override DreamPath? Path => _path;
        DreamPath? _path;

        bool _containsConditional = false;

        public Deref(Location location, DreamPath? path, DMExpression expression, Operation[] operations)
            : base(location, null) {
            _expression = expression;
            _operations = operations;
            _path = path;

            if (_operations.Length == 0) {
                throw new System.InvalidOperationException("deref expression has no operations");
            }

            foreach (ref var operation in _operations.AsSpan()) {
                bool isConditional = operation.Kind switch {
                    DMASTDeref.OperationKind.Invalid => throw new InvalidOperationException(),
                    DMASTDeref.OperationKind.Field => false,
                    DMASTDeref.OperationKind.FieldSafe => true,
                    DMASTDeref.OperationKind.FieldSearch => false,
                    DMASTDeref.OperationKind.FieldSafeSearch => true,
                    DMASTDeref.OperationKind.Index => false,
                    DMASTDeref.OperationKind.IndexSafe => true,
                    DMASTDeref.OperationKind.Call => false,
                    DMASTDeref.OperationKind.CallSafe => true,
                    DMASTDeref.OperationKind.CallSearch => false,
                    DMASTDeref.OperationKind.CallSafeSearch => true,
                };

                if (isConditional) {
                    _containsConditional = true;
                    break;
                }
            }
        }

        private void EmitOperation(DMObject dmObject, DMProc proc, ref Operation operation, string endLabel) {
            switch (operation.Kind) {
                case DMASTDeref.OperationKind.Field:
                case DMASTDeref.OperationKind.FieldSearch:
                    proc.DereferenceField(operation.Identifier);
                    break;

                case DMASTDeref.OperationKind.FieldSafe:
                case DMASTDeref.OperationKind.FieldSafeSearch:
                    proc.JumpIfNullNoPop(endLabel);
                    proc.DereferenceField(operation.Identifier);
                    break;

                case DMASTDeref.OperationKind.Index:
                    operation.Index.EmitPushValue(dmObject, proc);
                    proc.DereferenceIndex();
                    break;

                case DMASTDeref.OperationKind.IndexSafe:
                    proc.JumpIfNullNoPop(endLabel);
                    operation.Index.EmitPushValue(dmObject, proc);
                    proc.DereferenceIndex();
                    break;

                case DMASTDeref.OperationKind.Call:
                case DMASTDeref.OperationKind.CallSearch:
                    operation.Parameters.EmitPushArguments(dmObject, proc);
                    proc.DereferenceCall(operation.Identifier);
                    break;

                case DMASTDeref.OperationKind.CallSafe:
                case DMASTDeref.OperationKind.CallSafeSearch:
                    proc.JumpIfNullNoPop(endLabel);
                    operation.Parameters.EmitPushArguments(dmObject, proc);
                    proc.DereferenceCall(operation.Identifier);
                    break;

                case DMASTDeref.OperationKind.Invalid:
                default:
                    throw new NotImplementedException();
            };
        }

        public override void EmitPushValue(DMObject dmObject, DMProc proc) {
            string endLabel = proc.NewLabelName();

            _expression.EmitPushValue(dmObject, proc);

            foreach (ref var operation in _operations.AsSpan()) {
                EmitOperation(dmObject, proc, ref operation, endLabel);
            }

            proc.AddLabel(endLabel);
        }

        public override DMReference EmitReference(DMObject dmObject, DMProc proc, string endLabel) {
            _expression.EmitPushValue(dmObject, proc);

            // Perform all except for our last operation
            for (int i = 0; i < _operations.Length - 1; i++) {
                EmitOperation(dmObject, proc, ref _operations[i], endLabel);
            }

            ref var operation = ref _operations[^1];

            switch (operation.Kind) {
                case DMASTDeref.OperationKind.Field:
                case DMASTDeref.OperationKind.FieldSearch:
                    return DMReference.CreateField(operation.Identifier);

                case DMASTDeref.OperationKind.FieldSafe:
                case DMASTDeref.OperationKind.FieldSafeSearch:
                    proc.JumpIfNullNoPop(endLabel);
                    return DMReference.CreateField(operation.Identifier);

                case DMASTDeref.OperationKind.Index:
                    operation.Index.EmitPushValue(dmObject, proc);
                    return DMReference.ListIndex;

                case DMASTDeref.OperationKind.IndexSafe:
                    proc.JumpIfNullNoPop(endLabel);
                    operation.Index.EmitPushValue(dmObject, proc);
                    return DMReference.ListIndex;

                case DMASTDeref.OperationKind.Call:
                case DMASTDeref.OperationKind.CallSearch:
                case DMASTDeref.OperationKind.CallSafe:
                case DMASTDeref.OperationKind.CallSafeSearch:
                    throw new CompileErrorException(Location, $"attempt to reference proc call result");

                case DMASTDeref.OperationKind.Invalid:
                default:
                    throw new NotImplementedException();
            };
        }

        public override void EmitPushInitial(DMObject dmObject, DMProc proc) {
            string endLabel = proc.NewLabelName();

            _expression.EmitPushValue(dmObject, proc);

            // Perform all except for our last operation
            for (int i = 0; i < _operations.Length - 1; i++) {
                EmitOperation(dmObject, proc, ref _operations[i], endLabel);
            }

            ref var operation = ref _operations[^1];

            switch (operation.Kind) {
                case DMASTDeref.OperationKind.Field:
                case DMASTDeref.OperationKind.FieldSearch:
                    proc.Initial(operation.Identifier);
                    break;

                case DMASTDeref.OperationKind.FieldSafe:
                case DMASTDeref.OperationKind.FieldSafeSearch:
                    proc.JumpIfNullNoPop(endLabel);
                    proc.Initial(operation.Identifier);
                    break;

                case DMASTDeref.OperationKind.Index:
                    EmitOperation(dmObject, proc, ref operation, endLabel);
                    break;

                case DMASTDeref.OperationKind.IndexSafe:
                    proc.JumpIfNullNoPop(endLabel);
                    EmitOperation(dmObject, proc, ref operation, endLabel);
                    break;

                case DMASTDeref.OperationKind.Call:
                case DMASTDeref.OperationKind.CallSearch:
                case DMASTDeref.OperationKind.CallSafe:
                case DMASTDeref.OperationKind.CallSafeSearch:
                    throw new CompileErrorException(Location, $"attempt to get the initial value of a proc call");

                case DMASTDeref.OperationKind.Invalid:
                default:
                    throw new NotImplementedException();
            };

            proc.AddLabel(endLabel);
        }

        public void EmitPushIsSaved(DMObject dmObject, DMProc proc) {
            string endLabel = proc.NewLabelName();

            _expression.EmitPushValue(dmObject, proc);

            // Perform all except for our last operation
            for (int i = 0; i < _operations.Length - 1; i++) {
                EmitOperation(dmObject, proc, ref _operations[i], endLabel);
            }

            ref var operation = ref _operations[^1];

            switch (operation.Kind) {
                case DMASTDeref.OperationKind.Field:
                case DMASTDeref.OperationKind.FieldSearch:
                    proc.IsSaved(operation.Identifier);
                    break;

                case DMASTDeref.OperationKind.FieldSafe:
                case DMASTDeref.OperationKind.FieldSafeSearch:
                    proc.JumpIfNullNoPop(endLabel);
                    proc.IsSaved(operation.Identifier);
                    break;

                case DMASTDeref.OperationKind.Index:
                    proc.Pop();
                    proc.PushFloat(0f);
                    break;

                case DMASTDeref.OperationKind.IndexSafe:
                    proc.JumpIfNullNoPop(endLabel);
                    proc.Pop();
                    proc.PushFloat(0f);
                    break;

                case DMASTDeref.OperationKind.Call:
                case DMASTDeref.OperationKind.CallSearch:
                case DMASTDeref.OperationKind.CallSafe:
                case DMASTDeref.OperationKind.CallSafeSearch:
                    throw new CompileErrorException(Location, $"attempt to get the initial value of a proc call");

                case DMASTDeref.OperationKind.Invalid:
                default:
                    throw new NotImplementedException();
            };

            proc.AddLabel(endLabel);
        }

        public override bool TryAsConstant(out Constant constant) {
            ref var operation = ref _operations[^1];

            switch (operation.Kind) {
                case DMASTDeref.OperationKind.Field:
                case DMASTDeref.OperationKind.FieldSearch:
                    DreamPath? parentPath = (_operations.Length > 1) ? _operations[^2].Path : _expression.Path;

                    if (parentPath != null) {
                        var obj = DMObjectTree.GetDMObject(parentPath.Value);
                        var variable = obj.GetVariable(operation.Identifier);
                        if (variable != null) {
                            if (variable.IsConst)
                                return variable.Value.TryAsConstant(out constant);
                            if ((variable.ValType & DMValueType.CompiletimeReadonly) == DMValueType.CompiletimeReadonly) {
                                variable.Value.TryAsConstant(out constant);
                                return true; // MUST be true.
                            }
                        }
                    }

                    constant = null;
                    return false;

                case DMASTDeref.OperationKind.FieldSafe:
                case DMASTDeref.OperationKind.FieldSafeSearch:
                    constant = null;
                    return false;

                case DMASTDeref.OperationKind.Index:
                    constant = null;
                    return false;

                case DMASTDeref.OperationKind.IndexSafe:
                    constant = null;
                    return false;

                case DMASTDeref.OperationKind.Call:
                case DMASTDeref.OperationKind.CallSearch:
                case DMASTDeref.OperationKind.CallSafe:
                case DMASTDeref.OperationKind.CallSafeSearch:
                    constant = null;
                    return false;

                case DMASTDeref.OperationKind.Invalid:
                default:
                    throw new NotImplementedException();
            };
        }
    }

    // x.y.z
    class Dereference : LValue {
        // Kind of a lazy port
        DMExpression _expr;
        public readonly string PropertyName;
        bool _conditional;

        public override DreamPath? Path => _path;
        DreamPath? _path;

        public static bool DirectConvertable(DMExpression expr, DMASTDereference astNode) {
            switch (astNode.Expression) {
                case DMASTDereference deref when deref.Type == DMASTDereference.DereferenceType.Search:
                case DMASTProcCall when expr.Path == null:
                case DMASTDereferenceProc:
                case DMASTList:
                case DMASTListIndex:
                case DMASTTernary:
                case DMASTBinaryAnd:
                    return true;
                case DMASTDereference deref when expr is Dereference _deref:
                    return DirectConvertable(_deref._expr, deref);
                default: return false;
            }
        }

        public Dereference(Location location, DreamPath? path, DMExpression expr, bool conditional, string propertyName)
            : base(location, null)
        {
            _expr = expr;
            _conditional = conditional || _expr.Conditional;
            PropertyName = propertyName;
            _path = path;
        }

        public override void EmitPushInitial(DMObject dmObject, DMProc proc) {
            _expr.EmitPushValue(dmObject, proc);
            proc.Initial(PropertyName);
        }

        public void EmitPushIsSaved(DMObject dmObject, DMProc proc) {
            _expr.EmitPushValue(dmObject, proc);
            proc.IsSaved(PropertyName);
        }

        public override (DMReference Reference, bool Conditional) EmitReference(DMObject dmObject, DMProc proc) {
            _expr.EmitPushValue(dmObject, proc);
            return (DMReference.CreateField(PropertyName), _conditional);
        }

        public override bool TryAsConstant(out Constant constant)
        {
            if(_expr.Path is not null)
            {
                var obj = DMObjectTree.GetDMObject(_expr.Path.GetValueOrDefault());
                var variable = obj.GetVariable(PropertyName);
                if (variable != null)
                {
                    if(variable.IsConst)
                        return variable.Value.TryAsConstant(out constant);
                    if((variable.ValType & DMValueType.CompiletimeReadonly) == DMValueType.CompiletimeReadonly)
                    {
                        variable.Value.TryAsConstant(out constant);
                        return true; // MUST be true.
                    }
                }
            }

            constant = null;
            return false;
        }

        public override bool Conditional => _conditional;
    }

    // x.y.z()
    class DereferenceProc : DMExpression {
        // Kind of a lazy port
        DMExpression _expr;
        bool _conditional;
        string _field;

        public DereferenceProc(Location location, DMExpression expr, DMASTDereferenceProc astNode) : base(location) {
            _expr = expr;
            _conditional = astNode.Conditional || _expr.Conditional;
            _field = astNode.Property;

            if (astNode.Type == DMASTDereference.DereferenceType.Direct) {
                if (Dereference.DirectConvertable(expr, astNode)) {
                    astNode.Type = DMASTDereference.DereferenceType.Search;
                    return;
                }
                else if (expr.Path == null) {
                    throw new CompileErrorException(astNode.Location,$"Invalid property \"{_field}\"");
                }

                DMObject dmObject = DMObjectTree.GetDMObject(_expr.Path.Value, false);
                if (dmObject == null) throw new CompileErrorException(Location, $"Type {expr.Path.Value} does not exist");
                if (!dmObject.HasProc(_field)) throw new CompileErrorException(Location, $"Type {_expr.Path.Value} does not have a proc named \"{_field}\"");
            }
        }

        public override void EmitPushValue(DMObject dmObject, DMProc proc) {
            throw new CompileErrorException(Location, "attempt to use proc as value");
        }

        public override (DMReference Reference, bool Conditional) EmitReference(DMObject dmObject, DMProc proc) {
            _expr.EmitPushValue(dmObject, proc);
            return (DMReference.CreateProc(_field), _conditional);
        }

        public (DMObject ProcOwner, DMProc Proc) GetProc() {
            if (_expr.Path == null) return (null, null);

            DMObject dmObject = DMObjectTree.GetDMObject(_expr.Path.Value);
            var procId = dmObject.GetProcs(_field)?[^1];
            return (dmObject, procId is null ? null : DMObjectTree.AllProcs[procId.Value]);
        }

        public override bool Conditional => _conditional;
    }

    // x[y]
    class ListIndex : LValue {
        DMExpression _expr;
        DMExpression _index;
        bool _conditional;

        public ListIndex(Location location, DMExpression expr, DMExpression index, DreamPath? path, bool conditional)
            : base(location, path)
        {
            _expr = expr;
            _index = index;
            _conditional = conditional || _expr.Conditional;
        }

        public override (DMReference Reference, bool Conditional) EmitReference(DMObject dmObject, DMProc proc) {
            _expr.EmitPushValue(dmObject, proc);
            _index.EmitPushValue(dmObject, proc);

            return (DMReference.ListIndex, _conditional);
        }

        public override void EmitPushInitial(DMObject dmObject, DMProc proc) {
            // This happens silently in BYOND
            // TODO Support "vars" actually pushing initial() correctly
            if (_expr is Dereference deref && deref.PropertyName != "vars")
            {
                DMCompiler.Warning(new CompilerWarning(Location, "calling initial() on a list index returns the current value"));
            }
            EmitPushValue(dmObject, proc);
        }

        public bool IsSaved()
        {
            // Silent in BYOND
            // TODO Support "vars" actually pushing issaved() correctly
            if (_expr is Dereference deref && deref.PropertyName != "vars")
            {
                DMCompiler.Warning(new CompilerWarning(_expr.Location, "calling issaved() on a list index is always false"));
                return false;
            }

            return true;
        }

        public override bool Conditional => _conditional;
    }
}
