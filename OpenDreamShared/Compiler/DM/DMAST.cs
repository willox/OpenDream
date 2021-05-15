using System;
using OpenDreamShared.Dream;
using OpenDreamShared.Dream.Procs;

namespace OpenDreamShared.Compiler.DM {
    interface DMASTVisitor {
        public void VisitFile(DMASTFile file) { throw new NotImplementedException(); }
        public void VisitBlockInner(DMASTBlockInner block) { throw new NotImplementedException(); }
        public void VisitProcBlockInner(DMASTProcBlockInner procBlock) { throw new NotImplementedException(); }
        public void VisitObjectDefinition(DMASTObjectDefinition statement) { throw new NotImplementedException(); }
        public void VisitPath(DMASTPath path) { throw new NotImplementedException(); }
        public void VisitObjectVarDefinition(DMASTObjectVarDefinition objectVarDefinition) { throw new NotImplementedException(); }
        public void VisitObjectVarOverride(DMASTObjectVarOverride objectVarOverride) { throw new NotImplementedException(); }
        public void VisitProcStatementExpression(DMASTProcStatementExpression statementExpression) { throw new NotImplementedException(); }
        public void VisitProcStatementVarDeclaration(DMASTProcStatementVarDeclaration varDeclaration) { throw new NotImplementedException(); }
        public void VisitProcStatementReturn(DMASTProcStatementReturn statementReturn) { throw new NotImplementedException(); }
        public void VisitProcStatementBreak(DMASTProcStatementBreak statementBreak) { throw new NotImplementedException(); }
        public void VisitProcStatementContinue(DMASTProcStatementContinue statementContinue) { throw new NotImplementedException(); }
        public void VisitProcStatementGoto(DMASTProcStatementGoto statementGoto) { throw new NotImplementedException(); }
        public void VisitProcStatementLabel(DMASTProcStatementLabel statementLabel) { throw new NotImplementedException(); }
        public void VisitProcStatementDel(DMASTProcStatementDel statementDel) { throw new NotImplementedException(); }
        public void VisitProcStatementSet(DMASTProcStatementSet statementSet) { throw new NotImplementedException(); }
        public void VisitProcStatementSpawn(DMASTProcStatementSpawn statementSpawn) { throw new NotImplementedException(); }
        public void VisitProcStatementIf(DMASTProcStatementIf statementIf) { throw new NotImplementedException(); }
        public void VisitProcStatementForStandard(DMASTProcStatementForStandard statementForStandard) { throw new NotImplementedException(); }
        public void VisitProcStatementForList(DMASTProcStatementForList statementForList) { throw new NotImplementedException(); }
        public void VisitProcStatementForRange(DMASTProcStatementForRange statementForRange) { throw new NotImplementedException(); }
        public void VisitProcStatementForLoop(DMASTProcStatementForLoop statementForLoop) { throw new NotImplementedException(); }
        public void VisitProcStatementWhile(DMASTProcStatementWhile statementWhile) { throw new NotImplementedException(); }
        public void VisitProcStatementDoWhile(DMASTProcStatementDoWhile statementDoWhile) { throw new NotImplementedException(); }
        public void VisitProcStatementSwitch(DMASTProcStatementSwitch statementSwitch) { throw new NotImplementedException(); }
        public void VisitProcStatementBrowse(DMASTProcStatementBrowse statementBrowse) { throw new NotImplementedException(); }
        public void VisitProcStatementBrowseResource(DMASTProcStatementBrowseResource statementBrowseResource) { throw new NotImplementedException(); }
        public void VisitProcStatementOutputControl(DMASTProcStatementOutputControl statementOutputControl) { throw new NotImplementedException(); }
        public void VisitProcDefinition(DMASTProcDefinition procDefinition) { throw new NotImplementedException(); }
        public void VisitIdentifier(DMASTIdentifier identifier) { throw new NotImplementedException(); }
        public void VisitConstantInteger(DMASTConstantInteger constant) { throw new NotImplementedException(); }
        public void VisitConstantFloat(DMASTConstantFloat constant) { throw new NotImplementedException(); }
        public void VisitConstantString(DMASTConstantString constant) { throw new NotImplementedException(); }
        public void VisitConstantResource(DMASTConstantResource constant) { throw new NotImplementedException(); }
        public void VisitConstantNull(DMASTConstantNull constant) { throw new NotImplementedException(); }
        public void VisitConstantPath(DMASTConstantPath constant) { throw new NotImplementedException(); }
        public void VisitStringFormat(DMASTStringFormat stringFormat) { throw new NotImplementedException(); }
        public void VisitList(DMASTList list) { throw new NotImplementedException(); }
        public void VisitInput(DMASTInput input) { throw new NotImplementedException(); }
        public void VisitInitial(DMASTInitial initial) { throw new NotImplementedException(); }
        public void VisitIsType(DMASTIsType isType) { throw new NotImplementedException(); }
        public void VisitImplicitIsType(DMASTImplicitIsType isType) { throw new NotImplementedException(); }
        public void VisitLocateCoordinates(DMASTLocateCoordinates locateCoordinates) { throw new NotImplementedException(); }
        public void VisitLocate(DMASTLocate locate) { throw new NotImplementedException(); }
        public void VisitCall(DMASTCall call) { throw new NotImplementedException(); }
        public void VisitAssign(DMASTAssign assign) { throw new NotImplementedException(); }
        public void VisitNewPath(DMASTNewPath newPath) { throw new NotImplementedException(); }
        public void VisitNewIdentifier(DMASTNewIdentifier newIdentifier) { throw new NotImplementedException(); }
        public void VisitNewDereference(DMASTNewDereference newDereference) { throw new NotImplementedException(); }
        public void VisitNewInferred(DMASTNewInferred newInferred) { throw new NotImplementedException(); }
        public void VisitNot(DMASTNot not) { throw new NotImplementedException(); }
        public void VisitNegate(DMASTNegate negate) { throw new NotImplementedException(); }
        public void VisitEqual(DMASTEqual equal) { throw new NotImplementedException(); }
        public void VisitNotEqual(DMASTNotEqual notEqual) { throw new NotImplementedException(); }
        public void VisitLessThan(DMASTLessThan lessThan) { throw new NotImplementedException(); }
        public void VisitLessThanOrEqual(DMASTLessThanOrEqual lessThanOrEqual) { throw new NotImplementedException(); }
        public void VisitGreaterThan(DMASTGreaterThan greaterThan) { throw new NotImplementedException(); }
        public void VisitGreaterThanOrEqual(DMASTGreaterThanOrEqual greaterThanOrEqual) { throw new NotImplementedException(); }
        public void VisitMultiply(DMASTMultiply multiply) { throw new NotImplementedException(); }
        public void VisitDivide(DMASTDivide divide) { throw new NotImplementedException(); }
        public void VisitModulus(DMASTModulus modulus) { throw new NotImplementedException(); }
        public void VisitPower(DMASTPower power) { throw new NotImplementedException(); }
        public void VisitAdd(DMASTAdd add) { throw new NotImplementedException(); }
        public void VisitSubtract(DMASTSubtract subtract) { throw new NotImplementedException(); }
        public void VisitPreIncrement(DMASTPreIncrement preIncrement) { throw new NotImplementedException(); }
        public void VisitPreDecrement(DMASTPreDecrement preDecrement) { throw new NotImplementedException(); }
        public void VisitPostIncrement(DMASTPostIncrement postIncrement) { throw new NotImplementedException(); }
        public void VisitPostDecrement(DMASTPostDecrement postDecrement) { throw new NotImplementedException(); }
        public void VisitTernary(DMASTTernary ternary) { throw new NotImplementedException(); }
        public void VisitAppend(DMASTAppend append) { throw new NotImplementedException(); }
        public void VisitRemove(DMASTRemove remove) { throw new NotImplementedException(); }
        public void VisitCombine(DMASTCombine combine) { throw new NotImplementedException(); }
        public void VisitMask(DMASTMask mask) { throw new NotImplementedException(); }
        public void VisitMultiplyAssign(DMASTMultiplyAssign multiplyAssign) { throw new NotImplementedException(); }
        public void VisitDivideAssign(DMASTDivideAssign divideAssign) { throw new NotImplementedException(); }
        public void VisitLeftShiftAssign(DMASTLeftShiftAssign leftShiftAssign) { throw new NotImplementedException(); }
        public void VisitRightShiftAssign(DMASTRightShiftAssign rightShiftAssign) { throw new NotImplementedException(); }
        public void VisitXorAssign(DMASTXorAssign xorAssign) { throw new NotImplementedException(); }
        public void VisitOr(DMASTOr or) { throw new NotImplementedException(); }
        public void VisitAnd(DMASTAnd and) { throw new NotImplementedException(); }
        public void VisitBinaryAnd(DMASTBinaryAnd binaryAnd) { throw new NotImplementedException(); }
        public void VisitBinaryXor(DMASTBinaryXor binaryXor) { throw new NotImplementedException(); }
        public void VisitBinaryOr(DMASTBinaryOr binaryOr) { throw new NotImplementedException(); }
        public void VisitBinaryNot(DMASTBinaryNot binaryNot) { throw new NotImplementedException(); }
        public void VisitLeftShift(DMASTLeftShift leftShift) { throw new NotImplementedException(); }
        public void VisitRightShift(DMASTRightShift rightShift) { throw new NotImplementedException(); }
        public void VisitIn(DMASTExpressionIn expressionIn) { throw new NotImplementedException(); }
        public void VisitListIndex(DMASTListIndex listIndex) { throw new NotImplementedException(); }
        public void VisitProcCall(DMASTProcCall procCall) { throw new NotImplementedException(); }
        public void VisitCallParameter(DMASTCallParameter callParameter) { throw new NotImplementedException(); }
        public void VisitDefinitionParameter(DMASTDefinitionParameter definitionParameter) { throw new NotImplementedException(); }
        public void VisitDereference(DMASTDereference dereference) { throw new NotImplementedException(); }
        public void VisitDereferenceProc(DMASTDereferenceProc dereferenceProc) { throw new NotImplementedException(); }
        public void VisitCallableProcIdentifier(DMASTCallableProcIdentifier procIdentifier) { throw new NotImplementedException(); }
        public void VisitCallableSuper(DMASTCallableSuper super) { throw new NotImplementedException(); }
        public void VisitCallableSelf(DMASTCallableSelf self) { throw new NotImplementedException(); }
    }

    abstract class DMASTNode : ASTNode<DMASTVisitor> {
        public DMASTNode(Location location) {
            Location = location;
        }

        public readonly Location Location;

        public abstract void Visit(DMASTVisitor visitor);
    }

    abstract class DMASTProcStatement : DMASTNode {
		public DMASTProcStatement(Location location)
            : base(location)
        {}
    }

    abstract class DMASTExpression : DMASTNode {
		public DMASTExpression(Location location)
            : base(location)
        {}
    }

    abstract class DMASTExpressionConstant : DMASTExpression {
		public DMASTExpressionConstant(Location location)
            : base(location)
        {}
    }

    abstract class DMASTStatement : DMASTNode {
		public DMASTStatement(Location location)
            : base(location)
        {}
	}

    abstract class DMASTCallable : DMASTExpression {
	    public DMASTCallable(Location location)
            : base(location)
        {}
	}

    class DMASTFile : DMASTNode {
        public DMASTBlockInner BlockInner;

        public DMASTFile(Location location, DMASTBlockInner blockInner)
            : base(location)
        {
            BlockInner = blockInner;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitFile(this);
        }
    }

    class DMASTBlockInner : DMASTNode {
        public DMASTStatement[] Statements;

        public DMASTBlockInner(Location location, DMASTStatement[] statements)
            : base(location)
        {
            Statements = statements;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitBlockInner(this);
        }
    }

    class DMASTProcBlockInner : DMASTNode {
        public DMASTProcStatement[] Statements;

        public DMASTProcBlockInner(Location location, DMASTProcStatement[] statements)
            : base(location)
        {
            Statements = statements;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcBlockInner(this);
        }
    }

    class DMASTObjectDefinition : DMASTStatement {
        public DreamPath Path;
        public DMASTBlockInner InnerBlock;

        public DMASTObjectDefinition(Location location, DreamPath path, DMASTBlockInner innerBlock)
            : base(location)
        {
            Path = path;
            InnerBlock = innerBlock;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitObjectDefinition(this);
        }
    }

    class DMASTProcDefinition : DMASTStatement {
        public DreamPath? ObjectPath;
        public string Name;
        public bool IsVerb = false;
        public DMASTDefinitionParameter[] Parameters;
        public DMASTProcBlockInner Body;

        public DMASTProcDefinition(Location location, DreamPath path, DMASTDefinitionParameter[] parameters, DMASTProcBlockInner body)
            : base(location)
        {
            int procElementIndex = path.FindElement("proc");

            if (procElementIndex == -1) {
                procElementIndex = path.FindElement("verb");

                if (procElementIndex != -1) IsVerb = true;
            }

            if (procElementIndex != -1) path = path.RemoveElement(procElementIndex);

            ObjectPath = (path.Elements.Length > 1) ? path.FromElements(0, -2) : null;
            Name = path.LastElement;
            Parameters = parameters;
            Body = body;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcDefinition(this);
        }
    }

    class DMASTPath : DMASTNode {
        public DreamPath Path;

        public DMASTPath(Location location, DreamPath path)
            : base(location)
        {
            Path = path;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitPath(this);
        }
    }

    class DMASTObjectVarDefinition : DMASTStatement {
        public DreamPath ObjectPath;
        public DreamPath? Type;
        public string Name;
        public DMASTExpression Value;
        public bool IsGlobal = false;

        public DMASTObjectVarDefinition(Location location, DreamPath path, DMASTExpression value)
            : base(location)
        {
            int globalElementIndex = path.FindElement("global");
            if (globalElementIndex != -1) path = path.RemoveElement(globalElementIndex);

            int varElementIndex = path.FindElement("var");
            if (varElementIndex == -1) throw new Exception("Var definition's path (" + path + ") did not contain a var element");

            DreamPath varPath = path.FromElements(varElementIndex + 1, -1);

            ObjectPath = path.FromElements(0, varElementIndex);
            Type = (varPath.Elements.Length > 1) ? varPath.FromElements(0, -2) : null;
            IsGlobal = globalElementIndex != -1 || ObjectPath.Equals(DreamPath.Root);
            Name = varPath.LastElement;
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitObjectVarDefinition(this);
        }
    }

    class DMASTObjectVarOverride : DMASTStatement {
        public DreamPath ObjectPath;
        public string VarName;
        public DMASTExpression Value;

        public DMASTObjectVarOverride(Location location, DreamPath path, DMASTExpression value)
            : base(location)
        {
            ObjectPath = path.FromElements(0, -2);
            VarName = path.LastElement;
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitObjectVarOverride(this);
        }
    }

    class DMASTProcStatementExpression : DMASTProcStatement {
        public DMASTExpression Expression;

        public DMASTProcStatementExpression(Location location, DMASTExpression expression)
            : base(location)
        {
            Expression = expression;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementExpression(this);
        }
    }

    class DMASTProcStatementVarDeclaration : DMASTProcStatement {
        public DreamPath? Type;
        public string Name;
        public DMASTExpression Value;

        public DMASTProcStatementVarDeclaration(Location location, DMASTPath path, DMASTExpression value)
            : base(location)
        {
            int varElementIndex = path.Path.FindElement("var");
            DreamPath typePath = path.Path.FromElements(varElementIndex + 1, -2);

            Type = (typePath.Elements.Length > 0) ? typePath : null;
            Name = path.Path.LastElement;
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementVarDeclaration(this);
        }
    }

    class DMASTProcStatementReturn : DMASTProcStatement {
        public DMASTExpression Value;

        public DMASTProcStatementReturn(Location location, DMASTExpression value)
            : base(location)
        {
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementReturn(this);
        }
    }

    class DMASTProcStatementBreak : DMASTProcStatement {
        public DMASTProcStatementBreak(Location location)
            : base(location)
        {}

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementBreak(this);
        }
    }

    class DMASTProcStatementContinue : DMASTProcStatement {
        public DMASTProcStatementContinue(Location location)
            : base(location)
        {}

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementContinue(this);
        }
    }

    class DMASTProcStatementGoto : DMASTProcStatement {
        public DMASTIdentifier Label;

        public DMASTProcStatementGoto(Location location, DMASTIdentifier label)
            : base(location)
        {
            Label = label;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementGoto(this);
        }
    }

    class DMASTProcStatementLabel : DMASTProcStatement {
        public string Name;

        public DMASTProcStatementLabel(Location location, string name)
            : base(location)
        {
            Name = name;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementLabel(this);
        }
    }

    class DMASTProcStatementDel : DMASTProcStatement {
        public DMASTExpression Value;

        public DMASTProcStatementDel(Location location, DMASTExpression value)
            : base(location)
        {
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementDel(this);
        }
    }

    class DMASTProcStatementSet : DMASTProcStatement {
        public string Attribute;
        public DMASTExpression Value;

        public DMASTProcStatementSet(Location location, string attribute, DMASTExpression value)
            : base(location)
        {
            Attribute = attribute;
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementSet(this);
        }
    }

    class DMASTProcStatementSpawn : DMASTProcStatement {
        public DMASTExpression Delay;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementSpawn(Location location, DMASTExpression delay, DMASTProcBlockInner body)
            : base(location)
        {
            Delay = delay;
            Body = body;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementSpawn(this);
        }
    }

    class DMASTProcStatementIf : DMASTProcStatement {
        public DMASTExpression Condition;
        public DMASTProcBlockInner Body;
        public DMASTProcBlockInner ElseBody;

        public DMASTProcStatementIf(Location location, DMASTExpression condition, DMASTProcBlockInner body, DMASTProcBlockInner elseBody = null)
            : base(location)
        {
            Condition = condition;
            Body = body;
            ElseBody = elseBody;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementIf(this);
        }
    }

    class DMASTProcStatementFor : DMASTProcStatement {
        public DMASTProcStatement Initializer;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementFor(Location location, DMASTProcStatement initializer, DMASTProcBlockInner body)
            : base(location)
        {
            Initializer = initializer;
            Body = body;
        }

        public override void Visit(DMASTVisitor visitor) {
            throw new NotImplementedException();
        }
    }

    class DMASTProcStatementForStandard : DMASTProcStatementFor {
        public DMASTExpression Comparator, Incrementor;

        public DMASTProcStatementForStandard(Location location, DMASTProcStatement initializer, DMASTExpression comparator, DMASTExpression incrementor, DMASTProcBlockInner body)
            : base(location, initializer, body)
        {
            Comparator = comparator;
            Incrementor = incrementor;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementForStandard(this);
        }
    }

    class DMASTProcStatementForList : DMASTProcStatementFor {
        public DMASTIdentifier Variable;
        public DMASTExpression List;

        public DMASTProcStatementForList(Location location, DMASTProcStatement initializer, DMASTIdentifier variable, DMASTExpression list, DMASTProcBlockInner body)
            : base(location, initializer, body)
        {
            Variable = variable;
            List = list;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementForList(this);
        }
    }

    class DMASTProcStatementForRange : DMASTProcStatementFor {
        public DMASTIdentifier Variable;
        public DMASTExpression RangeStart, RangeEnd, Step;

        public DMASTProcStatementForRange(Location location, DMASTProcStatement initializer, DMASTIdentifier variable, DMASTExpression rangeStart, DMASTExpression rangeEnd, DMASTExpression step, DMASTProcBlockInner body)
            : base(location, initializer, body)
        {
            Variable = variable;
            RangeStart = rangeStart;
            RangeEnd = rangeEnd;
            Step = step;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementForRange(this);
        }
    }

    class DMASTProcStatementForLoop : DMASTProcStatement {
        public DMASTProcStatementVarDeclaration VariableDeclaration;
        public DMASTCallable Variable;
        public DMASTExpression Condition, Incrementer;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementForLoop(Location location, DMASTProcStatementVarDeclaration variableDeclaration, DMASTCallable variable, DMASTExpression condition, DMASTExpression incrementer, DMASTProcBlockInner body)
            : base(location)
        {
            VariableDeclaration = variableDeclaration;
            Variable = variable;
            Condition = condition;
            Incrementer = incrementer;
            Body = body;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementForLoop(this);
        }
    }

    class DMASTProcStatementWhile : DMASTProcStatement {
        public DMASTExpression Conditional;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementWhile(Location location, DMASTExpression conditional, DMASTProcBlockInner body)
            : base(location)
        {
            Conditional = conditional;
            Body = body;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementWhile(this);
        }
    }

    class DMASTProcStatementDoWhile : DMASTProcStatement {
        public DMASTExpression Conditional;
        public DMASTProcBlockInner Body;

        public DMASTProcStatementDoWhile(Location location, DMASTExpression conditional, DMASTProcBlockInner body)
            : base(location)
        {
            Conditional = conditional;
            Body = body;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementDoWhile(this);
        }
    }

    class DMASTProcStatementSwitch : DMASTProcStatement {
        public class SwitchCase {
            public DMASTProcBlockInner Body;

            protected SwitchCase(DMASTProcBlockInner body) {
                Body = body;
            }
        }

        public class SwitchCaseDefault : SwitchCase {
            public SwitchCaseDefault(DMASTProcBlockInner body) : base(body) { }
        }

        public class SwitchCaseValues : SwitchCase {
            public DMASTExpressionConstant[] Values;

            public SwitchCaseValues(DMASTExpressionConstant[] values, DMASTProcBlockInner body) : base(body) {
                Values = values;
            }
        }

        public DMASTExpression Value;
        public SwitchCase[] Cases;

        public DMASTProcStatementSwitch(Location location, DMASTExpression value, SwitchCase[] cases)
            : base(location)
        {
            Value = value;
            Cases = cases;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementSwitch(this);
        }
    }

    class DMASTProcStatementBrowse : DMASTProcStatement {
        public DMASTExpression Receiver;
        public DMASTExpression Body;
        public DMASTExpression Options;

        public DMASTProcStatementBrowse(Location location, DMASTExpression receiver, DMASTExpression body, DMASTExpression options)
            : base(location)
        {
            Receiver = receiver;
            Body = body;
            Options = options;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementBrowse(this);
        }
    }
    
    class DMASTProcStatementBrowseResource : DMASTProcStatement {
        public DMASTExpression Receiver;
        public DMASTExpression File;
        public DMASTExpression Filename;

        public DMASTProcStatementBrowseResource(Location location, DMASTExpression receiver, DMASTExpression file, DMASTExpression filename)
            : base(location)
        {
            Receiver = receiver;
            File = file;
            Filename = filename;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementBrowseResource(this);
        }
    }

    class DMASTProcStatementOutputControl : DMASTProcStatement {
        public DMASTExpression Receiver;
        public DMASTExpression Message;
        public DMASTExpression Control;

        public DMASTProcStatementOutputControl(Location location, DMASTExpression receiver, DMASTExpression message, DMASTExpression control)
            : base(location)
        {
            Receiver = receiver;
            Message = message;
            Control = control;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcStatementOutputControl(this);
        }
    }

    class DMASTIdentifier : DMASTExpression {
        public string Identifier;

        public DMASTIdentifier(Location location, string identifier)
            : base(location)
        {
            Identifier = identifier;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitIdentifier(this);
        }
    }

    class DMASTConstantInteger : DMASTExpressionConstant {
        public int Value;

        public DMASTConstantInteger(Location location, int value)
            : base(location)
        {
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantInteger(this);
        }
    }

    class DMASTConstantFloat : DMASTExpressionConstant {
        public float Value;

        public DMASTConstantFloat(Location location, float value)
            : base(location)
        {
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantFloat(this);
        }
    }

    class DMASTConstantString : DMASTExpressionConstant {
        public string Value;

        public DMASTConstantString(Location location, string value)
            : base(location)
        {
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantString(this);
        }
    }

    class DMASTConstantResource : DMASTExpressionConstant {
        public string Path;

        public DMASTConstantResource(Location location, string path)
            : base(location)
        {
            Path = path;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantResource(this);
        }
    }

    class DMASTConstantNull : DMASTExpressionConstant {
        public DMASTConstantNull(Location location)
            : base(location)
        {}

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantNull(this);
        }
    }

    class DMASTConstantPath : DMASTExpressionConstant {
        public DMASTPath Value;

        public DMASTConstantPath(Location location, DMASTPath value)
            : base(location)
        {
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitConstantPath(this);
        }
    }

    class DMASTStringFormat : DMASTExpression {
        public string Value;
        public DMASTExpression[] InterpolatedValues;

        public DMASTStringFormat(Location location, string value, DMASTExpression[] interpolatedValues)
            : base(location)
        {
            Value = value;
            InterpolatedValues = interpolatedValues;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitStringFormat(this);
        }
    }

    class DMASTList : DMASTExpression {
        public DMASTCallParameter[] Values;

        public DMASTList(Location location, DMASTCallParameter[] values)
            : base(location)
        {
            Values = values;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitList(this);
        }
    }

    class DMASTInput : DMASTExpression {
        public DMASTCallParameter[] Parameters;
        public DMValueType Types;
        public DMASTExpression List;

        public DMASTInput(Location location, DMASTCallParameter[] parameters, DMValueType types, DMASTExpression list)
            : base(location)
        {
            Parameters = parameters;
            Types = types;
            List = list;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitInput(this);
        }
    }
    
    class DMASTInitial : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTInitial(Location location, DMASTExpression expression)
            : base(location)
        {
            Expression = expression;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitInitial(this);
        }
    }

    class DMASTIsType : DMASTExpression {
        public DMASTExpression Value;
        public DMASTExpression Type;

        public DMASTIsType(Location location, DMASTExpression value, DMASTExpression type)
            : base(location)
        {
            Value = value;
            Type = type;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitIsType(this);
        }
    }
    
    class DMASTImplicitIsType : DMASTExpression {
        public DMASTExpression Value;

        public DMASTImplicitIsType(Location location, DMASTExpression value)
            : base(location)
        {
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitImplicitIsType(this);
        }
    }

    class DMASTLocateCoordinates : DMASTExpression {
        public DMASTExpression X, Y, Z;

        public DMASTLocateCoordinates(Location location, DMASTExpression x, DMASTExpression y, DMASTExpression z)
            : base(location)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitLocateCoordinates(this);
        }
    }
    
    class DMASTLocate : DMASTExpression {
        public DMASTExpression Expression;
        public DMASTExpression Container;

        public DMASTLocate(Location location, DMASTExpression expression, DMASTExpression container)
            : base(location)
        {
            Expression = expression;
            Container = container;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitLocate(this);
        }
    }

    class DMASTCall : DMASTExpression {
        public DMASTCallParameter[] CallParameters, ProcParameters;

        public DMASTCall(Location location, DMASTCallParameter[] callParameters, DMASTCallParameter[] procParameters)
            : base(location)
        {
            CallParameters = callParameters;
            ProcParameters = procParameters;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitCall(this);
        }
    }

    class DMASTAssign : DMASTExpression {
        public DMASTExpression Expression, Value;

        public DMASTAssign(Location location, DMASTExpression expression, DMASTExpression value)
            : base(location)
        {
            Expression = expression;
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitAssign(this);
        }
    }

    class DMASTNewPath : DMASTExpression {
        public DMASTPath Path;
        public DMASTCallParameter[] Parameters;

        public DMASTNewPath(Location location, DMASTPath path, DMASTCallParameter[] parameters)
            : base(location)
        {
            Path = path;
            Parameters = parameters;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitNewPath(this);
        }
    }

    class DMASTNewIdentifier : DMASTExpression {
        public DMASTIdentifier Identifier;
        public DMASTCallParameter[] Parameters;

        public DMASTNewIdentifier(Location location, DMASTIdentifier identifier, DMASTCallParameter[] parameters)
            : base(location)
        {
            Identifier = identifier;
            Parameters = parameters;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitNewIdentifier(this);
        }
    }

    class DMASTNewDereference : DMASTExpression {
        public DMASTDereference Dereference;
        public DMASTCallParameter[] Parameters;

        public DMASTNewDereference(Location location, DMASTDereference dereference, DMASTCallParameter[] parameters)
            : base(location)
        {
            Dereference = dereference;
            Parameters = parameters;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitNewDereference(this);
        }
    }

    class DMASTNewInferred : DMASTExpression {
        public DMASTCallParameter[] Parameters;

        public DMASTNewInferred(Location location, DMASTCallParameter[] parameters)
            : base(location)
        {
            Parameters = parameters;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitNewInferred(this);
        }
    }

    class DMASTNot : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTNot(Location location, DMASTExpression expression)
            : base(location)
        {
            Expression = expression;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitNot(this);
        }
    }

    class DMASTNegate : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTNegate(Location location, DMASTExpression expression)
            : base(location)
        {
            Expression = expression;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitNegate(this);
        }
    }

    class DMASTEqual : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTEqual(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitEqual(this);
        }
    }

    class DMASTNotEqual : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTNotEqual(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitNotEqual(this);
        }
    }

    class DMASTLessThan : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTLessThan(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitLessThan(this);
        }
    }

    class DMASTLessThanOrEqual : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTLessThanOrEqual(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitLessThanOrEqual(this);
        }
    }

    class DMASTGreaterThan : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTGreaterThan(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitGreaterThan(this);
        }
    }

    class DMASTGreaterThanOrEqual : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTGreaterThanOrEqual(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitGreaterThanOrEqual(this);
        }
    }

    class DMASTMultiply : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTMultiply(Location location ,DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitMultiply(this);
        }
    }

    class DMASTDivide : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTDivide(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitDivide(this);
        }
    }

    class DMASTModulus : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTModulus(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitModulus(this);
        }
    }

    class DMASTPower : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTPower(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitPower(this);
        }
    }

    class DMASTAdd : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTAdd(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitAdd(this);
        }
    }

    class DMASTSubtract : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTSubtract(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitSubtract(this);
        }
    }

    class DMASTPreIncrement : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTPreIncrement(Location location, DMASTExpression expression)
            : base(location)
        {
            Expression = expression;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitPreIncrement(this);
        }
    }

    class DMASTPreDecrement : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTPreDecrement(Location location, DMASTExpression expression)
            : base(location)
        {
            Expression = expression;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitPreDecrement(this);
        }
    }

    class DMASTPostIncrement : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTPostIncrement(Location location, DMASTExpression expression)
            : base(location)
        {
            Expression = expression;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitPostIncrement(this);
        }
    }

    class DMASTPostDecrement : DMASTExpression {
        public DMASTExpression Expression;

        public DMASTPostDecrement(Location location, DMASTExpression expression)
            : base(location)
        {
            Expression = expression;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitPostDecrement(this);
        }
    }

    class DMASTTernary : DMASTExpression {
        public DMASTExpression A, B, C;

        public DMASTTernary(Location location, DMASTExpression a, DMASTExpression b, DMASTExpression c)
            : base(location)
        {
            A = a;
            B = b;
            C = c;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitTernary(this);
        }
    }

    class DMASTAppend : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTAppend(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitAppend(this);
        }
    }

    class DMASTRemove : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTRemove(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitRemove(this);
        }
    }

    class DMASTCombine : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTCombine(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitCombine(this);
        }
    }

    class DMASTMask : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTMask(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitMask(this);
        }
    }

    class DMASTMultiplyAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTMultiplyAssign(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitMultiplyAssign(this);
        }
    }

    class DMASTDivideAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTDivideAssign(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitDivideAssign(this);
        }
    }

    class DMASTLeftShiftAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTLeftShiftAssign(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitLeftShiftAssign(this);
        }
    }

    class DMASTRightShiftAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTRightShiftAssign(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitRightShiftAssign(this);
        }
    }

    class DMASTXorAssign : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTXorAssign(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitXorAssign(this);
        }
    }

    class DMASTOr : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTOr(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitOr(this);
        }
    }

    class DMASTAnd : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTAnd(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitAnd(this);
        }
    }

    class DMASTBinaryAnd : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTBinaryAnd(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitBinaryAnd(this);
        }
    }

    class DMASTBinaryXor : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTBinaryXor(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitBinaryXor(this);
        }
    }

    class DMASTBinaryOr : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTBinaryOr(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitBinaryOr(this);
        }
    }

    class DMASTBinaryNot : DMASTExpression {
        public DMASTExpression Value;

        public DMASTBinaryNot(Location location, DMASTExpression value)
            : base(location)
        {
            Value = value;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitBinaryNot(this);
        }
    }

    class DMASTLeftShift : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTLeftShift(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitLeftShift(this);
        }
    }

    class DMASTRightShift : DMASTExpression {
        public DMASTExpression A, B;

        public DMASTRightShift(Location location, DMASTExpression a, DMASTExpression b)
            : base(location)
        {
            A = a;
            B = b;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitRightShift(this);
        }
    }

    class DMASTExpressionIn : DMASTExpression {
        public DMASTExpression Value;
        public DMASTExpression List;

        public DMASTExpressionIn(Location location, DMASTExpression value, DMASTExpression list)
            : base(location)
        {
            Value = value;
            List = list;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitIn(this);
        }
    }

    class DMASTListIndex : DMASTExpression {
        public DMASTExpression Expression;
        public DMASTExpression Index;

        public DMASTListIndex(Location location, DMASTExpression expression, DMASTExpression index)
            : base(location)
        {
            Expression = expression;
            Index = index;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitListIndex(this);
        }
    }

    class DMASTProcCall : DMASTExpression {
        public DMASTCallable Callable;
        public DMASTCallParameter[] Parameters;

        public DMASTProcCall(Location location, DMASTCallable callable, DMASTCallParameter[] parameters)
            : base(location)
        {
            Callable = callable;
            Parameters = parameters;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitProcCall(this);
        }
    }

    class DMASTCallParameter : DMASTNode {
        public DMASTExpression Value;
        public string Name;

        public DMASTCallParameter(Location location, DMASTExpression value, string name = null)
            : base(location)
        {
            Value = value;
            Name = name;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitCallParameter(this);
        }
    }

    class DMASTDefinitionParameter : DMASTNode {
        public DreamPath? ObjectType;
        public string Name;
        public DMASTExpression Value;
        public DMValueType Type;
        public DMASTExpression PossibleValues;

        public DMASTDefinitionParameter(Location location, DMASTPath astPath, DMASTExpression value, DMValueType type, DMASTExpression possibleValues)
            : base(location)
        {
            DreamPath path = astPath.Path;

            int varElementIndex = path.FindElement("var");
            if (varElementIndex != -1) path = path.RemoveElement(varElementIndex);

            ObjectType = (path.Elements.Length > 1) ? path.FromElements(0, -2) : null;
            Name = path.LastElement;
            Value = value;
            Type = type;
            PossibleValues = possibleValues;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitDefinitionParameter(this);
        }
    }

    class DMASTDereference : DMASTCallable {
        public enum DereferenceType {
            Direct,
            Search
        }

        public struct Dereference {
            public DereferenceType Type;
            public string Property;

            public Dereference(DereferenceType type, string property) {
                Type = type;
                Property = property;
            }
        }

        public DMASTExpression Expression;
        public Dereference[] Dereferences;

        public DMASTDereference(Location location, DMASTExpression expression, Dereference[] dereferences)
            : base(location)
        {
            Expression = expression;
            Dereferences = dereferences;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitDereference(this);
        }
    }

    class DMASTDereferenceProc : DMASTDereference/*, DMASTCallable*/ {
        public DMASTDereferenceProc(Location location, DMASTExpression expression, Dereference[] dereferences)
            : base(location, expression, dereferences)
        {}

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitDereferenceProc(this);
        }
    }

    class DMASTCallableProcIdentifier : DMASTCallable {
        public string Identifier;

        public DMASTCallableProcIdentifier(Location location, string identifier)
            : base(location)
        {
            Identifier = identifier;
        }

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitCallableProcIdentifier(this);
        }
    }

    class DMASTCallableSuper : DMASTCallable {
        public DMASTCallableSuper(Location location)
            : base(location)
        {}

        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitCallableSuper(this);
        }
    }

    class DMASTCallableSelf : DMASTCallable {
        public DMASTCallableSelf(Location location)
            : base(location)
        {}
        public override void Visit(DMASTVisitor visitor) {
            visitor.VisitCallableSelf(this);
        }
    }
}
