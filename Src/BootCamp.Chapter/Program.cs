using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your First Name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nWhat is your Last Name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("\nWhate is your age weight(kg) and height(cm)? (Please seperate with spaces)");
            string[] attributes = Console.ReadLine().Split(' ');

            int age = int.Parse(attributes[0]);
            float weight = float.Parse(attributes[1]);
            float height = float.Parse(attributes[2]);

            Console.WriteLine("\n" + firstName + " " + lastName + " is a " + age + " year old, their weight is " + 
                weight + " kg and their height is " + height + " cm.");


            float heightInMeters = height * .01f;
            float bmi = weight / (heightInMeters * heightInMeters);

            Console.WriteLine("Their Body-Mass Index (BMI) is " + bmi);
        }
    }
}
