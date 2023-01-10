using System;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            string firstName = PromptString("What is your name?");
            string lastName = PromptString("What is your last name?");
            int age = PromptInt("How old are you?");
            float weight = PromptFloat("What is your weight (kg)?");
            float height = PromptFloat("What is your height (m)?");
            float bmi = CalculateBmi(weight, height);

            Console.WriteLine($"\n{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. BMI is {bmi}.\n");
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                string errorMessage = "Failed calculating BMI. Reason:";

                if (weight <= 0)
                {
                    errorMessage += $" Weight cannot be equal or less than zero, but was {weight}.";
                }

                if (height <= 0)
                {
                    errorMessage += $" Height cannot be equal or less than zero, but was {height}.";
                }

                Console.WriteLine(errorMessage);

                return -1;
            }

            float bmi = (float)(weight / Math.Pow(height, 2));
            return bmi;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            bool isNumber = float.TryParse(response, out float output);
            if (!isNumber)
            {
                Console.WriteLine($"\"{response}\" is not a valid number.");
                return -1;
            }
            return output;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return response;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            bool isNumber = int.TryParse(response, out int output);
            if (!isNumber)
            {
                Console.WriteLine($"\"{response}\" is not a valid number.");
                return -1;
            }
            return output;
        }
    }
}
