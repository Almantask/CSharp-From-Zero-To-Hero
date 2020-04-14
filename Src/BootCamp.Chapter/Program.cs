using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person1
            Console.WriteLine("Person #1:");
            
            //Name
            Console.Write("Name: ");
            string name1 = Console.ReadLine();

            //Age
            Console.Write("Age: ");
            int age1 =Convert.ToInt32( Console.ReadLine());

            //Weight
            Console.Write("Weight (kg): ");
            float weight1 =Convert.ToInt32( Console.ReadLine());

            //Height
            Console.Write("Height (cm): ");
            float height1 = Convert.ToInt32(Console.ReadLine());

            //Bmi
            float bmi1 = weight1 / (height1 * height1) * 10000;

            Console.WriteLine(name1 +" is " + age1+" years old, his weight is " + weight1 + " kg, his height is "+height1+ " and his bmi is " +bmi1+".");

            //------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(" ");

            //Person2
            Console.WriteLine("Person #2:");

            //Name
            Console.Write("Name: ");
            string name2 = Console.ReadLine();

            //Age
            Console.Write("Age: ");
            int age2 = Convert.ToInt32(Console.ReadLine());

            //Weight
            Console.Write("Weight (kg): ");
            float weight2 = Convert.ToInt32(Console.ReadLine());

            //Height
            Console.Write("Height (cm): ");
            float height2 = Convert.ToInt32(Console.ReadLine());

            //Bmi
            float bmi2 = weight2 / (height2 * height2) * 10000;

            Console.WriteLine(name2 + " is " + age2 + " years old, his weight is " + weight2 + " kg, his height is " + height2 + " and his bmi is " + bmi2 + ".");

        }
    }
}
