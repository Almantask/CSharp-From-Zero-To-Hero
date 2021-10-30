using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            MsFactory pc = new MsFactory();
            Console.WriteLine(pc.Assemble());

            Console.ReadKey();

        }
    }
}
