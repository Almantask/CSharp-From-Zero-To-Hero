using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        /*
            Modify your old functions to fit the specification:
        
        
        
        
    */
        public static void Demo()
        {
            PromptPersonData();
            PromptPersonData();
        }
        private static void PromptPersonData()
        {
            string firstName = PromptString("What is your first name: ");
            string lastName = PromptString("What is your last name: ");
            //TODO: Invalid height or weight or age that are not numbers should return -1 and print error message ""X" is not a valid number." where X is input from console.
            int age = PromptInt("What is your age: ");
            
            //TODO: Empty string for height or weight or age returns 0
            float weight = PromptFloat("what is your weight in Kg: ");
            float height = PromptFloat("what is your height in cm: ");
            float bmi = BmiCalculator(weight, height / 100);

            Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");

            Console.WriteLine($"Your BMI is {bmi}");
        }
        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }

            return input;
        }
        public static int PromptInt(string message)
        {

            //TODO: Invalid height or weight or age that are not numbers should return -1 and print error message ""X" is not a valid number." where X is input from console.
            Console.Write(message);
            string readLine = Console.ReadLine();
            bool isNumber = int.TryParse(readLine, out int number);

            if (!isNumber)
            {
                Console.WriteLine($"{readLine} is not a valid number");
                return  -1;
            }

            return number;
        }
        public static float PromptFloat(string message)
        {

            //TODO: Invalid height or weight or age that are not numbers should return -1 and print error message ""X" is not a valid number." where X is input from console.
            Console.Write(message);
            string readLine = Console.ReadLine();
            bool isNumber = float.TryParse(readLine, out float number);

            if (!isNumber)
            {
                Console.WriteLine($"{readLine} is not a valid number");
                return -1;
            }

            return number;

        }
        public static float BmiCalculator(float weight, float height)
        {
            //4) During BMI calculation, height or weight less or equal to 0 should print error message in console:
            //-It should start with "Failed calculating BMI. Reason:" followed by a new line:
            //-"Height cannot be equal or less than zero, but was X.", where X is the console input. (X <= 0)
            //- "Weight cannot be equal or less than zero, but was X.", where X is the console input(X <= 0)
            // - If both height and weight are invalid, both validation messages should be printed to console(each in new line)

            return weight / (height * height); // BMI = kg/m2
        }
    }
}
