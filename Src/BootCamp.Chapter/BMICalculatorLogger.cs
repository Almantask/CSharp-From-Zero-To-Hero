using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
   public class BMICalculatorLogger
    {
        public static void Info (ILogger logger)
        {
            logger.Log("PROGRAM STARTED");

            PrintPersonInformation(logger);
            PrintPersonInformation(logger);

            logger.Log("PROGRAM FINISHED");
        }

       private static string ReadName()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            return name;
        }
        private static int ReadAge(ILogger logger)
        {
            Console.WriteLine("Enter age ");
            string age = Console.ReadLine();
            var isValid = int.TryParse(age, out int realAge);
            if (!isValid)
            {
                logger.Log("Age should be a number");
            }
            return realAge;
        }
        private static double ReadWeight(ILogger logger)
        {
            Console.WriteLine("Enter weight in kg ");
            string weight = Console.ReadLine();
            var isValid = double.TryParse(weight, out double weightInKilograms);
            if (!isValid)
            {
                logger.Log("Weight should be a number");
            }
            return weightInKilograms;
        }
        private static double ReadHeight(ILogger logger)
        {
            Console.WriteLine("Enter height in cm ");
            string height = Console.ReadLine();
            var isValid  = double.TryParse(height, out double heightInCentemeters);
            if (!isValid)
            {
                logger.Log("Weight should be a number");
            }
            return heightInCentemeters;
        }
        private static double CalculateBMI(double weight, double height)
        {
            double heightInMeters = height / 100.0;
            double BMI = weight / (heightInMeters * heightInMeters);
            return BMI;
        }
        private static void PrintPersonInformation(ILogger logger)
        {
            string name = ReadName();
            int age = ReadAge(logger);
            double weight = ReadWeight(logger);
            double height = ReadHeight(logger);
            
            logger.Log("You have entered:");
            logger.Log($"{name} is {age} years old, his weight is {weight} kg and his height is {height } cm.");
            logger.Log($"BMI: {CalculateBMI(weight, height)}");
        }
    }
}
    