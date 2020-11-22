using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework for Chapter 1 goes here
            /*
            Read name, surename, age, weight (in kg) and height (in cm) from console.
            DO NOT HARDCODE
            Print all the info based on the example message below:
            Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.
            
            Calculate and print body-mass index (BMI)
            Do it for 2 people (repeat the same thing twice)

            */

            string user1Name;
            string user2Name;
            string user1Surname;
            string user2Surname;
            string user1Age;
            string user2Age;
            string user1WeightKG;
            string user2WeightKG;
            string user1HeightCM;
            string user2HeightCM;

            Console.WriteLine("What is your name?");
            user1Name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            user1Surname = Console.ReadLine();
            Console.WriteLine("What is your age?");
            user1Age = Console.ReadLine();
            Console.WriteLine("What is your weight in kg?");
            user1WeightKG = Console.ReadLine();
            Console.WriteLine("What is your height in cm?");
            user1HeightCM = Console.ReadLine();

            Console.WriteLine(user1Name +" "+ user1Surname +" is "+user1Age+" years old, his weight is "+user1WeightKG+
                " kg and his height is "+user1HeightCM+" cm.");

            Console.WriteLine("Please enter details for another person what is your name?");
            user2Name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            user2Surname = Console.ReadLine();
            Console.WriteLine("What is your age?");
            user2Age = Console.ReadLine();
            Console.WriteLine("What is your weight in kg?");
            user2WeightKG = Console.ReadLine();
            Console.WriteLine("What is your height in cm?");
            user2HeightCM = Console.ReadLine();

            Console.WriteLine(user2Name + " " + user2Surname + " is " + user2Age + " years old, his weight is " + user2WeightKG +
    " kg and his height is " + user2HeightCM + " cm.");
        }
    }
}
