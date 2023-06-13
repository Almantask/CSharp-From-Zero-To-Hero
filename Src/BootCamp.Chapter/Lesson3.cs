using System;
using System.Collections.Generic;
using System.Text;

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
            float bmi = (weight / height / height);
            return bmi;
        }

        public static int PromtInt(string msg)
        {
            Console.WriteLine(msg);
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static float PromtFloat(string msg)
        {
            Console.WriteLine(msg);
            float input = float.Parse(Console.ReadLine());
            return input;
        }
        public static string PromtString(string msg)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine();
            return input;
        }



    }
}
