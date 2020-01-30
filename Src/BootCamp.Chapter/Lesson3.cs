using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
         public static string ReadInputString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();
            
            if (string.IsNullOrEmpty(value))
            {
                Console.Write("Name cannot be empty.");
                value = "-";
            }

            return value;
        }

        public static float ReadInputFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            float value = ValidateFloat(input);
            if (value < 0) PrintInvalidNumber(input);

            return value;
        }

        public static int ReadInputInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int value = ValidateInt(input);
            if (value < 0) PrintInvalidNumber(input);
            
            return value; 
        }

        static int ValidateInt(string input)
        {
            int result;
            if (string.IsNullOrEmpty(input))
                result = 0;
            else
                if (!int.TryParse(input, out result))
                    result = -1;
            return result;
        }

        static float ValidateFloat(string input)
        {
            float result;
            if (string.IsNullOrEmpty(input))
                result = 0;
            else
                if (!float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
                result = -1;
            return result;
        }

        static void PrintInvalidNumber(string input)
        {
            Console.Write("\"" + input + "\" is not a valid number.");
        }

        public static float CalculateBmi(float height, float weight)
        {
            if (height <= 0 || weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0)
                    Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                if (height == 0 && weight == 0)  
                    Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                else if (height <= 0)
                    Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }

            float bmi = weight / (height * height);
            return bmi;
        }

        private static void PersonData(int number)
        {
            Console.WriteLine("*** Person " + number + " ***");

            string name = ReadInputString("Name: ");
            string surname = ReadInputString("Surname: ");

            int age = ReadInputInt("Age: ");
            
            float weight = ReadInputFloat("Weight (in kg): ");

            float height = ReadInputFloat("Height (in m): ");

            float bmi = CalculateBmi(height, weight);
            if (bmi >= 0)
            {
                string message = name + " " + surname + " is " + age + " years old, his weight is " + weight + "Kg and his height is " + height + "m.";
                Console.WriteLine(message);
                Console.WriteLine("His BMI is: " + bmi);
            }
        }

        public static void Demo()
        {
            PersonData(1);
            PersonData(2);
        }
    }
}
