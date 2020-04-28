using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                PersonsBmiProcess();
            }

        }
        public static void PersonsBmiProcess()
        {
            var name = promptStringValue("Name: ");
            int age = promptIntValue("Age: ");

            float weight = promptFloatValue("Weight [Kg]: ");
            float height = promptFloatValue("Height [Cm]: ");

            float bmiheight = height / 100;
            float bmi = bmiCalculated(weight, bmiheight);

            Console.WriteLine($"{name} is {age} years old, their weight is {weight} kg and their height is {height} cm. Therefore, making their BMI [Body Mass Index] {bmi}.\n");
        }
        public static int promptIntValue(string message)
        {
            Console.Write(message);
            int age = Convert.ToInt32(Console.ReadLine());

            return age;
        }

        public static string promptStringValue(string message)
        {
            Console.Write(message);
            string promptStringValue = Console.ReadLine();

            return promptStringValue;
        }

        public static float promptFloatValue(string message)
        {
            Console.Write(message);
            float promptFloatValue = float.Parse(Console.ReadLine());

            return promptFloatValue;
        }
        public static float bmiCalculated(float weight, float bmiheight)
        {
            float bmi = weight / (bmiheight * bmiheight);

            return bmi;
        }
    }
}