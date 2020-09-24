using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 2 Mac factories
            MacFactory[] macFactories = new MacFactory[2];
            for (int i = 0; i < macFactories.Length; i++)
            {
                macFactories[i] = new MacFactory();
            }

            // Create 2 MS factories
            MsFactory[] msFactories = new MsFactory[2];
            for (int i = 0; i < msFactories.Length; i++)
            {
                msFactories[i] = new MsFactory();
            }

            // Prepare customer order for 200 of each PC.
            DesktopComputer[] macComputers = new DesktopComputer[200];
            DesktopComputer[] msComputers = new DesktopComputer[200];

            // Assemble 2 x 100 computers from each factory.
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    macComputers[(i * 100) + j] = macFactories[i].Assemble();
                    msComputers[(i * 100) + j] = msFactories[i].Assemble();
                }
            }
        }
    }
}
