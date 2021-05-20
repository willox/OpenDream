﻿namespace OpenDreamShared.Dream.Procs {
    enum DreamProcOpcode {
        BitShiftLeft = 0x1,
        GetIdentifier = 0x2,
        PushString = 0x3,
        FormatString = 0x4,
        PushInt = 0x5,
        SetLocalVariable = 0x6,
        PushPath = 0x7,
        Add = 0x8,
        Assign = 0x9,
        Call = 0xA,
        Dereference = 0xB,
        JumpIfFalse = 0xC,
        JumpIfTrue = 0xD,
        Jump = 0xE,
        CompareEquals = 0xF,
        Return = 0x10,
        PushNull = 0x11,
        Subtract = 0x12,
        CompareLessThan = 0x13,
        CompareGreaterThan = 0x14,
        BooleanAnd = 0x15,
        BooleanNot = 0x16,
        PushSuperProc = 0x17,
        Negate = 0x18,
        Modulus = 0x19,
        Append = 0x1A,
        CreateRangeEnumerator = 0x1B,
        PushUsr = 0x1C,
        CompareLessThanOrEqual = 0x1D,
        IndexList = 0x1E,
        Remove = 0x1F,
        DeleteObject = 0x20,
        PushResource = 0x21,
        CreateList = 0x22,
        CallStatement = 0x23,
        BitAnd = 0x24,
        CompareNotEquals = 0x25,
        ListAppend = 0x26,
        Divide = 0x27,
        Multiply = 0x28,
        PushSelf = 0x29,
        BitXor = 0x2A,
        BitOr = 0x2B,
        BitNot = 0x2C,
        Combine = 0x2D,
        CreateObject = 0x2E,
        BooleanOr = 0x2F,
        PushArgumentList = 0x30,
        CompareGreaterThanOrEqual = 0x31,
        SwitchCase = 0x32,
        Mask = 0x33,
        ListAppendAssociated = 0x34,
        Error = 0x35,
        IsInList = 0x36,
        PushArguments = 0x37,
        PushFloat = 0x38,
        PushSrc = 0x39,
        CreateListEnumerator = 0x3A,
        Enumerate = 0x3B,
        DestroyEnumerator = 0x3C,
        Browse = 0x3D,
        BrowseResource = 0x3E,
        OutputControl = 0x3F,
        BitShiftRight = 0x40,
        PushLocalVariable = 0x41,
        Power = 0x42,
        DereferenceProc = 0x43,
        GetProc = 0x44,
        Prompt = 0x45,
        PushProcArguments = 0x46,
        Initial = 0x47,
        CallSelf = 0x48,
        IsType = 0x49,
        LocateCoord = 0x4A,
        Locate = 0x4B,
        IsNull = 0x4C,
        Spawn = 0x4D
    }

    enum DreamProcOpcodeParameterType {
        Named = 0xFC,
        Unnamed = 0xFD
    }

    enum StringFormatTypes {
        Stringify = 0x0,
        Ref = 0x1
    }

    public enum DMValueType {
        Anything = 0x0,
        Null = 0x1,
        Text = 0x2,
        Obj = 0x4,
        Mob = 0x8,
        Turf = 0x10,
        Num = 0x20,
        Message = 0x40,
        Area = 0x80,
        Color = 0x100,
        File = 0x200
    }
}
