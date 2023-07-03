using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void Demo()
        {
            string name, surname;
            int age;
            float weight, height;
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine("Enter Name:");
                name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter SurName:");
                surname = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter age:");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter weight:");
                weight = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter height:");
                height = float.Parse(Console.ReadLine());



                Console.WriteLine("{0} {1} is {2} years old his weight is {3} kg and his height is {4} cm.", name, surname, age, weight, height);

                float bmi = (weight / height / height) * 10000f;
                Console.WriteLine("your BMI: {0} ", bmi);




                counter++;
            }
        }

        public static float CalculatingBMI(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");

                if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }
                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }

                return -1;

            }
            float bmi = (weight / height / height);
            return bmi;
        }

        public static int PromtInt(string msg)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine();

            bool isNum = int.TryParse(input, out int num);

            if (!isNum)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");

                return -1;
            }
            return num;
        }

        public static float PromtFloat(string msg)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine();

            bool isNum = float.TryParse(input, out float num);

            if (!isNum)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            return num;
        }
        public static string PromtString(string msg)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return input;
        }



    }
}
