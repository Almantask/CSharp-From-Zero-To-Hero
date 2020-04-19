using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Demo demo = new Demo();

            Logger log = new Logger(demo);

            demo.StartDemo();

        }
    }
}
