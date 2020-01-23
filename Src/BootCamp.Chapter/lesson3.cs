// This file is for hunting bugs only.
// Completing homework 3 before looking at this is HIGHLY recommended.
// Try to look at the code in GitHub first. Try to find the mistakes that
// were made without help or tools first.
// After that try to find every single thing that seems off.
// Have fun! :)
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

        private static void PrcPrsn()
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

        private static float AsFloat()
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