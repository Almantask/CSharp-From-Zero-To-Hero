using System;
namespace BootCamp.Chapter
{
    public static class Lesson4
    {
        public static void Demo()
        {
            char repeatQuestionAndReportForAnotherUser = 'y';

            while (repeatQuestionAndReportForAnotherUser == 'y')
            {
                string firstName = RequestString("Please enter first name:");

                string surname = RequestString("Please enter last name:");

                int age = RequestInt("Please enter age in years:");

                float weightInKilograms = RequestFloat("Please enter weight in kilograms:");

                float heightInMeters = RequestFloat("Please enter height in meters:");

                ReportBasicInfo(firstName, surname, age, weightInKilograms, heightInMeters);

                ReportBodyMassIndex(firstName, weightInKilograms, heightInMeters);

                repeatQuestionAndReportForAnotherUser = RequestUserChoiceToRepeatOrNot();
            }
        }
        public static string RequestString(string prompt)
        {
            Console.Write($"{prompt}{Environment.NewLine}");
            return GetValidStringOrErrorCode();
        }
        private static string GetValidStringOrErrorCode()
        {
            var userInput = Console.ReadLine();
            if (ReportTrueIfUserInputIsEmpty(userInput))
            {
                Console.Write($"Name cannot be empty.");
                return "-";
            }
            return userInput;
        }
        public static int RequestInt(string prompt)
        {
            Console.Write($"{prompt}{Environment.NewLine}");
            var userInput = Console.ReadLine();
            if (ReportTrueIfUserInputIsEmpty(userInput))
            {
                return 0;
            }
            return GetValidIntOrErrorCode(userInput);
        }
        static int GetValidIntOrErrorCode(string input)
        {
            var isInt = int.TryParse(input, out var number);
            if (!isInt)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }
        public static float RequestFloat(string prompt)
        {
            Console.Write($"{prompt}{Environment.NewLine}");
            var userInput = Console.ReadLine();
            if (ReportTrueIfUserInputIsEmpty(userInput))
            {
                return 0;
            }
            return GetValidFloatOrErrorCode(userInput);
        }
        static float GetValidFloatOrErrorCode(string input)
        {
            var isFloat = float.TryParse(input, out var number);
            if (!isFloat)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
            return number;
        }
        public static bool ReportTrueIfUserInputIsEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
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
            if (height <= 0 && weight <= 0)
            {
                FailureMessage();
                WeightErrorMessage(weight);
                ShortHeightErrorMessage(height);
                return -1;
            }
            if (height <= 0)
            {
                FailureMessage();
                HeightErrorMessage(height);
                return -1;
            }
            if (weight <= 0)
            {
                FailureMessage();
                WeightErrorMessage(weight);
                return -1;
            }
            return weight / height / height;
        }
        public static void FailureMessage()
        {
            Console.WriteLine("Failed calculating BMI. Reason:");
        }
        public static void HeightErrorMessage(float height)
        {
            Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
        }
        public static void ShortHeightErrorMessage(float height)
        {
            Console.WriteLine($"Height cannot be less than zero, but was {height}.");
        }
        public static void WeightErrorMessage(float weight)
        {
            Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
        }
        public static char RequestUserChoiceToRepeatOrNot()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to repeat this program? (y or n)");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}
