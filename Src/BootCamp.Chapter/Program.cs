using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Demo demo = new Demo(menu);

            Logger log = new Logger(menu);

            demo.StartDemo();
        }
    }
}
