using System;

[Flags]
public enum Permissions
{
    // FIX THIS ENUM
    Default,
    UserRead,
    UserWrite,
    UserExecute,
    GroupRead,
    GroupWrite,
    GroupExecute,
    EveryoneRead,
    EveryoneWrite,
    EveryoneExecute
}