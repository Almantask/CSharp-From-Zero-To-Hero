using System;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            var name = GetInputString("Name");
            var lastname = GetInputString("Surname");
            var age = GetInputInt("Age");
            var weightInKg = GetInputFloat("Weight (in kg)");
            var heightInCm = GetInputFloat("Height (in cm)");

            var bmi = CalculateBodyMaxIndex(weightInKg, (heightInCm / 100)); //converting height cm to m

            Console.WriteLine(
                $"{name} {lastname} is {age} years old, his weight is {weightInKg} kg and his height is {heightInCm} cm.{Environment.NewLine}" +
                $"Your body mass index is {bmi:0.00}"
            );
        }

        public static string GetInputString(string question)
        {
            Console.Write(question + " ");
            var input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input)) return input;

            Console.WriteLine("Name cannot be empty");
            return "-";
        }

        public static int GetInputInt(string question)
        {
            Console.Write(question + " ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var number)) return number;

            Console.WriteLine($"\"{input}\" is not a valid number.");
            return -1;
        }

        public static float GetInputFloat(string question)
        {
            Console.Write(question + " ");
            var input = Console.ReadLine();

            if (float.TryParse(input, out var number)) return number;

            Console.WriteLine($"\"{input}\" is not a valid number.");
            return -1;
        }

        public static float CalculateBodyMaxIndex(float weightInKg, float heightInM)
        {
            if (weightInKg > 0 && heightInM > 0) return weightInKg / (heightInM * heightInM);

            Console.WriteLine($"Failed calculating BMI. Reason:");
            if (weightInKg <= 0) Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightInKg}");
            if (heightInM <= 0) Console.WriteLine($"Height cannot be equal or less than zero, but was {heightInM}");

            return -1;
        }
    }
}