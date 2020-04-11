using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static string GreetName(string userNo)
        {
            Console.WriteLine("Hello " + userNo + " user! What's your name?");
            string name = Convert.ToString(Console.ReadLine());
            return name;
        }
        public static string Surname()
        {
            Console.WriteLine("Great, and what's your surname?");
            string surname = Convert.ToString(Console.ReadLine());
            return surname;
        }
        public static int Age()
        {
            Console.WriteLine("Amazing, and how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        public static float Weight()
        {
            Console.WriteLine("Cool, and what's your weight?");
            float weight = float.Parse(Console.ReadLine());
            return weight;
        }
        public static float Height()
        {
            Console.WriteLine("Groovie, and how tall are you (in meters)?");
            float height = float.Parse(Console.ReadLine());
            return height;
        }
        public static float Bmi(float weight, float height)
        {
            float bmi = (weight / height / height);
            return bmi;
        }
       
        public static void Demo()
        {
            static void GatherAndPrint(string userNo)
            {
                string name = GreetName(userNo);
                string surname = Surname();
                int age = Age();
                float weight = Weight();
                float height = Height();
                float bmi = Bmi(weight, height);

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
                Console.WriteLine("Based on this information, your BMI is " + bmi);
            }

            GatherAndPrint("first");
            GatherAndPrint("second");
        }
    }
}
