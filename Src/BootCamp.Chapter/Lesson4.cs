using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            bool calculateAgain = true;

            while (calculateAgain)
            {
                Console.WriteLine("BMI Calculator");

                string name = PromptString("Enter your name: ");
                int age = PromptInt("Enter your age: ");
                float weight = PromptFloat("Enter your weight(kg): ");
                float height = PromptFloat("Enter your height(cm): ");

                Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

                float BMI = CalculateBmi(weight, height / 100);

                Console.WriteLine("Your BMI is " + BMI);

                WeightType(BMI);

                calculateAgain = ResponseValidation();
            }

            Console.WriteLine("Exiting...");

        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }

        public static void WeightType(float BMI)
        {
            if (BMI < 18.5)
            {
                Console.WriteLine("You are Underweight.");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("You have a Normal Weight.");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("You are Overweight.");
            }
            else if (BMI >= 30)
            {
                Console.WriteLine("You are Obese.");
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
        }

        public static bool ResponseValidation()
        {
            Console.WriteLine("Do you want to calculate another persoon's BMI? (y/n)");
            string continueTheFight = Console.ReadLine();
            while (continueTheFight != "y" && continueTheFight != "n")
            {
                Console.WriteLine("That is not a valid response.");
                Console.WriteLine("Do you want to calculate another persoon's BMI? (y/n)");
                continueTheFight = Console.ReadLine();
            }

            if (continueTheFight == "n")
            {
                return false;
            }

            return true;
        }
    }
}
