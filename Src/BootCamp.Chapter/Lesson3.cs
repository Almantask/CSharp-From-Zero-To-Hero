using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {

        public static void Demo()
        {
            string name = PromptString("Enter your Name: ");
            string surname = PromptString("Enter your Surname: ");
            int age = PromptInt("Enter your age: ");
            float weightkg = PromptFloat("Enter your weight(kg): ");
            float heightcm = PromptFloat("Enter your height(cm): ");
            float heightm = heightcm / 100;
            float bmi = CalculateBmi(weightkg, heightm);
            Console.WriteLine(bmi);
        }

         public static int PromptInt(string message)
        {
            Console.Write(message);
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string promptname = Console.ReadLine();
            return promptname;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            float promptinfo = float.Parse(Console.ReadLine());
            return promptinfo;
        }

        public static float CalculateBmi(float weightkg, float heightm)
        {
            float bmi = weightkg / (heightm * heightm);    
            return bmi;
        }

    }
}
