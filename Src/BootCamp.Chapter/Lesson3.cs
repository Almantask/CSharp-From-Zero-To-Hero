using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            var FirstName = PromptString("What's your first name?");
            var LastName = PromptString("What's your last name?");
            int Age = PromptInt("How old are you?");
            float DemoWeight = PromptFloat("How much do you weight in kilo's?");
            float DemoHeight = PromptFloat("How tall are you in cm?");
            float FinalBmi = CalculateBmi(DemoHeight, DemoWeight);

            Console.WriteLine("-------------------");
            Console.WriteLine(FirstName + " " + LastName + " is " + Age + " years old.");
            Console.WriteLine("His weight is " + DemoWeight + "kg and his height is " + (DemoHeight/100) + " meters.");
            Console.WriteLine("Their BMI is: " + FinalBmi);
            Console.WriteLine("-------------------");
        }
        public static float CalculateBmi(float Weight, float Height)
        {
            var Bmi = Weight / Height / Height;
            //if needing pounds, use inches instead of cm
            //var BmiPounds = (Weight / Height / Height) * 703;
            return Bmi;
        }
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }
    }
}
