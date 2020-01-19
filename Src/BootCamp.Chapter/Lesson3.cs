using Console = System.Console;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Descriptor();
            Descriptor();
        }

        public static void Descriptor()
        {
            //ask user for their name, age, weight, and height
            string name = PromptString("Name: ");
            string surname = PromptString("Surname: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight: ");
            float cmHeight = PromptFloat("Height(cm): ");

            //print a sentence about user
            Console.WriteLine($"{name} {surname} is {age} years old, their weight is {weight}Kg and their height is {cmHeight}cm");

            //calculate and print the BMI of the user
            float mHeight = cmHeight / 100;
            float bmi = CalculateBmi(weight, mHeight);
            Console.WriteLine($"They have a BMI of {bmi}");
        }

        public static int PromptInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        public static string PromptString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static float PromptFloat(string prompt)
        {
            Console.Write(prompt);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
