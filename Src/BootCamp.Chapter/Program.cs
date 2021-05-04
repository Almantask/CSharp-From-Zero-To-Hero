using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is this working? - JP");

            Console.Clear();
            showInfo();
            showInfo();
        }
        static void showInfo()
        {
            // Get user inputs
            Console.Write("Enter your name: ");
            var userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            var userAge = Console.ReadLine();
            Console.Write("Enter your weight (kg): ");
            var userWeight = Console.ReadLine();
            Console.Write("Enter your height (m): ");
            var userHeight = Console.ReadLine();
            // Convert to numbers
            int userAgeNum = int.Parse(userAge);
            double userWeightNum = double.Parse(userWeight);
            double userHeightNum = double.Parse(userHeight);
            // Calculate BMI
            double bmi = userWeightNum / Math.Pow(userHeightNum, 2);
            // Printing
            Console.WriteLine("{0} is {1} years old, is {2} kg and {3} m, {4}'s BMI is {5:0.0}.",userName,userAgeNum,userWeightNum,userHeightNum,userName,bmi);

            //edit - ML

        }
    }
}
