using System;

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
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }

            return input;
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            if(!int.TryParse(input, out int output))
            {
                Console.WriteLine("\"" + input + "\" is not a valid number.");
                return -1;
            }
            return output;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            if (!float.TryParse(input, out float output))
            {
                Console.WriteLine("\"" + input + "\" is not a valid number.");
                return -1;
            }

            return output;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if(weight <= 0 && height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }
            else if (weight >= height)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be more or equal to height.");
                Console.WriteLine(" Height= " + height + ", Weight= " + weight + ".");
                return -1;
            }

            return weight / (height * height);
        }

        public static void WeightType(float BMI)
        {
            if (BMI < 0)
            {
                Console.WriteLine("Unable to tell weight type since BMI Calculation FAILED.");
            }
            else if (BMI < 18.5)
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
