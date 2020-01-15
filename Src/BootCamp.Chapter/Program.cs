using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            int age;
            double weight;
            double height;

            double BMI;

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name: ");
                name = Convert.ToString(Console.ReadLine());

                Console.Write("Surname: ");
                surname = Convert.ToString(Console.ReadLine());

                Console.Write("Age: ");
                age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Weight: ");
                weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Height: ");
                height = Convert.ToDouble(Console.ReadLine());

                var greeting = name + " " + surname + " is " + age +
                " years old, their weight is " + weight + " KG and their height is " + height + "cm.";


                Console.WriteLine(greeting);

                BMI = weight * 10000 / (height * height);

                Console.WriteLine("BMI: " + BMI);
            }
    }
}
