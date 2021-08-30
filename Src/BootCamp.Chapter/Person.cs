using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Person
    {
        private string userName = default;
        private int userAge = default;
        private float userWeight = default;
        private float userHeight = default;
        private double userBMI = default;
        private readonly int magicNumer = 10000;


        public void StartProgram()
        {
            PromptUser("Name");
            PromptUser("Age");
            PromptUser("Weight");
            PromptUser("Height");
            CalculateBMI();
            PrintDetails();
        }
        void PromptUser(string message)
        {
            Console.WriteLine();
            Console.Write($"Please enter your {message}: ");
            DetermineInput(message);
        }

        void DetermineInput(string message)
        {
            switch (message)
            {
                case "Age":
                    userAge = int.Parse(Console.ReadLine());
                    break;
                case "Name":
                    userName = Console.ReadLine();
                    break;
                case "Height":
                    userHeight = float.Parse(Console.ReadLine());
                    break;
                case "Weight":
                    userWeight = float.Parse(Console.ReadLine());
                    break;
            }
        }

        void CalculateBMI()
        {
            userBMI = (userWeight / userHeight / userHeight) * magicNumer;
        }

        void PrintDetails()
        {
            Console.WriteLine();
            Console.WriteLine($"{userName} is {userAge} years old, his weight is {userWeight} kg and his height is {userHeight} cm.");
        }
    }
}
