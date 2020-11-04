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
            string nameSurname = " ";
            nameSurname = Lesson3.promptStr("Enter your name", nameSurname);
            int age = 0;
            age = Lesson3.promptInt("Enter your age", age);
            float weight = 0;
            weight = Lesson3.promptFloat("Enter your weight in Kg", weight);
            float height = 0;
            height = Lesson3.promptFloat("Enter your height in m", height);

            Console.WriteLine(nameSurname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m");

            Lesson3.calculateBMI(weight, height);
        }
    }
}
