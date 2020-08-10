using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            static void bmiCalculator()
            {                
                string firstName = Checks.PromptString("What is your first name?");

                string lastName = Checks.PromptString("What is your last name?");

                var age = Checks.PromptInt("What is your age?");

                float weight = Checks.PromptFloat("What is your weight in kg");

                float height = Checks.PromptFloat("What is your height in m");

                float bmi = Checks.CalculateBmi(weight, height);

                Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m.");

                Console.WriteLine("BMI = " + bmi);
            }

            bmiCalculator();

            Console.WriteLine("Do you want to continue? Y/N");
            var answer = Console.ReadLine();
            if (answer == "Y")
            {
                bmiCalculator();
            }
            else
            {
                Console.WriteLine("The End");
            }
        }
    }
}
