using System;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                NewPerson();
            }
        }

        public static void NewPerson()
        {
            string fName = PromptString("Enter first name:");
            string lName = PromptString("Enter last name:");
            int age = PromptInt("Enter age:");
            float weight = PromptFloat("Enter wight in kg:");
            float height = PromptFloat("Enter height in meters:");
            Console.WriteLine($"{fName} {lName} is {age} years old, their weight is {weight} kg and their height is {height} m.");
            Console.WriteLine($"{fName} {lName}'s BMI is " + CalculateBmi(weight, height));
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Name can not be empty.");
                return "-";
            }
            return userInput;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            if (String.IsNullOrEmpty(userInput))
            {
                return 0;
            }
            if (int.TryParse(userInput, out int parsedInput))
            {
                return parsedInput;
            }
            Console.WriteLine($"{userInput} is not a valid number.");
            return -1;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            if (String.IsNullOrEmpty(userInput))
            {
                return 0;
            }
            if (float.TryParse(userInput, out float ParsedInput))
            {
                return ParsedInput;
            }
            Console.WriteLine($"{userInput} is not a valid number.");
            return -1;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 && height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                }
                return -1;
            }
            return weight / (height * height);
        }
    }
}
