﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Hello. Please state your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please state your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please state your weight:");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please state your height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");

            //BMI calculations
            double bmi = weight * 703 / height / height;
            Console.WriteLine("Your BMI is:" + bmi);
            //Code
        }

    }
}
