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
        public static int PromptInt(string message)
        {
            // To do: call your implementation.
            Console.Write(message);
            var age = Console.ReadLine();
            if(!int.TryParse(age, out int a)){
                Console.WriteLine($"\"{age}\" is not a valid number.");
                return -1;   
            }
            return int.Parse(age);
        }

        public static string PromptString(string message)
        {
            // To do: call your implementation. 
            Console.Write(message);
            var name = Console.ReadLine();
            if(string.IsNullOrEmpty(name)){
                Console.WriteLine("Name cannot be empty.");
                return "-";
            };
            return name;
        }

        public static float PromptFloat(string message)
        {
            // To do: call your implementation.
            Console.Write(message); 
            var input = Console.ReadLine();
            if(!float.TryParse(input, out float a)) {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            return float.Parse(input);
        }

        public static float CalculateBmi(float weight, float height)
        {
            // To do: call your implementation. 
            if(weight <= 0 && height <= 0){
                Console.WriteLine("Failed calculating BMI. Reason:\n" + "{\"" + $"Weight cannot be equal or less than zero, but was {weight}\""+ "}" + "\n" + "{\"" + $"Height cannot be equal or less than zero, but was {height}\""+ "}");
                return -1;
            }
            else if(weight <= 0){
                Console.WriteLine($"Failed calculating BMI. Reason:\n\"Weight cannot be equal or less than zero, but was {weight}\"");
                return -1;
            }
            else if(height <= 0){
                Console.WriteLine($"Failed calculating BMI. Reason:\n\"Height cannot be equal or less than zero, but was {height}\"");
                return -1;
            }
            return weight/height/height;
        }
    }
}
