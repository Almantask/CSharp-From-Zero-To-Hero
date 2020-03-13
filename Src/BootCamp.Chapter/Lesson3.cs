using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            string name = StringName("Hello.Please state your name: ");
            int age = IntAge("Please state your age: "); 
            float weight = FloatBody("Please state your weight: ");
            float height = FloatBody("Please state your height: ");

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");

            //BMI calculations

            float bmi = CalculateBmi(weight, height);
            Console.WriteLine("Your BMI is: " + bmi);
        }

        //function for name
        public static string StringName(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        //function for age
        public static int IntAge(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        //function for weight and height
        public static float FloatBody(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }

        //BMI
        public static float CalculateBmi(float weight, float height)
        {
            return weight/ height / height;
        }
    }
}
