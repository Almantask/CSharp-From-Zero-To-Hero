using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadPersonDetailsAndCalculateBMI();
            ReadPersonDetailsAndCalculateBMI();


        }

        static void ReadPersonDetailsAndCalculateBMI()
        {
            string firstName=Lesson3.PromptString("Enter the First name:");
            string surName=Lesson3.PromptString("Enter the Surname:");
            int age=Lesson3.PromptInt("Enter the age:");
            float weight=Lesson3.PromptFloat("Enter the weight(kg):");
            float height=Lesson3.PromptFloat("Enter the height(cm):");
            float heightInMeters=height/100;
            float bmi=Lesson3.CalculateBmi(weight, heightInMeters);
            Console.WriteLine($"\n{firstName} {surName} is {age} years old, his weight is {weight} kg and his height is {height} cm ");
            Console.WriteLine($"His BMI is {bmi}");
        }
         
    }
}
