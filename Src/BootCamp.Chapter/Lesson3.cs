using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Person 1:");
            GetPersonData();
            Console.WriteLine("Person 2:");
            GetPersonData();

        }
        public static void GetPersonData()
        {
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
        }
    }
}
