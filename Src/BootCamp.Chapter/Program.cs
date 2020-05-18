using System;
using System.Globalization;
using BootCamp.Chapter.Demo;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new DelegateDemo();
            demo.Run();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
