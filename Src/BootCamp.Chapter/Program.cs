using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 
            string Name1 = "Tom Jefferson";
            int Age1 = 19;
            int Weight1 = 50;
            float Height1 = 156.5f;
            float Height1v2 = Height1 / 100;
            float Height1v3 = Height1v2 * Height1v2;
            float Bmi1 = Weight1 / Height1v3;

            Console.WriteLine(Name1 + " is " + Age1 + " years old, his weight is " + Weight1 + " kg, his height is " + Height1 + " cm and his bmi is " + Bmi1 + ".");
        }
    }
}
