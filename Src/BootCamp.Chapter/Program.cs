using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is for first character
            Console.WriteLine("Hello This is for homework 1 & 2");
            Console.Write("Enter Your Name: ");
            string personName = Console.ReadLine();

            Console.Write("Enter your Surname: ");
            string personSurName = Console.ReadLine();

            Console.Write("Enter your Age: ");
            int personAge = int.Parse(Console.ReadLine());

            Console.Write("Enter your height: ");
            float personHeight = float.Parse(Console.ReadLine());

            Console.Write("Enter your weight: ");
            float personWeight = float.Parse(Console.ReadLine());

            Console.Write(personName + " " + personSurName + " is ");
            Console.Write(personAge + " years old, ");
            Console.Write("his weight is " + personWeight + " kg ");
            Console.Write("his hieght is " + (float)personHeight + " cm. ");

            personHeight = personHeight / 100;
            float personBMI = personWeight / (float)(Math.Pow(personHeight, 2));
            Console.WriteLine(personName + " " + personSurName + "'s BMI is " + personBMI);


            // This is for second Character
            Console.Write("Enter Your Name: ");
            personName = Console.ReadLine();

            Console.Write("Enter your Surname: ");
            personSurName = Console.ReadLine();

            Console.Write("Enter your Age: ");
            personAge = int.Parse(Console.ReadLine());

            Console.Write("Enter your height: ");
            personHeight = float.Parse(Console.ReadLine());

            Console.Write("Enter your weight: ");
            personWeight = float.Parse(Console.ReadLine());

            Console.Write(personName + " " + personSurName + " is ");
            Console.Write(personAge + " years old, ");
            Console.Write("his weight is " + personWeight + " kg ");
            Console.Write("his hieght is " + (float)personHeight + " cm. ");

            personHeight = personHeight / 100;
            personBMI = personWeight / (float)(Math.Pow(personHeight, 2));
            Console.WriteLine(personName + " " + personSurName + "'s BMI is " + personBMI);
        }
    }
}
