using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            bool calculateAgain = true;

            while (calculateAgain)
            {
                Console.WriteLine("BMI Calculator");

                string name = GetString("Enter your name: ");
                int age = GetInt("Enter your age: ");
                float weight = GetFloat("Enter your weight(kg): ");
                float height = GetFloat("Enter your height(cm): ");

                Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

                float BMI = CalculateBMI(weight, height / 100);

                Console.WriteLine("Your BMI is " + BMI);

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
                    calculateAgain = false;
                }

            }

            Console.WriteLine("Exiting...");
                        
        }
                
        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int GetInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static float GetFloat(string message)
        {
            Console.Write(message);
            return Convert.ToSingle(Console.ReadLine());
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (Convert.ToSingle(Math.Pow(height, 2)));
        }

    }
}
