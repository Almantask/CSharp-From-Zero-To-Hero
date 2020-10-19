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
            int personInfoInt = int.Parse(Console.ReadLine());
            return personInfoInt;
        }

        public static string PromptString(string message)
        {
            // To do: call your implementation. 
            Console.Write(message);
            string personInforString = Console.ReadLine();
            return personInforString;
        }

        public static float PromptFloat(string message)
        {
            // To do: call your implementation. 
            Console.Write(message);
            float personInfoFloat = float.Parse(Console.ReadLine());
            return personInfoFloat;     
        }

        public static float CalculateBmi(float weight, float height)
        {
            // To do: call your implementation. 
            float heightINmeter = (height / 100f);
            float calculatePersonBMI = weight / ((float)(Math.Pow(height, 2)));
            return calculatePersonBMI;
     
        }

        public static void PrintInfo(string name, string surname, int age, float weight, float height, float bmi)
        {
            Console.Write(name + " " + surname + " is ");
            Console.Write(age + " years old, ");
            Console.Write("his weight is " + weight + " kg ");
            Console.Write("his hieght is " + height + " cm. ");
            Console.WriteLine(name + " " + surname + "'s BMI is " + bmi);
        }
    }
}
