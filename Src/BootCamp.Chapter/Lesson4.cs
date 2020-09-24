using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            AskingInformation();
        }
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);

            if (!isNumber && !string.IsNullOrEmpty(input))
            {
                Console.Write("\"{0}\" is not a valid number.", input);
                return -1;
            }
            if (string.IsNullOrEmpty(input))
            {
                return -1;
            }
            return number;
        }
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            return input;
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out float number);

            if (!isNumber && !string.IsNullOrEmpty(input))
            {
                Console.Write("\"{0}\" is not a valid number.", input);
                return -1;
            }
            if (string.IsNullOrEmpty(input))
            {
                return -1;
            }
            return number;
        }
        public static float CalculateBmi(float weight, float height)
        {
            string error = "";
            float bmi = weight / (height * height);
            if (height <= 0 && weight <= 0)
            {
                error = "Failed calculating BMI. Reason:\nWeight cannot be equal or less than zero, but was " + weight + "\nHeight cannot be equal or less than zero, but was " + height;
                Console.WriteLine(error);
            }
            else if (weight <= 0)
            {
                error = "Failed calculating BMI. Reason: Weight cannot be equal or less than zero, but was " + weight;
                Console.WriteLine(error);
            }
            else if (height <= 0)
            {
                error = "Failed calculating BMI. Reason: Height cannot be equal or less than zero, but was " + height;
                Console.WriteLine(error);
            }
            if (string.IsNullOrEmpty(error))
            {
                return bmi;           
            }
            else
            {
                return -1;
            }
        }
        public static void AskingInformation()
        {
            string firstName, secondName;
            int age;
            float weight, height;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Hello first person, what's your first name?");
                firstName = Console.ReadLine();
                Console.WriteLine("What's your second name?");
                secondName = Console.ReadLine();
                Console.WriteLine("What's your age?");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("What's your weight? (In kg)");
                weight = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("What's your height? (In cm)");
                height = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(firstName + " " + secondName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
                Console.WriteLine("Your body-mass index (BMI) is: " + (weight / ((height / 100) * (height / 100))));
            }
        }
    }
}
