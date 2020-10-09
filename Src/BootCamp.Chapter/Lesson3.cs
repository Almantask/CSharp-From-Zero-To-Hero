using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 3; i++)
            {
                int personCounter = i + 1;
                var name = Checks.PromptString("Enter first name for person " + personCounter + ": ");
                var surname = Checks.PromptString("Enter last name for person " + personCounter + ": ");
                var age = Checks.PromptInt("Enter age for person " + personCounter + ": ");
                var weight = Checks.PromptFloat("Enter weight for person " + personCounter + ": ");
                var height = Checks.PromptFloat("Enter height for person " + personCounter + ": ");

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm");

                var heightConverted = height / 100; // height in meters
                Console.WriteLine("BMI: " + Checks.CalculateBmi(weight, heightConverted) + Environment.NewLine);
               
            }
        }
    }


}
