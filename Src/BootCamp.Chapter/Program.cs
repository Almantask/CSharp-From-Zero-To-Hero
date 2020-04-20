using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //First person
            Console.Write("Please input first name: ");
            string name1 = Console.ReadLine();
            Console.Write("Please input last name: ");
            string surname1 = Console.ReadLine();
            Console.Write("Please input age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("Please input weight in kg: ");
            float weightKg1 = float.Parse(Console.ReadLine());
            Console.Write("Please input height in cm: ");
            float heightCm1 = float.Parse(Console.ReadLine());

            //Result output
            Console.Write(name1 + " " + surname1 + " is " + age1 + " years old," );
            Console.WriteLine(" his weight is " + weightKg1 + " kg and his height is " + heightCm1 + " cm.");

            //Convert cm to m for BMI
            float heightM1 = heightCm1/100;

            //BMI (body-mass index) calculator
            float bmi1 = weightKg1 / (heightM1 * heightM1);
            Console.WriteLine(name1 + "'s body-mass index (BMI) is " + bmi1);

            //Second person
            Console.Write("Please input first name: ");
            string name2 = Console.ReadLine();
            Console.Write("Please input last name: ");
            string surname2 = Console.ReadLine();
            Console.Write("Please input age: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.Write("Please input weight in kg: ");
            float weightKg2 = float.Parse(Console.ReadLine());
            Console.Write("Please input height in cm: ");
            float heightCm2 = float.Parse(Console.ReadLine());

            //Result output
            Console.Write(name2 + " " + surname2 + " is " + age2 + " years old,");
            Console.WriteLine(" his weight is " + weightKg2 + " kg and his height is " + heightCm2 + " cm.");

            //Convert cm to m for BMI
            float heightM2 = heightCm2 / 100;

            //BMI (body-mass index) calculator
            float bmi2 = weightKg2 / (heightM2 * heightM2);
            Console.WriteLine(name2 + "'s body-mass index (BMI) is " + bmi2);




        }
    }
}
