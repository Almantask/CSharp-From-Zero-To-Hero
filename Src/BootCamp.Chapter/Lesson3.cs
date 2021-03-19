using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {


           
            string firstName = returnString("Enter First Name");
            string lastName = returnString("Enter Last Name");
            int age = returnInt("Enter Your Age");
            float weight = returnFloat("Enter Your Weight in KG");
            float height = returnFloat("Enter Your Height in M");
            float bmi = calculateBMI(weight, height);
            Console.WriteLine("Your BMI is " + bmi);
            
            




         
        }


        public static int returnInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string returnString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float returnFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }

        public static float calculateBMI(float weight, float height)
        {
            return (float)Math.Round(weight / height / height, 2);
        }



    }
}
