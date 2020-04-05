using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            Console.Write("How many are you?: ");
            int howMany = int.Parse(Console.ReadLine());
            if (howMany <= 0)
            {
                return;
            }
            else if (howMany <= 1)
            {
                for (int i = 1; i <= howMany; i++)
                {
                    PromptPersonData();
                }
            }

        }

        private static void PromptPersonData()
        {
            string name = PromptString("What is your first name: ");
            string surname = PromptString("What is your last name: ");
            int age = PromptInt("What is your age: ");
            float weight = PromptFloat("what is your weight in Kg: ");
            float height = PromptFloat("what is your height in m (ex. 1.80m): ");
            float bmi = BmiCalculator(weight, height);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");

            Console.WriteLine($"Your BMI is {bmi}");
        }        

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();


            if (String.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }            

            return input;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                Console.Write($"{input}");
                return 0;
            }

            bool isNumber = int.TryParse(input, out int number);

            if (!isNumber) {

                // "10b" is not a valid number."
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;

            }
            if (number == 0) return 0;
            else
                return number;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            // if intput is "" it should retunr 0 , fisr place and the other lines after it shouldd stop working
            if (String.IsNullOrEmpty(input))
            {
                Console.Write($"{input}");
                return 0;
            }
            else
            {
                bool isNumber = float.TryParse(input, out float number);

                if (!isNumber)
                {

                    // "10b" is not a valid number."
                    Console.Write($"\"{input}\" is not a valid number.");
                    return -1;

                }
                if (number == 0) return 0;
                else
                    return number;
            }            
        }

        public static float BmiCalculator(float weight, float height)
        {
            bool isWeightLessOrEqualToZero = weight <= 0;
            bool isHeightLessOrEqualToZero = height <= 0;

            if (isWeightLessOrEqualToZero && isHeightLessOrEqualToZero)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                return -1;
            }
            else if (isWeightLessOrEqualToZero || isHeightLessOrEqualToZero)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (isWeightLessOrEqualToZero)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                else if (isHeightLessOrEqualToZero)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }
                return -1;
            }
            else
            {
                return weight / (height * height);
            }
        }
    }
}
