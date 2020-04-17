using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name1 = "todd";

            float age = 19f; //in years
            float weight = 50f; //in kg
            float height = 1.565f; //in meters (that's the normal BMI formula, if this isn't correct then I'll change it)
            var bmi = weight / (height * height);

            Console.WriteLine(Name1 + " is " + age + "  years old, his weight is " + weight + "kg and his height is " + height + " meters");
            Console.ReadKey();
            Console.WriteLine("His BMI score is: " + bmi);
            Console.ReadKey();

            string Name2 = "Jerry";

            age = 35;
            weight = 65f;
            height = 2f;
            bmi = weight / (height * height);

            Console.WriteLine(Name2 + " is " + age + "  years old, his weight is " + weight + "kg and his height is " + height + " meters");
            Console.ReadKey();
            Console.WriteLine("His BMI score is: " + bmi);
            Console.ReadKey();

            string Name3 = "Cl0ut";

            age = 17;
            weight = 65f;
            height = 1.7f;
            bmi = weight / (height * height);

            Console.WriteLine(Name3 + " is " + age + "  years old, his weight is " + weight + "kg and his height is " + height + " meters");
            Console.ReadKey();
            Console.WriteLine("His BMI score is: " + bmi);
            Console.ReadKey();
        }
    }
}
