using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, we will be collecting some information from you now. ");
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            string userSurName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int  userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your weight:");
            int userWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your height:");
            int userHeight = Convert.ToInt32(Console.ReadLine());
            //formula for BMI 
double userBMI = userWeight / ( ( userHeight / 100.0 ) * ( userHeight / 100.0 ) );
            Console.WriteLine($"{userName} {userSurName} is {userAge} years old, his weight is {userWeight}kg and his height is {userHeight} cm.");
            
            Console.WriteLine($"His BMI is {userBMI}");

            //program repeats for second person
            Console.WriteLine("Now we will do the second person:");
            Console.WriteLine("Please enter your name:");
            string userName2 = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            string userSurName2 = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int  userAge2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your weight:");
            int userWeight2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your height:");
            int userHeight2 = Convert.ToInt32(Console.ReadLine());
            //formula for BMI 
double userBMI2 = userWeight2 / ( ( userHeight2 / 100.0 ) * ( userHeight2 / 100.0 ) );
            Console.WriteLine($"{userName2} {userSurName2} is {userAge2} years old, his weight is {userWeight2}kg and his height is {userHeight2} cm.");
            Console.WriteLine($"His BMI is {userBMI2}");
            Console.ReadKey();


        }
    }
}
