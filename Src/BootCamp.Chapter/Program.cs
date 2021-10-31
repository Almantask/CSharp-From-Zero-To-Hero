using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            MacFactory mac = new MacFactory();
            Console.WriteLine(mac.Assemble());
            
            MsFactory pc = new MsFactory();
            Console.WriteLine(pc.Assemble());

            MsFactory pc2 = new MsFactory();
            Console.WriteLine(pc2.Assemble());

            Console.ReadKey();

        }
    }
}
