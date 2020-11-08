using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.VisualBasic;

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
        private const int NumericalErrorResult = -1;
        private const string StringErrorResult = "-";

        public static float PromptFloat(string message, bool? onlyAcceptPositive = null)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            float result;
            if (string.IsNullOrEmpty(userInput) || !float.TryParse(
                userInput,
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out result
            ))
            {
                Console.WriteLine("\"{0}\" is not a valid number.", userInput);
                return (float)NumericalErrorResult;
            } 
            else if (onlyAcceptPositive.HasValue && (onlyAcceptPositive ?? false) && Math.Sign(result) == -1)
            {
                Console.WriteLine("\"{0}\" is not a positive number.", result);
                return (float)NumericalErrorResult;
            }
            return result;
        }

        public static int PromptInt(string message, bool? onlyAcceptPositive = null)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            int result;
            if (string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out result))
            {
                Console.WriteLine("\"{0}\" is not a valid number.", userInput);
                return NumericalErrorResult;
            }
            else if ((onlyAcceptPositive.HasValue && (onlyAcceptPositive ?? false) && Math.Sign(result) == -1))
            {
                Console.WriteLine("\"{0}\" is not a positive number.", result);
                return NumericalErrorResult;
            }
            return result;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Name cannot be empty.");
                userInput = StringErrorResult;
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
            
            if (errorMessages.Count == 0)
            {
                return weightKg / (heightM * heightM);
            }
            else
            {
                Console.WriteLine(
                    String.Format(
                        "Failed calculating BMI. Reason: {0}", 
                        String.Join("", errorMessages)
                ));
                return (float)NumericalErrorResult;
            }
        }
    }
}
