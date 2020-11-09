using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public const int IntegerErrorCode = -1;
        public const float FloatErrorCode = -1.0f;
        public const string StringErrorCode = "-";

        private static string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            float result;
            string userInput = Prompt(message);

            if (string.IsNullOrEmpty(userInput) || !float.TryParse(
                userInput,
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out result
            ))
            {
                Console.WriteLine("\"{0}\" is not a valid number.", userInput);
                return FloatErrorCode;
            }
            return result;
        }

        public static int PromptInt(string message)
        {
            int result;
            string userInput = Prompt(message);

            if (string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out result))
            {
                Console.WriteLine("\"{0}\" is not a valid number.", userInput);
                return IntegerErrorCode;
            }
            return result;
        }

        public static string PromptString(string message)
        {
            string userInput = Prompt(message);

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Name cannot be empty.");
                userInput = StringErrorCode;
            }
            return userInput;
        }

        public static float CalculateBmi(float weightKg, float heightM)
        {
            List<string> errorMessages = new List<string>();
            if (heightM <= 0)
            {
                errorMessages.Add(
                    String.Format(
                        "Height cannot be equal or less than zero, but was {0}.",
                        heightM
                ));
            }
            if (weightKg <= 0)
            {
                errorMessages.Add(
                    String.Format(
                        "Weight cannot be equal or less than zero, but was {0}.",
                        weightKg
                ));
            }

            if (errorMessages.Count > 0)
            {
                Console.WriteLine(
                        String.Format(
                            "Failed calculating BMI. Reason: {0}",
                            String.Join("", errorMessages)
                    ));
                return FloatErrorCode;
            }
            else
            {
                return weightKg / (heightM * heightM);
            }
        }
    }
}
