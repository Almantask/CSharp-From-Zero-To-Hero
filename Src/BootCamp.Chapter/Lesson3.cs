using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                var firstName = InputName("First name: ");

                var surName = InputName("Surname: ");

                var age = InputInteger("Age: ");

                var weightInKilograms = InputFloat("Weight in kilograms: ");

                var heightInCentimeters = InputFloat("Height in centimeters: ");

                Console.WriteLine($"{firstName} {surName} is {age} years old, his weight is {weightInKilograms} kg and his height is {heightInCentimeters} cm.");

                var bodyMassIndex = CalculateBodyMassIndex(weightInKilograms, heightInCentimeters);
                Console.WriteLine($"Their body mass index is {bodyMassIndex}");

                Console.WriteLine("Press ENTER to continue onto the next iteration...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static float CalculateBodyMassIndex(float weightInKilograms, float heightInCentimeters)
        {
            return weightInKilograms / (heightInCentimeters * heightInCentimeters);
        }

        public static string InputName(string inputMessage)
        {
            Console.Write(inputMessage);
            return Console.ReadLine();
        }

        public static int InputInteger(string inputMessage)
        {
            Console.Write(inputMessage);
            return int.Parse(Console.ReadLine());
        }

        public static float InputFloat(string inputMessage)
        {
            Console.Write(inputMessage);
            return float.Parse(Console.ReadLine());
        }
    }
}