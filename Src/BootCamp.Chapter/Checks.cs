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
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static int Age { get; set; }
        public static int Weight { get; set; }
        public static float Height { get; set; }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                //Console.WriteLine("Age Should be a Number");
            }
            else
            {
                Age = age;
            }

            
            if (!int.TryParse(Console.ReadLine(), out int weight))
            {
                //Console.WriteLine("Weight must be a Number");
            }
            else
            {
                Weight = weight;
            }

            return Age;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            
            Name = Console.ReadLine();
            
            Surname = Console.ReadLine();

            return Name;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            
            if (!float.TryParse(Console.ReadLine(), out float height))
            {
                Console.WriteLine("Height Must be a Number");
            }
            else
            {
                Height = height;
            }
            return Height;
        }

        public static float CalculateBmi(float weight, float height)
        {
            // To do: call your implementation. 
            return weight/height/height;
        }
    }
}
