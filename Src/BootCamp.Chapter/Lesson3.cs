using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter person " + (i + 1) + " first name:");
                string fName = Console.ReadLine();

                Console.WriteLine("Enter " + fName + "'s last name:");
                string lName = Console.ReadLine();

                Console.WriteLine("Enter " + fName + " " + lName + "'s age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter " + fName + " " + lName + "'s weight in kg:");
                float weight = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter " + fName + " " + lName + "'s height in cm:");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine(fName + " " + lName + "is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");

                float bmi = weight / ((height / 100) * (height / 100));

                Console.WriteLine(fName + " " + lName + "'s BMI is " + bmi);
            }
    }
}
