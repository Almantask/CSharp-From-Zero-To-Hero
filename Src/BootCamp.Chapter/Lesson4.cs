using System;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            Interview();
            Interview();
        }

        public static void Interview()
        {
            //  gets all the input from the user, if one of them is invalid
            //  it displays the relevant error code and returns
            string name = RecursivePromptString("Name: ", "Name cannot be empty");
            
            string surname = RecursivePromptString("Surname: ", "Surname cannot be empty");
            
            int age = RecursivePromptInt("Age: ");

            float weight = RecursivePromptFloat("Weight(Kg): ");

            float cmHeight = RecursivePromptFloat("Height (cm): ");
            float mHeight = cmHeight / 100f;

            //  prints the description according to user's input
            Console.WriteLine($"{name} {surname} is {age} years old, their weight is {weight}Kg and their height is {cmHeight}cm");

            //  calculate BMI and print errormessage if it got an error
            float bmi = CalculateBmi(weight, mHeight);
            if (bmi < 0)
            {
                Console.WriteLine("Falied to calculate BMI. Reasons:");
                if (mHeight <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {cmHeight}cm.");
                }
                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                return;
            }
            Console.WriteLine($"Their bmi is {bmi}");
        }

        public static float CalculateBmi(float weight, float height)
        {
            //  BMI is only positive and can only be calculated with positive inputs,
            //  if these are negative zero calculate error code based on which ones don't work
            if ((weight <= 0) || (height <= 0))
            {
                return -1f;
            }
            return weight / (height * height);
        }

        public static string RecursivePromptString(string message, string errorMessage)
        {
            string input = PromptString(message);
            if ("-".Equals(input))
            {
                Console.WriteLine(errorMessage);
                return RecursivePromptString(message, errorMessage);
            }
            return input;
        }

        public static int RecursivePromptInt(string message)
        {
            int input = PromptInt(message);
            if (input == -1)
            {
                return RecursivePromptInt(message);
            }
            return input;
        }

        public static float RecursivePromptFloat(string message)
        {
            float input = PromptFloat(message);
            if (input < 0)
            {
                return RecursivePromptFloat(message);
            }
            return input;
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            //return 0 with empty string
            if (String.IsNullOrEmpty(input))
            {
                return 0;
            }

            int result;
            bool isInt = int.TryParse(input, out result);

            if (!isInt)
            {
                Console.WriteLine($"{input} is not a valid number.");
                result = -1;
            }
            return result;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            //return 0 with empty string
            if (String.IsNullOrEmpty(input))
            {
                return 0f;
            }

            float result;
            bool isFloat = float.TryParse(input, out result);

            if (!isFloat)
            {
                Console.WriteLine($"{input} is not a valid number.");
                result = -1;
            }
            return result;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
                
            return "-";
        }
    }
}
