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
            // Variables
            string nameSurname = " ";
            int age = 0;
            float weight = 0;
            float height = 0;

            // Return Functions
            nameSurname = Lesson3.printStr("Enter your name", nameSurname);
            age = Lesson3.printInt("Enter your age", age);
            weight = Lesson3.printFloat("Enter your weight in Kg", weight);
            height = Lesson3.printFloat("Enter your height in m", height);

            Console.WriteLine(nameSurname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m");

            // BMI Function
            Lesson3.printBMI(weight, height);
        }
    }
}
