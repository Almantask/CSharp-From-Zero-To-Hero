using System;

namespace BootCamp.Chapter
{
    class Program
    {
        public static void Main()
            {
            //run twice
            for (int i = 0; i < 2; i++)
            {
            string firstName = getStringOutput("Input First Name: ");
            string lastName = getStringOutput("Input Last Name: ");
            int age = getIntOutput("Input age: ");
            float weight = getFloatOutput("Input weight (in kg): ");
            float height = getFloatOutput("Input height (in cm): ");
            
            //print info
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            //calculate and print bmi
            float bmi = calculateBMI(weight, height);
            Console.WriteLine(firstName + " " + lastName + " has a BMI of " + bmi + ".");
            }
        }

        public static string getStringOutput(string checkString)
        {
            Console.Write(checkString);
            string returnString = Console.ReadLine();
            return returnString;
        }

        public static int getIntOutput(string checkString)
        {
            Console.Write(checkString);
            int returnInt = int.Parse(Console.ReadLine());
            return returnInt;
        }
        public static float getFloatOutput(string checkString)
        {
            Console.Write(checkString);
            float returnFloat = float.Parse(Console.ReadLine());
            return returnFloat;
        }

        public static float calculateBMI(float weight, float height)
        {
            return weight / ((height / 100) * (height / 100));
        }
    }
}