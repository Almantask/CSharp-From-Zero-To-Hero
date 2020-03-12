using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = NameString("Hello.Please state your name: ");
            float age = FloatNum("Please state your age: "); 
            float weight = FloatNum("Please state your weight: ");
            float height = FloatNum("Please state your height: ");

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");

            //New function for name
            static string NameString(string message)
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            }

            //New function for age, weight and height. to minimize code made int age to float age
            static float FloatNum(string message)
            {
                Console.WriteLine(message);
                return float.Parse(Console.ReadLine());
            }

            //BMI calculations

            float bmi = CalculateBMI(weight, height);
            Console.WriteLine("Your BMI is:" + bmi);
            static float CalculateBMI(float weight, float height)
            {
                return weight * 703 / height / height;
            }

        }
    }
}
