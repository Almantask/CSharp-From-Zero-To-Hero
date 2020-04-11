using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.PremadeAttributes.PermissionsViaFlags
{
    // Flags is used for making combos out of enum
    // For example Read and Write email would be value 0b0011.
    [Flags]
    public enum Permissions
    {
        ReadEmail =  0b0001,
        WriteEmail = 0b0010,
        ReadLogs =   0b0100,
        WriteLogs =  0b1000,
    }
}
