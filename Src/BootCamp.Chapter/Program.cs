using System;
using BootCamp.Chapter.Computer;
using static System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var mac = new MacFactory[] { new MacFactory(), new MacFactory()}; 
            foreach(MacFactory a in mac)
            {
                if (a.Assemble().GetBody() != null)
                    Write("Yes ");
            }
            //foreach(MacFactory a in mac)
            //{
            //    for(int i = 0; i < 100; i++)
            //    {
            //        a.Assemble();
                    
                    
            //    }
            //}
            //WriteLine("100 pcs Mac destops have finished.");

            //var win = new MsFactory[] { new MsFactory(), new MsFactory() };
            //foreach (MsFactory b in win)
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        b.Assemble();
            //    }
            //}
            //WriteLine("100 pcs Ms destops have finished.");

        }
    }
}
