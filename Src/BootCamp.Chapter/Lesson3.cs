using System;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void RunLesson()
        {
            string name;
            int age;
            float personHeight,
                  personWeight,
                  bmi;

            for (int i = 0; i < 3; i++)
            {
                name = GetString("What is your name?: ");
                age = GetInteger("What is your age?: ");
                personHeight = GetFloat("What is your height?: ");
                personWeight = GetFloat("What is your weight?: ");

                bmi = GetBmi(personHeight, personWeight);

                Console.WriteLine($"{name} is {age} years old with a height of {personHeight} Meters and a weight of {personWeight} Killograms. This persons BMI is: {bmi}\n");
            }
        }

        public static float GetBmi(float height, float weight)
        {
            return height / (float)Math.Pow(weight, 2);
        }

        public static string GetString(string message)
        {
            Console.Write($"{message}: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static int GetInteger(string message)
        {
            Console.Write($"{message}: ");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }

        public static float GetFloat(string message)
        {
            Console.Write($"{message}: ");
            float userInput = float.Parse(Console.ReadLine());
            return userInput;
        }
    }
}
