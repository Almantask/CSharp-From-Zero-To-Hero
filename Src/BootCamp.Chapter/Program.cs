using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            var logger = InitialiseLogger();
            var calculate = new Calculate();
            logger.ActionLog((calculate.Add(1, 10).ToString()));
            logger.ActionLog(calculate.Subtract(10, 9).ToString());
        }

        private static ILogger InitialiseLogger()
        {
            while (true)
            {
                Console.WriteLine("Would you like to create a Log File (1) or Log in Console (2) to track activity?");
                var option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        return new FileLogger();

                    case 2:
                        return new ConsoleLogger();

                    default:
                        break;
                }
            }
            
            

        }


       
    }
}
