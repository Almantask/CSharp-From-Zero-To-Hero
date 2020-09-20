using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Lesson3.Demo();
            Lesson3.StringRequests("Enter your first and last name:  ");

            Lesson3.ageRequests("Enter your age: ");
            Lesson3.BMiRequests("Enter weight and height: ");

            /* //------- Lesson 1 Homework -------//

             //-----Task 1-----//

             //User prompts has to be created first
             Console.WriteLine("Enter your first name: ");

             //Then the line being read needs to be assigned to string
             string Firstname = Console.ReadLine();

             Console.WriteLine("Enter your last name: ");
             string Lastname = Console.ReadLine();

             Console.WriteLine("Enter your age: ");
             string age = Console.ReadLine();

             Console.WriteLine("Enter your weight: ");
             string weight = Console.ReadLine();

             Console.WriteLine("Enter your height: ");
             string height = Console.ReadLine();

             // The string need to be concatanated for a final message
             Console.WriteLine(Firstname + " " + Lastname + " is" + " " + age + " years old, " + "their weight is " + weight + " and their height is " + height);

             //-----Task 2-----//

             /*BMI needs to be calculated from what the user has inputted
              * The formula of BMI= weight divided by height squared
              * The weight and height need to be converted to double

             var weightBmi = float.Parse(weight);
             var heightBmi = float.Parse(height) / 100;

             //height is squared
             var heightsquared = heightBmi * heightBmi;

             //Now BMI is calculated
             var Bmi = weightBmi / heightsquared;

             //Final message is shown;

             Console.WriteLine(Firstname + " , your BMI value is " + Bmi);

             //------- Task 3 -------//

             Console.WriteLine("----User2----");
             Console.WriteLine("Please enter your firstname: ");
             string User2name = Console.ReadLine();

             Console.WriteLine("Please enter your lastname: ");
             string User2surname = Console.ReadLine();

             Console.WriteLine("Please enter your age: ");
             string User2age = Console.ReadLine();

             Console.WriteLine("Please enter your weight: ");
             string User2weight = Console.ReadLine();

             Console.WriteLine("Please enter your height: ");
             string User2height = Console.ReadLine();

             Console.WriteLine(User2name + " " + User2surname + " is" + " " + User2age + " years old, " + "their weight is " + User2weight + " and their height is " + User2height);

             var weightbmi_2 = float.Parse(User2weight);
             var heightBmi_2 = float.Parse(User2height) / 100;

             var heightsquared_2 = heightBmi_2 * heightBmi_2;
             var Bmi_2 = weightbmi_2 / heightsquared_2;

             Console.WriteLine(User2name + " , your BMI value is " + Bmi_2);*/
        }
    }
}