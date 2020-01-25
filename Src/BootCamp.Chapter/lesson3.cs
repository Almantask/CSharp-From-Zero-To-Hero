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
    internal class lesson3   // class name must begin with a capital character. 
    {
        public static int demo(string count)  // name must begin with a capital character.
        {
            int count = count;  // on initialisation a variable can never point to itself. because at that point it null and it makes no sense 
            do
            {
                ProcPrsn(); // Name is wrong. so the compiler cannot find it. 
                // count is never updated so this will be a endless loop. 
            } while (iteration < count);   // Iteration is never initialized so it does not exist. 
        }

        private static void PrcPrsn()
        {
            WriteLine("What's ya name, mate?");  // A Console is mising so the compiler thinks its a function in Class3 
            Checks.PromptString(name);   // name is is never initialized so it does not exist
            WriteLine("What is your weight and height?"); // A Console. is mising so the compiler thinks its a function in Class3
            float weightAndHeight = AsFloat();
            WriteLine("And your age?");  // A Console. is mising so the compiler thinks its a function in Class3
            int age = ReadMyInput();

        }

        internal static int ReadMyInput()
        {
            return int.ReadFromConsole();  // Int does not have a possibility to read things from console. So I think it should be Console. or Clas3 but then the function need to be written.
        }

        private static float AsFloat()
        {
            return (float)ReadMyInput();
        }

        private void calcBMI()
        {
            WriteLine("Your BMI is:"); // A Console. is mising so the compiler thinks its a function in Class3
            WriteLine(weight / height / height); // A Console. is mising so the compiler thinks its a function in Class3 and I thing the formula is wrong. that should be (weight / (height * height) 
                                                 // and weight and height are never initialized so they does not exist
            if (BMI > 40) // BMI is never initialized or calculated so it does not exist
            {
                WriteLine("You really shouldn't eat that much cake!");  // A Console. is mising so the compiler thinks its a function in Class3
                WriteLine("No offense, mate.");  // A Console. is mising so the compiler thinks its a function in Class3
            }
        }
    }
}