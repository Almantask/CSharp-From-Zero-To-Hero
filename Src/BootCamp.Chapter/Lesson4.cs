using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("What is your first name?");
                var name = Console.ReadLine();

                Console.WriteLine("What is your last name?");
                var surname = Console.ReadLine();

                Console.WriteLine("What is your age?");
                var age = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your weight (in lbs)?"); //Murica
                var weight = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your height (in inches)?"); //Murica
                var height = Single.Parse(Console.ReadLine());

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight +
                    " lbs and his height is " + height + " in.");

                const int dumbAmericanBMIConstant = 703;
                float BMI = (weight / (height * height)) * dumbAmericanBMIConstant;
                Console.WriteLine(name + " " + surname + " has a body-mass index(BMI) of " + BMI + " lbs/in^2\n");
            }
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            
            var isNumber = int.TryParse(input, out int number);
            if (string.IsNullOrEmpty(input)) return 0;
            if (!isNumber)
            {
                Console.Write("\"" + input + "\"" + " is not a valid number.");
                return -1;
            }

            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return name;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var isNumber = Single.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float number);
            if (string.IsNullOrEmpty(input)) return 0;
            if (!isNumber)
            {
                Console.Write("\"" + input + "\"" + " is not a valid number.");
                return -1;
            }

            return number;
        }

        public static float CalculateBMI(float weight, float height)
        {
            var bmiError = "Failed calculating BMI. Reason:";

            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine(bmiError);
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine(bmiError);
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine(bmiError);
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }

            return (weight / (height * height));
        }
    }
}
