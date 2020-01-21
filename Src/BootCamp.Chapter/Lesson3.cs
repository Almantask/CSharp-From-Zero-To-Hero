using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            PersonInfoAskerAndPrinter();
            PersonInfoAskerAndPrinter();
        }
        private static void PersonInfoAskerAndPrinter()
        {
            string firstName = NameAsker("What is your first name: ");
            string lastName = NameAsker("What is your last name: ");
            int age = AgeAsker("What is your age: ");
            float weight = WeightOrHightAsker("what is your weight in Kg: ");
            float height = WeightOrHightAsker("what is your height in cm: ");
            Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");
            float bmi = BMICalculator(weight, height / 100);
            Console.WriteLine($"Your BMI is {bmi}");
        }
        public static string NameAsker(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static int AgeAsker(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static float WeightOrHightAsker(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }
        public static float BMICalculator(float weight, float height)
        {
            return weight / (height * height); // BMI = kg/m2
        }
    }

}
