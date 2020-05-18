using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            DemoExtensions.Run();
            DemoLinq.Run();
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
