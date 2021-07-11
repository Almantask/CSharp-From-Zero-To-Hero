using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public static int PromptInt()
        {
            Console.WriteLine("Please enter your age:");
            var age = Console.ReadLine();
            var ageConverted = int.Parse(age);


            return ageConverted;
        }


        public static string PromptString()
        {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();

            return name;
        }



        public static float PromptFloat(string message)
        {
        var input = message;
        var convertedFloat = float.Parse(input);

        return convertedFloat;
        }



        public static float CalculateBmi(float weight, float height)
        {
            var inMeters = height * 100;
            var metersSquared = Math.Pow(inMeters, 2);
            var BMI = weight / metersSquared;

            return (float)BMI;
        }

    }
}
