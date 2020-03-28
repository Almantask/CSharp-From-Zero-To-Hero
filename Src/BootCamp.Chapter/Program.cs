using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Factory> factories = new List<Factory>();
            factories.Add(new MacFactory());
            factories.Add(new MsFactory());

            foreach (Factory fac in factories)
            {
                fac.Assemble(fac.Brand());
            }

        }
    }
}
