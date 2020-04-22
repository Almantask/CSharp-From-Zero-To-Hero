using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            ProcessPersonBMI();
            ProcessPersonBMI();
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

        public static void ProcessPersonBMI()
        {
            string name = PromptString("Enter your Name: ");
            string surname = PromptString("Enter your Surname: ");
            int age = PromptInt("Enter your age: ");
            float weightkg = PromptFloat("Enter your weight(kg): ");
            float heightcm = PromptFloat("Enter your height(cm): ");
            float heightm = heightcm / 100;
            float bmi = CalculateBmi(weightkg, heightm);
            //Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 
            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weightkg + " kg and his height is " + heightcm + " cm. His BMI is " + bmi);
            Console.WriteLine();
        }
    }
}
