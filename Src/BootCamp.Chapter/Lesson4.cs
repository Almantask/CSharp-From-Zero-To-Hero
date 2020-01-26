using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Lesson4
    {
        /// <summary>
        /// Indication that the user input for an integer was empty.
        /// </summary>
        public const int EmptyNumberInput = 0;

        /// <summary>
        /// Indication that the user input for an integer was not in range.
        /// </summary>
        public const int InvalidNumberInput = -1;

        /// <summary>
        /// Indication that the user input for a name string was empty.
        /// </summary>
        public const string EmptyName = "-";

        /// <summary>
        /// This function will prompt some user data like name and age and in the end it will print out
        /// the users BMI.
        /// </summary>
        public static void Demo()
        {
            ProcessPerson();
            ProcessPerson();
        }

        /// <summary>
        /// Prints the message and requests for user input of an integer.
        /// </summary>
        /// <param name="message">The message to print.</param>
        /// <returns>The parsed integer if the input was valid, 0 when empty and -1 when invalid.</returns>
        public static int PromptInt(string message)
        {
            if (!PromptTryParse(message, out int parsingResult, out string input))
            {
                return InvalidInput(input);
            }

            return RangeCheck(parsingResult);
        }

        /// <summary>
        /// Prints the message and requests for user input of a float.
        /// </summary>
        /// <param name="message">The message to print.</param>
        /// <returns>The parsed float if the input was valid, 0 when empty and -1 when invalid.
        public static float PromptFloat(string message)
        {
            if (!PromptTryParse(message, out float parsingResult, out string input))
            {
                return InvalidInput(input);
            }

            return RangeCheck(parsingResult);
        }

        /// <summary>
        /// Returns a value that indicates the type of input fault./>
        /// </summary>
        /// <param name="input">The input the user wrote.</param>
        /// <returns>An integer indicating the error.</returns>
        private static int InvalidInput(string input)
        {
            return string.IsNullOrEmpty(input)
                ? EmptyNumberInput
                : PrintInvalidNumber(input);
        }

        /// <summary>
        /// Checks if the given value is in a valid range.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns the value if it is in range or a value indicating the opposite.</returns>
        private static int RangeCheck(int value)
        {
            return IsValidInt(value)
                ? value
                : InvalidNumberInput;
        }

        /// <summary>
        /// Checks if the given value is in a valid range.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns the value if it is in range or a value indicating the opposite.</returns>
        private static float RangeCheck(float value)
        {
            return IsValidFloat(value)
                ? value
                : InvalidNumberInput;
        }

        

        /// <summary>
        /// Request for user name input.
        /// </summary>
        /// <param name="message">The request message.</param>
        /// <returns>The user input.</returns>
        public static string PromptString(string message)
        {
            return IsValidName(PromptInput(message));
        }

        /// <summary>
        /// Calculates the BMI by weight[kg] and height[m].
        /// </summary>
        /// <param name="weightInKg">Weight in kilograms.</param>
        /// <param name="heightInM">Height in meters.</param>
        /// <returns>Returns the BMI or -1 if at least one of the parameters was invalid.</returns>
        public static float CalculateBmi(float weightInKg, float heightInM)
        {
            string errorMessage = "Failed calculating BMI. Reason:";

            bool isInvalidWeight = IsLessEqualZero(weightInKg, "Weight", ref errorMessage);
            bool isInvalidHeight = IsLessEqualZero(heightInM, "Height", ref errorMessage, !isInvalidWeight);
            
            if (isInvalidWeight || isInvalidHeight)
            {
                Console.WriteLine(errorMessage);
                return InvalidNumberInput;
            }

            return weightInKg / heightInM / heightInM;
        }

        /// <summary>
        /// Reads in the data of a person and processes it further.
        /// </summary>
        private static void ProcessPerson()
        {
            string fullName = PromptString("What is your full name? ");
            int age = PromptInt("What is your age? ");
            float weightInKg = PromptFloat("What is your weight in kg? ");
            float heightInCm = PromptFloat("What is your height in cm? ");

            Console.WriteLine($"{fullName} is {age} years old, his weight is {weightInKg} kg and his height is {heightInCm} cm.");
            Console.WriteLine($"His BMI is {CalculateBmi(weightInKg, heightInCm / 100)}.");
        }

        /// <summary>
        /// Prints the message and reads in the user input.
        /// </summary>
        /// <param name="message">The message to print.</param>
        /// <returns>The unparsed and unvalidated input.</returns>
        private static string PromptInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// Prompts for an integer value. Converts the string input to an integer if possible.
        /// </summary>
        /// <param name="message">The message to print before the prompt.</param>
        /// <param name="result">The parsing result. Is 0 if the parsing failed.</param>
        /// <param name="input">The user input.</param>
        /// <returns>Returns true if the parsing succeeded, false otherwise.</returns>
        private static bool PromptTryParse(string message, out int result, out string input)
        {
            input = PromptInput(message);
            return int.TryParse(input, out result);
        }

        /// <summary>
        /// Prompts for a float value. Converts the string input to a float if possible.
        /// </summary>
        /// <param name="message">The message to print before the prompt.</param>
        /// <param name="result">The parsing result. Is 0 if the parsing failed.</param>
        /// <param name="input">The user input.</param>
        /// <returns>Returns true if the parsing succeeded, false otherwise.</returns>
        private static bool PromptTryParse(string message, out float result, out string input)
        {
            input = PromptInput(message);
            return float.TryParse(input, NumberStyles.Float,
                CultureInfo.InvariantCulture, out result);
        }

        /// <summary>
        /// Checks if the given name is valid.
        /// </summary>
        /// <param name="name">The name to check.</param>
        /// <returns>Returns the given name if it is not empty or null, <see cref="EmptyName"/> otherwise.</returns>
        private static string IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.Write("Name cannot be empty.");
                return EmptyName;
            }

            return name;
        }

        /// <summary>
        /// Checks if the given value is valid.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns></returns>
        private static bool IsValidInt(int value)
        {
            return value > 0;
        }

        /// <summary>
        /// Checks if the given value is valid.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is valid, false otherwise.</returns>
        private static bool IsValidFloat(float value)
        {
            return value > 0;
        }

        /// <summary>
        /// Checks if the value is nonpositive.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="name">The identifier of the value.</param>
        /// <param name="errorMessage">The error message that will be displayed if this function returns true.</param>
        /// <param name="printEqual">If true, the function will add "equal or " to the error message.</param>
        /// <returns>True if the value is nonpositive, false otherwise.</returns>
        private static bool IsLessEqualZero(float value, string name, ref string errorMessage, bool printEqual = true)
        {
            string equal = printEqual ? "equal or " : "";
            string errorMessage2 = $"{name} cannot be {equal}less than zero, but was {value}.";
            if (value <= 0)
            {
                errorMessage += $"{Environment.NewLine}{errorMessage2}";
                return true;
            }
            return false;
        }

        /// <summary>
        /// Prints an error text and returns a value indicating the invalidity of the input.
        /// </summary>
        /// <param name="input">The user input.</param>
        /// <returns>Returns <see cref="InvalidNumberInput"/>.</returns>
        private static int PrintInvalidNumber(string input)
        {
            Console.Write($"\"{input}\" is not a valid number.");
            return InvalidNumberInput;
        }
    }
}
