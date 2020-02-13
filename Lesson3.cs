using System;

namespace Lesson3
{
    public class Lesson3
    {
	    public Lesson3()
	    {
            static void Main(string[] args)
            {
                string name = PromptString("name");
                string surname = PromptString("surname");
                int age = PromptInt("age");
                float weight = PromptFloat("weight");
                float height = PromptFloat("height");
                float bmi = CalculateBmi(weight, height);

                Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm. His BMI is {bmi}.");
            }
            static string PromptString(string attribute)
            {
                Console.Write($"What is your {attribute}? ");
                return Console.ReadLine();
            }
            static int PromptInt(string attribute)
            {
                Console.Write($"What is your {attribute}? ");
                return Convert.ToInt32(Console.ReadLine());
            }

            static float PromptFloat(string attribute)
            {
                Console.Write($"What is your {attribute}? ");
                return Convert.ToSingle(Console.ReadLine());
            }

            static float CalculateBmi(float weight, float height)
            {
                return weight / height * height;
            }
        }
    }
}

