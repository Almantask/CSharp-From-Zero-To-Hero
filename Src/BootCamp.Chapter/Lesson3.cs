using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void demo()
        {
           
            string name = PromptString("Enter your name: ");
            string surName = PromptString("Enter your surname: ");
            int age = PromptInt("Enter your age: ");
            float height = PromptFloat("Enter your height(m): ");
            float weight = PromptFloat("Enter your waight(Kg): ");

            Console.WriteLine(name + " " + surName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + "m.");
            double bodyMassIndex = CalculateBMI(weight, height);
            Console.WriteLine("Body Mass Index measured for " + name + " " + surName + " is " + bodyMassIndex);


        }

        public static float CalculateBMI(float weight, float height)
        {
            float bodyMassIndex = (weight / (height * height));
            return bodyMassIndex;
        }

        public static int PromptInt(string Message)
        {
            int age;
            do
            {
                Console.Write(Message);
                if (int.TryParse(Console.ReadLine(), out age))
                    break;
                else
                    Console.Write("Please enter number for age, ");
            } while (true);

            return age;

        }

        public static float PromptFloat(string Message)
        {
            float metrics;
            do
            {
                Console.Write(Message);
                if (float.TryParse(Console.ReadLine(), NumberStyles.Float, NumberFormatInfo.InvariantInfo , out metrics))
                    break;
                else
                    Console.Write("Please enter number\\decimal,");
            } while (true);
            return metrics;
        }

        public static string PromptString(string Message)
        {
            string Name;
            Console.Write(Message);
            Name = Console.ReadLine();
            return Name;
        } 
    }
}
