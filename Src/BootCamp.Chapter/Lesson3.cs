using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Person 1:");

            //get input from user about name, age, height, weight, and calculate bmi
            string firstName = Program.GetString("Enter your First Name: ");

            string lastName = Program.GetString("Enter your Last Name: ");

            int age = Program.GetInt("Enter your Age: ");

            float weight = Program.GetFloat("Enter your Weight(kg): ");

            float height = Program.GetFloat("Enter your Height(cm): ");

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old,\n" +
                "his weight is " + weight + " kg and his\n" +
                "height is " + height + " cm.");

            float bmi = Program.CalculateBmi(weight, height);

            Console.WriteLine("BMI: " + bmi + " \n");

            //do the same for another person
            Console.WriteLine("Person 2:");

            firstName = Program.GetString("Enter your First Name: ");

            lastName = Program.GetString("Enter your Last Name: ");

            age = Program.GetInt("Enter your Age: ");

            weight = Program.GetFloat("Enter your Weight(kg): ");

            height = Program.GetFloat("Enter your Height(cm): ");

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old,\n" +
                "his weight is " + weight + " kg and his\n" +
                "height is " + height + " cm.");

            bmi = Program.CalculateBmi(weight, height);

            Console.WriteLine("BMI: " + bmi + " \n");

            Console.ReadLine();
        }
    }
}
