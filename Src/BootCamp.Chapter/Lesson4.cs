using System;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        const string FirstNameMessage = "Enter your first name: ";
        const string LastNameMessage = "Enter your last name: ";
        const string AgeMessage = "Enter your age: ";
        const string WeightMessage = "Enter your weight (in kg): ";
        const string HeightMessage = "Enter your height (in meters): ";
        
        static string consoleInputWeight;
        static string consoleInputHeight;

        public static void Demo()
        {            
            string firstName = PromptString(FirstNameMessage);
            string lastName = PromptString(LastNameMessage);
            int age = PromptInt(AgeMessage);
            float weight = PromptFloat(WeightMessage);
            float height = PromptFloat(HeightMessage);
            float bmi = CalculateBmi(weight, height);

            const string Response = "{0} {1} is {2} years old, he has a BMI of {3} with a weight of {4} kg and a height of {5} meters.";
            if (bmi > 0) Console.WriteLine(Response, firstName, lastName, age, bmi, weight, height);
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            bool isInteger = int.TryParse(input, out int number);
            if (isInteger) return number;

            bool gotInput = !(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));
            Console.WriteLine("\"" + input + "\"" + " is not a valid number!");
            return (gotInput) ? -1 : 0;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            
            bool gotInput = !(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));
            if (gotInput) return input;

            Console.WriteLine("Name cannot be empty.");
            return "-";
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            bool isFloat = float.TryParse(input, out float number);
            if (isFloat) return number;

            string inputNotNumber = "\"" + input + "\"" + " is not a valid number!";
            Console.WriteLine(inputNotNumber);

            if (message.Equals(WeightMessage)) consoleInputWeight = input;
            if (message.Equals(HeightMessage)) consoleInputHeight = input;

            bool gotInput = !(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));            
            return (gotInput) ? -1 : 0;            
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (height <= 0 || weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (height <= 0) Console.WriteLine("Height cannot be less than zero, but was \"{0}\".", consoleInputHeight);
                if (weight <= 0) Console.WriteLine("Weight cannot be less than zero, but was \"{0}\".", consoleInputWeight);
                return 0;
            }
            return weight / (height * height);
        }
    }
}
