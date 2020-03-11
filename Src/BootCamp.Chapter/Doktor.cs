using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Doktor
    {
        public static void DoctorAsks()
        {
            // Read name, surename, age, weight (in kg) and height (in cm) from console.
            Console.Write("Please tell me your first name: ");
            string name = Console.ReadLine();
            Console.Write("Please tell me your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please tell me your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please tell me your weight in Kg: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Please tell me your height in cm: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm .");

            float heightInMeters = height / 100;
            float bmi = weight / (heightInMeters * heightInMeters); // BMI = kg/m2
            Console.WriteLine($"Your BMI is {bmi}");
        }
    }
}
