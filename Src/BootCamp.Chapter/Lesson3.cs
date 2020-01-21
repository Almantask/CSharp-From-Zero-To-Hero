using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            const int NumOfPerson = 2;

            for (var num = 0; num < NumOfPerson; num++)
            {
                Console.WriteLine("Calculate BMI for a person.");

                var name = PromptString("Enter name: ");
                var surname = PromptString("Enter surname: ");
                var age = PromptInt("Enter age: ");
                var weightKg = PromptFloat("Enter weight (kg): ");
                var heightCm = PromptFloat("Enter height (cm): ");

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weightKg + " kg and his height is " + heightCm + " cm.");
                Console.WriteLine("Body-mass index (BMI) is " + CalculateBmi(weightKg, heightCm / 100) + ".");
            }
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return (Console.ReadLine());
        }

        public static int PromptInt(string message)
        {
            return (Convert.ToInt32(PromptString(message)));
        }

        public static float PromptFloat(string message)
        {
            return (Convert.ToSingle(PromptString(message)));
        }

        public static float CalculateBmi(float weightKg, float heightM)
        {
            //BMI is weight (kg) / [height (m)] ^ 2
            return ((float)(weightKg / Math.Pow(heightM, 2)));
        }
    }
}
