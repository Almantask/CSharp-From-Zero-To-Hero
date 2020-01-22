using System;
namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int user = 0; user < 2; user++)
            {
                string name = ConsolePromptToString("Name: ");
                string surname = ConsolePromptToString("Surname: ");
                int age = ConsolePromptToInt("Age: ");
                float weight = ConsolePromptToFloat("Weight: ");
                float height = ConsolePromptToFloat("Height: ");

                float bmi = CalculateBmi(weight, height);

                Console.WriteLine($"{name} {surname} is {age} years old, his weight is" +
                    $"{weight} kg and his height is {height:N1} cm.");
                Console.WriteLine($"BMI: {bmi:N1}\n");
            }
        } 

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }

        public static int ConsolePromptToInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine()); 
        }

        public static string ConsolePromptToString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static float ConsolePromptToFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }
    }
}