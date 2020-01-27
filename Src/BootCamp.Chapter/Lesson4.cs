
using System;

namespace BootCamp.Chapter
{
    public class Lesson4
    {
        public static void Demo()
        {
            //run twice
            for (int i = 0; i < 2; i++)
            {
                string firstName = PromptString("Input First Name: ");
                string lastName = PromptString("Input Last Name: ");
                int age = PromptInt("Input age: ");
                float weight = PromptFloat("Input weight (in kg): ");
                float height = PromptFloat("Input height (in m): ");

                //print info
                Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m.");

                //calculate and print bmi
                float bmi = CalculateBodyMassIndex(weight, height);
                Console.WriteLine(firstName + " " + lastName + " has a BMI of " + bmi + ".");
            }
        }

        public static string PromptString(string checkString)
        {
            Console.Write(checkString);
            string returnString = Console.ReadLine();
            return returnString;
        }

        public static int PromptInt(string checkString)
        {
            Console.Write(checkString);
            int returnInt = int.Parse(Console.ReadLine());
            return returnInt;
        }
        public static float PromptFloat(string checkString)
        {
            Console.Write(checkString);
            float returnFloat = float.Parse(Console.ReadLine());
            return returnFloat;
        }

        public static float CalculateBodyMassIndex(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}