using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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
            Console.WriteLine(message);
            var age = Console.ReadLine();

            int intOutput;
            bool isNumerical = int.TryParse(age, out intOutput);

            if(isNumerical)
            {
                var ageConverted = int.Parse(age);
                return ageConverted;
            }
            else
            {
                Console.WriteLine($"\"{age}\" is not a valid number.");
                return -1;
            }
        }


        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var name = Console.ReadLine();

            var emptyCheck = String.IsNullOrEmpty(name);

            if(emptyCheck)
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            else
            {
                return name;
            }

        }



        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var emptyCheck = String.IsNullOrWhiteSpace(input);

            if (!emptyCheck)
            {
                float fltOutput;
                bool isFlt = float.TryParse(input, out fltOutput);

                if (isFlt)
                {
                    var convertedFloat = float.Parse(input, CultureInfo.InvariantCulture);
                    return convertedFloat;
                }
                else
                {
                    Console.WriteLine($"\"{input}\" is not a valid number.");
                    return -1;
                }
                
            }
            else
            {
                return -1;
            }

 
        }



        public static float CalculateBmi(float weight, float height)
        {
            if ((weight > 0) && (height > 0))
            {
                if (weight > 0)
                {
                    if (height > 0)
                    {
                        var metersSquared = Math.Pow(height, 2);
                        var bmi = weight / metersSquared;

                        return (float)bmi;
                    }
                    else
                    {
                        Console.WriteLine($"Failed calculating BMI. Reason: Height cannot be equal or less than zero, but was {height}.");
                        return -1;
                    }

                }
                else
                {
                    Console.WriteLine($"Failed calculating BMI. Reason: Weight cannot be equal or less than zero, but was {weight}.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine($"Failed calculating BMI. Reason: Height cannot be equal or less than zero, but was {height}.");
                Console.WriteLine($"Failed calculating BMI. Reason: Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }
            
            
        }

    }
}
