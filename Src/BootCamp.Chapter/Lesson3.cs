using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            string name = ReadString("Enter name: ");
            int age = ReadInt("Enter age: ");
            float weight = ReadFloat("Enter weight: ");
            float height = ReadFloat("Enter height in m: ");

            Console.WriteLine("You have entered:");
            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("BMI: " + CalculateBMI(weight, height));
        }

        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            string readString = Console.ReadLine();
            return readString;
        }

        public static int ReadInt(string message)
        {
            Console.WriteLine(message);
            int readInt = int.Parse(Console.ReadLine());
            return readInt;
        }

        public static float ReadFloat(string message)
        {
            Console.WriteLine(message);
            float readFloat = float.Parse(Console.ReadLine());
            return readFloat;
        }

        public static float CalculateBMI(float weight, float height)
        {
            float BMI = weight / (height * height);
            return BMI;
        }

    }
}
