using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person 1:");

            //get input from user about name, age, height, weight, and calculate bmi
            Console.Write("Enter your First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            string lastName = Console.ReadLine();
            
            Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Weight(kg): ");
            float weight = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Height(cm): ");
            float height = (float)Convert.ToDouble(Console.ReadLine());            

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old,\n" +
                "his weight is " + weight + " kg and his\n" +
                "height is " + height + " cm.");

            float bmi = weight / (height*height);

            Console.WriteLine("BMI: " + bmi + " \n");

            //do the same for another person
            Console.WriteLine("Person 2:");

            Console.Write("Enter your First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Weight(kg): ");
            weight = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Height(cm): ");
            height = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old,\n" +
                "his weight is " + weight + " kg and his\n" +
                "height is " + height + " cm.");

            bmi = weight / (height * height);

            Console.WriteLine("BMI: " + bmi + " ");

            Console.ReadLine();

        }
    }
}
