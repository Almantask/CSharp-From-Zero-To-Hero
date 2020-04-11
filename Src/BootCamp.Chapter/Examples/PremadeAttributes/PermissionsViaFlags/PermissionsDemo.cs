using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.PremadeAttributes.PermissionsViaFlags
{
    public static class PermissionsDemo
    {
        public static void Run()
        {
            Permissions myPermissions = Permissions.ReadEmail | Permissions.WriteEmail;
            // Prints "ReadEmail, WriteEmail".
            Console.WriteLine(myPermissions);
            
            if (myPermissions.HasFlag(Permissions.ReadEmail))
            {
                // Prints "Reading email".
                Console.WriteLine("Reading email");
            }
        }
    }
}
