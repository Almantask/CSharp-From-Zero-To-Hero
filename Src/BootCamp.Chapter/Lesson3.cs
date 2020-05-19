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

            BmiIndexer();
            BmiIndexer();
            
        }

        public static void BmiIndexer()
        {
            var firstName = PromptString("Type  your First name: ");
            var lastName = PromptString("Type your Last Name");
            var age = PromptInt("Please Type your age: ");
            var weight = PromptFloat("Type your Weight");
            var height = PromptFloat("Type your Height");
            Console.WriteLine(firstName +" " + lastName + " is " + age + " years old, his weight is " + weight +  " and his height is "+ height);
            Console.WriteLine("Your BMI index is:" + CalculateBmi(weight, height));

        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());

        }

        public static float PromptFloat(string message)
        {

            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        }

        public static string PromptString(string message)
        {

            Console.WriteLine(message);
            return Console.ReadLine();

        }

        public static float CalculateBmi(float weight, float height)
        {

            return weight / (height * height);



        }
    }
}
