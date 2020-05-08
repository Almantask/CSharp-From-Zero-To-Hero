using BootCamp.Chapter.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BMICalculator
    {
        private const string BmiCalculationError = "Failed calculating BMI. Reason:";

        public static float CalculateBMI(Person person, Logger logger)
        {
            if (person == null) throw new ArgumentNullException();

            logger.Log("Calculating BMI based on given input...");

            if (person.Height <= 0 && person.Weight <= 0)
            {
                logger.LogError($"{BmiCalculationError} \nWeight cannot be equal or less than zero, but was {person.Height} \nHeight cannot be less than zero, but was {person.Weight}.");
                return -1;
            }
            else if (person.Weight <= 0)
            {
                logger.LogError($"{BmiCalculationError} \nWeight cannot be equal or less than zero, but was {person.Weight}");
                return -1;
            }
            else if (person.Height <= 0)
            {
                logger.LogError($"{BmiCalculationError} \nHeight cannot be equal or less than zero, but was {person.Height}");
                return -1;
            }
            else
            {
                return person.Weight / (float)Math.Pow(person.Height, 2);
            }
        }
    }
}
