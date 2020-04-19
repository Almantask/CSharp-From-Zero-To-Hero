using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // name, surname, age, weight, height input
            Console.Write("Please input first name: ");
            string name = Console.ReadLine();
            Console.Write("Please input last name: ");
            string surname = Console.ReadLine();
            Console.Write("Please input age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please input weight in kg: ");
            float weightInKg = float.Parse(Console.ReadLine());
            Console.Write("Please input height in cm: ");
            float heightInCm = float.Parse(Console.ReadLine());

            // result write line
            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weightInKg + " kg and his height is " + heightInCm + " cm.");

            //BMI (body-mass index) calculator , height needs to be in m not cm so divided by 100
            float bmi = weightInKg / (heightInCm/100 * heightInCm/100);
            
           Console.WriteLine(name + "'s body-mass index (BMI) is " + bmi);


        }
    }
}
