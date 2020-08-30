using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MacFactory macFactory1 = new MacFactory();
            MacFactory macFactory2 = new MacFactory();
            MsFactory msFactory1 = new MsFactory();
            MsFactory msFactory2 = new MsFactory();


            for (int i = 0; i < 100; i++)
            {
                macFactory1.Assemble();
                macFactory2.Assemble();
                msFactory1.Assemble();
                msFactory2.Assemble();
            }
           
        }
    }
}
