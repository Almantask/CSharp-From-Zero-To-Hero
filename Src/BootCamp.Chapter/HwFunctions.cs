using System;

namespace BootCamp.Chapter
{
public class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                var surname = Lesson3.PromptString("Please enter your surname: ");
                var age = Lesson3.PromptInt("Please enter your age: ");
                var weight = Lesson3.PromptFloat("Please enter your weight (in kg): ");
                var height = Lesson3.PromptFloat("Please enter your height (in m): ");
                Console.WriteLine(surname + " is " + age + " " + "years old, his weight is " + weight + "kg and his height is " + height + "m.");

                var Bmi = Lesson3.CalculateBmi(weight, height);
                Console.WriteLine("Your estimated BMI is " + Bmi);
            }
        }
        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static int PromptInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = float.Parse(Console.ReadLine());
            return input;
        }
        public static float CalculateBmi(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }
    }
}
