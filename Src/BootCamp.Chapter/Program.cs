using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {   /*
                This is the code for Homework 1 and 2 
                This section I have written the variables for Tom Jefferson

            */
            Console.WriteLine("This is for Homework 1");
            int tomAge = 19;
            float tomWeight = 50.0f;
            string tomName = "Tom Jefferson";
            float tomHeight = 156.5f;
            const int cmToM = 10000;
            float tomBMI = tomWeight / ((tomHeight * tomHeight) / cmToM);

            // This is where Tom's Info is displayed
            Console.Write(tomName + " is " + tomAge + " years old, ");
            Console.Write("his weight is " + (int)tomWeight);
            Console.WriteLine(" kg and his height is " + tomHeight + " cm.");
            Console.WriteLine(tomName + "'s BMI is: " + tomBMI);

            //This is where a user's info is being entered
            Console.Write("Please enter the name of the user: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter the age of " + userName + ": ");
            int userAge = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the weight of " + userName + ": ");
            float userWeight = Single.Parse(Console.ReadLine());
            Console.Write("Please enter the height of " + userName + ": ");
            float userHeight = Single.Parse(Console.ReadLine());
            float userBMI = userWeight / ((userHeight * userHeight) / cmToM);

            //This is where User's Info is displayed
            Console.Write(userName + " is " + userAge + " years old, ");
            Console.Write("his weight is " + (int)userWeight);
            Console.WriteLine(" kg and his height is " + userHeight + " cm.");
            Console.WriteLine(userName + "'s BMI is: " + userBMI);
        }
    }
}
