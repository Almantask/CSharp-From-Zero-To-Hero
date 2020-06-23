using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BootCamp.Chapter
{
    class CalculatorSimulator
    {
        private ILogger _logger;

        public CalculatorSimulator(ILogger typeoflogger)
        {
            _logger = typeoflogger;
            _logger.LogAction("Calculation Program Started");
        }
        public double Add(params double[] numbers)
        {
            var sum = 0.0;
            foreach (var x in numbers)
            {              
                    sum += x;
            }
            _logger.LogAction($"{string.Join(" + ", numbers)} = {sum}");
            return sum;
        }

        public double Subtract(params double[] numbers)
        {          
            var sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum -= numbers[i];                
            }
            _logger.LogAction($"{string.Join(" - ", numbers)} = {sum}");
            return sum;            
        }
    }
}
