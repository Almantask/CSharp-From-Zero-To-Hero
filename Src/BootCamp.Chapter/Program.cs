using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string[] attributes;

            int age;
            float weight;
            float height;

            float bmi;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("What is your First Name?");
                firstName = Console.ReadLine();

                Console.WriteLine("\nWhat is your Last Name?");
                lastName = Console.ReadLine();

                Console.WriteLine("\nWhate is your age weight(kg) and height(cm)? (Please seperate with spaces)");
                attributes = Console.ReadLine().Split(' ');

                age = int.Parse(attributes[0]);
                weight = float.Parse(attributes[1]);
                height = float.Parse(attributes[2]);

                Console.WriteLine("\n" + firstName + " " + lastName + " is a " + age + " year old, their weight is " +
                    weight + " kg and their height is " + height + " cm.");


                float heightInMeters = height * .01f;
                bmi = weight / (heightInMeters * heightInMeters);

                Console.WriteLine("Their Body-Mass Index (BMI) is " + bmi + "\n");
            }
        }
    }
}
