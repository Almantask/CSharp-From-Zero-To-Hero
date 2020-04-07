using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {

        public static void Demo()
        {
            PersonalInfo();
            PersonalInfo();
        }

        public static void PersonalInfo(){

            string name = WholeName(message: "Input your name: ");
            string surname = WholeName(message: "Input your surname: ");
            int age = Age(message: "Input your age: ");
            float height = HeightAndWeight(message: "Input your height in meters: ");
            float weight = HeightAndWeight(message: "Input your weight in kg: ");
            float bmi = CalculateBMI(weight: weight, height: height);

            Console.WriteLine(name + " " + surname + " " + "is" + " " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m and his/her BMI is: " + bmi);

        }

        public static string WholeName(string message)
        {
            Console.WriteLine(message);
            string partOfName = Console.ReadLine();

            return partOfName;
        }

        public static float HeightAndWeight(string message)
        {
            Console.WriteLine(message);
            float value = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return value;
        }

        public static int Age (string message)
        {
            Console.WriteLine(message);
            int age = Convert.ToInt32(Console.ReadLine());

            return age;
        }

        public static float CalculateBMI(float weight, float height)
        {
            
            float bmi = weight / (height * height);

            return bmi;
        }
    }
}
