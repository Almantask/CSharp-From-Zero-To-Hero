using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the self-confidence crusher! Also known as the BMI Calculator. Please input your information below.");
            Console.WriteLine();

            // First Person Start.
            Console.WriteLine("Hello person one, please enter your details below.");

            ProcessPerson();

            Console.WriteLine();

            // Second Person Start
            Console.WriteLine("Hello person two, let's compare you with person one.");

            ProcessPerson();


            // End.
            Console.WriteLine("\n");

            Console.WriteLine("Judging by our calculations, we have come to the conclusion that both users are not within the healthy range " +
                              "\nof the self-confidence crusher BMI Calculator.");

            Console.WriteLine("\nHave a nice day!");
            Console.ReadLine();
        }


        public static void ProcessPerson()
        {
            string firstName = PromptString("Please enter your first name: ");
            string lastName = PromptString("Please enter your last name: ");

            
            int age = PromptInt("Enter your Age: ");

            float weight = PromptFloat("Please enter your weight in KG: ");
            float height = PromptFloat("Please enter your weight in Meters: ");

            float bmi = CalculateBmi(weight, height);


            Console.Write(firstName + " " + lastName + " is " + age + " years old and has a BMI of: " + bmi + "\n");
        }


        public static string PromptString(string message)
        {
            Console.Write(message);

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be Empty");
                return "-";
            }
            else
            {
                return input;
            }
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);

            string input = Console.ReadLine();

            bool isNumber = int.TryParse(input, out int age);

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (!isNumber)
            {
                Console.WriteLine(input + " is not a valid number.");
                return -1;
            }
            if (age > 130 && age < 0)
            {
                Console.WriteLine(input + " is not a valid number.");
                return -1;
            }
            else
                return age;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);

            string input = Console.ReadLine();

            bool isFloat = float.TryParse(input, out float measurement);

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (!isFloat)
            {
                Console.WriteLine(input + " is not a valid number.");
                return -1;
            }
            else
                return measurement;
        }

        public static float CalculateBmi(float weight, float height)
        {

            if (weight <= 0 && height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" +
                                  "\nWeight cannot be equal to or less than zero, but was " + weight);

                Console.WriteLine("Failed calculating BMI. Reason:" +
                                  "\nHeight cannot be equal to or less than zero, but was " + height);
            }
            if (height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + 
                                  "\nHeight cannot be equal to or less than zero, but was " + height);
            }
            if (weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + 
                                  "\nWeight cannot be equal to or less than zero, but was " + weight);
            }
            
            return weight / height / height;
        }
    }
}
