using System;
using BootCamp.Chapter.Examples.CustomAttributes.CustomValidator;
using BootCamp.Chapter.Examples.CustomAttributes.PrintIMportantItems;
using BootCamp.Chapter.Examples.PremadeAttributes.CallingCodeOutsideNET;
using BootCamp.Chapter.Examples.PremadeAttributes.PermissionsViaFlags;
using BootCamp.Chapter.Examples.PremadeAttributes.RelevantDebugDataDisplay;
using BootCamp.Chapter.Examples.PremadeAttributes.ValidationThroughAttributes;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------NET Attributes------");
            DataAnnotationsDemo.Run();
            InteropWithUnamangedCode.Run();
            DebuggerDisplayDemo.Run();
            PermissionsDemo.Run();
            Console.WriteLine("------Custom Attributes-----");
            PlainAttributeDemo.Run();
            CustomValidatorDemo.Run();
        }
    }
}
