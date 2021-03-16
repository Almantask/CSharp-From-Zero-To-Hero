using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n hello welcom to Homework 1 and 2 of  C#: From Zero To Hero bootcamp \n");

            Console.Write("please enter your name :  ");
            string name = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("please enter your surename :  ");
            string surename = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("please enter your age : ");
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.Write("please enter your weight (in kg) :  ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.Write("please enter your height (in cm) :  ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.Write("{0} is {1} years old, his weight is {2} kg and his height is {3} cm  ." , name , age , weight , height);

            Console.WriteLine("\n");

            Console.Write("press any key to exit the program: ");
            Console.ReadKey();
        }
    }
}
