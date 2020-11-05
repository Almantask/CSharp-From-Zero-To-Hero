using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSurname = Lesson3.promptStr("Enter your name");
            int age = Lesson3.promptInt("Enter your age");
            float weight = Lesson3.promptFloat("Enter your weight in Kg");
            float height = Lesson3.promptFloat("Enter your height in m");

            Console.WriteLine(nameSurname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m");

            Lesson3.calculateBMI(weight, height);
        }
    }
}
