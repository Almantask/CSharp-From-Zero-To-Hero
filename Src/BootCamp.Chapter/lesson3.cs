using System;
using BootCamp.Chap;

namespace BootCamp.Chapter
{
    internal class lesson3
    {
        public static int demo(string count)
        {
            int count = count;
            do
            {
                ProcPrsn();
            } while (iteration < count);
        }

        private static void ProcPrsn()
        {
            WriteLine("What's ya name, mate?");
            Checks.PromptString(name);
            WriteLine("What is your weight and height?");
            float weightAndHeight = AsFloat();
            WriteLine("And your age?");
            int age = ReadMyInput();

        }

        internal static int ReadMyInput()
        {
            return int.ReadFromConsole();
        }

        internal static float AsFloat()
        {
            return (float)ReadMyInput();
        }

        private void calcBMI()
        {
            WriteLine("Your BMI is:");
            WriteLine(weight / height / height);

            if (BMI > 40)
            {
                WriteLine("You really shouldn't eat that much cake!");
                WriteLine("No offense, mate.");
            }
        }
    }
}