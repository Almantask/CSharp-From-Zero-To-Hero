using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Tom Jefferson";
            int age1 = 19;
            int weight1 = 50;
            float height1 = 156.5f;
            float bmi1 = weight1 / height1 / height1 * 10000;
            Console.WriteLine($"My name is {name1} and I am {age1} years old, my weight is {weight1} kg, I'm {height1} meters tall and my BMI is {bmi1}");
            string name2 = "Tom Holland";
            int age2 = 21;
            int weight2 = 80;
            float height2 = 145.9f;
            float bmi2 = weight2 / height2 / height2 * 10000;
            Console.WriteLine($"My name is {name2} and I am {age2} years old, my weight is {weight2} kg, I'm {height2} meters tall and my BMI is {bmi2}");
        }
    }
}
