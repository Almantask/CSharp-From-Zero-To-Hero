using System;
using BootCamp.Chapter.Examples.CustomAttributes.CustomValidator;
using BootCamp.Chapter.Examples.CustomAttributes.PrintIMportantItems;
using BootCamp.Chapter.Examples.PremadeAttributes.DataAnnotations;
using BootCamp.Chapter.Examples.PremadeAttributes.DebuggerDisplay;
using BootCamp.Chapter.Examples.PremadeAttributes.OutsideNET;
using BootCamp.Chapter.Examples.PremadeAttributes.PermissionsViaFlags;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            int a = 5; var o = new { a }; Console.Write(o);
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
