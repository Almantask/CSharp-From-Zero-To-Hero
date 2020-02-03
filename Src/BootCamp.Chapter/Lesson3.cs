using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        private static void CheckAndResetWindowSize() // my consol is bugged, that is the only reason why this stuff exist.
        {
            if ((Console.WindowHeight != 300) || (Console.WindowWidth != 500))
            {
                Console.SetWindowSize(120, 40);
            }
        }
        public static void Demo()
        {
            CheckAndResetWindowSize();
            WriteOutInfo();
            WriteOutInfo();
        }
        static void WriteOutInfo()
        {
            string name = PromptString("Please give me your full name");
            int age = PromptInt("Please give me your age");
            float weight = PromptFloat("Please give me your weight in kg");
            float height = PromptFloat("please give me your height in cm");
            float BMI = Math.Round(weight / Math.Pow(height/100,2),2);
            Console.WriteLine($"{name} is {age} old, their weight is {weight}kg and their height is {height}cm\n Their BMI index is {BMI}");//their is used instead of his/her.

        }
        static float PromptFloat(string message)
        {
            WriteLine(message);
            return float.Parse(Console.ReadLine());
        }
        static float PromptInt(string message)
        {
            WriteLine(message);
            return float.Parse(Console.ReadLine());
        }
        static string PromptString(string message)
        {
            WriteLine(message);
            return (Console.ReadLine());
        }
        static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
