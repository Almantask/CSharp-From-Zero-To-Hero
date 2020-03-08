using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "./logger.txt";
            var logger = new Logger(file);
            logger.LogStart();

            Console.WriteLine("Start");

            var foo = new int[0];
            try
            {
                Console.WriteLine(foo[1]);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            

            logger.LogExit();
            Environment.Exit(0);
        }



    }
}
