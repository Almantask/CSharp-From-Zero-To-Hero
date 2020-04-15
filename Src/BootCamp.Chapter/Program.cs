using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //First person
            string firstName1 = GetInput("Enter your first name: ");
            string lastName1 = GetInput("Enter your last name: ");
            int age1 = int.Parse(GetInput("Enter your age: "));
            float height1 = float.Parse(GetInput("Enter your height (in cm): "));
            float weight1 = float.Parse(GetInput("Enter your weight (in kg): "));
            float bmi1 = weight1 / (height1 * height1 /10000);  // division to place decimal where it would be expected for a BMI measurement.

            Console.WriteLine($"{firstName1} {lastName1} is {age1} years old, weighs {weight1} kg and is {height1} cm tall."); 
            Console.WriteLine($"{firstName1}'s BMI is {bmi1}.");

            Console.ReadKey(); //Pause for patient to check details.
            Console.Clear(); //Doctor-Patient Confidentiality.

            //Second Person
            string firstName2 = GetInput("Enter your first name: ");
            string lastName2 = GetInput("Enter your last name: ");
            int age2 = int.Parse(GetInput("Enter your age: "));
            float height2 = float.Parse(GetInput("Enter your height (in cm): "));
            float weight2 = float.Parse(GetInput("Enter your weight (in kg): "));
            float bmi2 = weight2 / (height2 * height2 / 10000);

            Console.WriteLine($"{firstName2} {lastName2} is {age2} years old, weighs {weight2} kg and is {height2} cm tall.");
            Console.WriteLine($"{firstName2}'s BMI is {bmi2}.");

            Console.ReadKey(); //Pause for patient again.
        }
        static string GetInput(string prompt)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();
            return input;
        }
    }
}
