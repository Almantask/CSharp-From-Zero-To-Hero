using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            
        }
        public static int PromptInt(string message)
        {
            int Newmessage;
            Console.WriteLine(message);
            Newmessage = int.Parse(Console.ReadLine());
            return Newmessage;
        }

        public static string PromptString(string message)
        {
            string name;
            Console.WriteLine(message);
            name = Console.ReadLine();
            return name;
        }


        public static float PromptFloat(string message)
        {
            float height;
            Console.WriteLine(message);
            height = float.Parse(Console.ReadLine());
            return height;
        }


        public static float CalculateBmi(float weight, float height)
        {
            float Bmi;
            Bmi = weight /(height*height);
            return Bmi;
        }
    }
}


