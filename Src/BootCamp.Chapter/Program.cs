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

            //input first name, last name
            string firstName = checkStringInput("Input First Name: ");
            string lastName = checkStringInput("Input Last Name: ");

            // input age
            Console.Write("Input age: ");
            string s = Console.ReadLine();
            int.TryParse(s, out int age);

            // input weight and height
            Console.Write("Input weight (in kg): ");
            s = Console.ReadLine();
            float.TryParse(s, out float weight);

            Console.Write("Input height (in cm): ");
            s = Console.ReadLine();
            float.TryParse(s, out float height);
            
            //print info
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            //calculate and print bmi
            float bmi = weight / ((height / 100) * (height / 100));
            Console.WriteLine(firstName + " " + lastName + " has a BMI of " + bmi + ".");
            }
        }

        public static string checkStringInput(string checkString)
        {
            Console.WriteLine(checkString);
            string returnString = Console.ReadLine();
            return returnString;
        }

    }
}