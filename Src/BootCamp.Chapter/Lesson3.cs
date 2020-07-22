using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static float globalHeight = 0f;
        public static float globalWeight = 0f;

        public static string Information()
        {
            Console.WriteLine("Testing");
            string firstName = Console.ReadLine();

            return firstName;
        }

        public static int AskAge()
        {
            Console.WriteLine("Testing");
            string sAge = Console.ReadLine();

            int age = int.Parse(sAge);

            return age;
        }

        public static float Weight()
        {
            Console.WriteLine("What is your weight in kgs?");
            string sWeight = Console.ReadLine();

            globalWeight = float.Parse(sWeight);

            return globalWeight;
        }

        public static float Height()
        {
            Console.WriteLine("Testing");
            string sHeight = Console.ReadLine();

            globalHeight = float.Parse(sHeight);

            return globalHeight;
        }

        public static float BMIFormula(float weight, float height)
        {

            float bmiValue = weight / height / height;

            return bmiValue;
        }

        public static void Message()
        {
            Console.WriteLine(Lesson3.Information() + " is " + Lesson3.AskAge() + " years old, their weight in kg is " + Lesson3.Weight()
            + " and their height in cm is " + Lesson3.Height() + ". " + "Their BMI is " + Lesson3.BMIFormula(globalWeight, globalHeight));
        }
    }
}
