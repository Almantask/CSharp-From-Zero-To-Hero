using System;
using System;
namespace BootCamp.Chapter
{
    public static class Lesson4
    {
        public static void Demo()
        {
            char again = 'y';

            while (again == 'y')
            {
                string firstName = RequestString("Please enter first name:");

                string surname = RequestString("Please enter last name:");

                int age = RequestInt("Please enter age in years:");
               
                float weightInKilograms = RequestFloat("Please enter weight in kilograms:");

                float heightInMeters = RequestFloat("Please enter height in meters:");

                ReportBasicInfo(firstName, surname, age, weightInKilograms, heightInMeters);

                ReportBodyMassIndex(firstName, weightInKilograms, heightInMeters);

                again = RequestUserChoiceToRepeatOrNot();
            }
        }

        public static string RequestString(string prompt)
        {
            Console.Write(prompt);
            return ValidateString);
        }

        private static string ValidateString(string prompt)
        {
            var userInput = Console.ReadLine();
            if (NullStringCheck(userInput)
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            
            return userInput;
        }

        public static int RequestInt(string prompt)
        {
            Console.Write(prompt);
            return ValidateInt(Console.ReadLine());
        }

        static int ValidateInt(string input)
        {
            if (NullStringCheck(input))
                return 0;
            var isInt = int.TryParse(input, out var number);
            if (!isInt)
            {
                Console.WriteLine($"{input} is not a valid number.");
                return -1;
            }
                         
            return number;
        }

        static float ValidateFloat(string input)
        {
            if (NullStringCheck(input))
                return 0;
            var isFloat = float.TryParse(input, out var number);
            if (!isFloat)
            {
                Console.WriteLine($"{input} is not a valid number.");
                return -1;
            }
            else
                return number;
        }

        public static float RequestFloat(string prompt)
        {
            Console.Write(prompt);
            return ValidateFloat(Console.ReadLine());
        }

        public static bool NullStringCheck(string input)
        {
            return string.IsNullOrEmpty(input);
        }
        private static bool SafeStringCheck (string input1, string input2)
        {
            return input1.Equals(input2);
        }
        public static void ReportBasicInfo(string firstName, string surname, int age, double weight, double height)
        {
            Console.WriteLine();
            Console.WriteLine(firstName + " " + surname +
                " is " + age + " years old, " +
                "their weight is " + weight + " kg " +
                "and their height is " + height + " m.");
        }

        public static void ReportBodyMassIndex(string firstName, float weight, float height)
        {
            Console.WriteLine();
            Console.WriteLine(firstName + "s BMI is " + (CalculateBodyMassIndex(weight, height)) + ".");
        }

        public static float CalculateBodyMassIndex(float weight, float height)
        {
            return weight / height / height;
        }

        public static char RequestUserChoiceToRepeatOrNot()
        {
            Console.WriteLine();
            Console.Write("Would you like to repeat this program? (y or n)");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}

