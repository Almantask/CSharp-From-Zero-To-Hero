using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            PromptPersonData();
            PromptPersonData();
        }
        private static void PromptPersonData()
        {
            string firstName = PromptString("What is your first name: ");
            string lastName = PromptString("What is your last name: ");
            int age = PromptInt("What is your age: ");
            float weight = PromptFloat("what is your weight in Kg: ");
            float height = PromptFloat("what is your height in cm: ");
            float bmi = BmiCalculator(weight, height / 100);

            Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");

            Console.WriteLine($"Your BMI is {bmi}");
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
        public static float BmiCalculator(float weight, float height)
        {
            return weight / (height * height); // BMI = kg/m2
        }
    }

}
