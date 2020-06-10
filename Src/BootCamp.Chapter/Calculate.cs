using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BootCamp.Chapter
{
    class Calculate
    {
        private ILogger _logger;

        public Calculate()
        {
            _logger = InitialiseLogger();
            _logger.ActionLog("Calculation Program Started");
        }
        public double Add(params double[] numbers)
        {
            try
            {
                var sum = 0.0;
                foreach (var x in numbers)
                {
                    if(x.GetType() == typeof(double))
                    {
                        sum += x;
                    }
                    else
                    {
                        throw new ArgumentException($"{x} is not a valid value");
                    }
                    
                }
                _logger.ActionLog($"{string.Join(" + ", numbers)} = {sum}");
                return sum;
            }
            catch(Exception ex)
            {
                _logger.ErrorLog(ex);
                return 0;
            }
        }

        public double Subtract(params double[] numbers)
        {
            try
            {
                var sum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i].GetType() == typeof(double))
                    {
                        sum -= numbers[i];
                    }
                    else
                    {
                        throw new ArgumentException($"{numbers[i]} is not a valid value");
                    }
                }
                _logger.ActionLog($"{string.Join(" - ", numbers)} = {sum}");
                return sum;
            }
            catch(Exception ex)
            {
                _logger.ErrorLog(ex);
                return 0;
            }
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
