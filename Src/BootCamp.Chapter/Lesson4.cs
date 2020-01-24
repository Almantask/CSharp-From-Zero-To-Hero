using System;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            PromptPersonData();
            PromptPersonData();
        }
        private static void PromptPersonData()
        {
            string firstName = NamePrompt("What is your first name: ");
            string lastName = NamePrompt("What is your last name: ");
            int age = PromptInt("What is your age: ");
            float weight = PromptFloat("what is your weight in Kg: ");
            float height = PromptFloat("what is your height in cm: ");
            
            Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");

            float bmi = BmiCalculator(weight, height / 100);
            Console.WriteLine($"Your BMI is {bmi}");
        }
        public static string NamePrompt(string message)
        {
            string name = PromptString(message);

            if (name.Equals("-"))
            {
                Console.WriteLine("Name cannot be empty.");
            }

            return name;
        }
        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                return "-";
            }

            return input;
        }
        public static int PromptInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                return 0;
            }

            bool isNumber = int.TryParse(input, out int number);

            if (!isNumber)
            {
                Console.WriteLine($"\"{input}\" is not a valid number");
                return  -1;
            }

            return number;
        }
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                return 0f;
            }

            bool isNumber = float.TryParse(input, out float number);

            if (!isNumber)
            {
                Console.WriteLine($"\"{input}\" is not a valid number");
                return -1f;
            }

            return number;

        }
        public static float BmiCalculator(float weight, float height)
        {
            bool isWeightLessThanOrEqualTo0 = weight <= 0;
            bool isHeightLessThanOrEqualTo0 = height <= 0;

            if (isWeightLessThanOrEqualTo0 || isHeightLessThanOrEqualTo0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (isHeightLessThanOrEqualTo0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }
                if (isWeightLessThanOrEqualTo0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                return -1f;
            }
            else
            {
                return weight / (height * height); // BMI = kg/m2
            }

           
        }

    }
}
