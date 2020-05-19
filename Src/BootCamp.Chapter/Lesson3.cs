using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        // Fields
        const float Invalidfloat = -1;
        const int InvalidInt = -1;
  
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
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " and his height is " + height);
            Console.WriteLine("Your BMI index is:" + CalculateBmi(weight, height));

        }

        public static int PromptInt(string message)
        {
             
            Console.WriteLine(message);
            var input =  Console.ReadLine();

            bool isNumber = int.TryParse(input, out int num);
            if (String.IsNullOrEmpty(input)) return 0;
            if (!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return InvalidInt;
            }
            else if (num == 0) return 0;

            else return num;
        }

        public static float PromptFloat(string message)
        {

            Console.WriteLine(message);
            var input = Console.ReadLine();

            bool isNumber = float.TryParse(input, out float num);

            if (String.IsNullOrEmpty(input)) return 0;
            if (!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return Invalidfloat;
            }
            else if (num == 0) return 0;

            else return num;

        }

        public static string PromptString(string message)
        {
            
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if(String.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";                          
            }
            
            else return input;

        }

        public static float CalculateBmi(float weight, float height)
        {

            const float Invalidfloat = -1;

            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return Invalidfloat;
            }
            else if (height <= 0 && weight > 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Height cannot be equal or less than zero, but was " + height + ".");
                return Invalidfloat;
            }
            else if (height > 0 && weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                return Invalidfloat;
            }
                return weight / (height * height);

        }

    }
}
