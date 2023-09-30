using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BootCamp.Chapter
{
    internal class Lesson4
    {
        public static void demo()
        {
            //Gather the input from the user.
            string name = PromptString("Enter your name: ");
            string surName = PromptString("Enter your surname: ");
            int age = PromptInt("Enter your age: ");
            float height = PromptFloat("Enter your height(m): ");
            float weight = PromptFloat("Enter your waight(Kg): ");

            //Find BMI
            double bodyMassIndex = CalculateBMI(weight, height);
            if(bodyMassIndex <= 0f ) 
            {
                return;
            }
            //Print messages
            Console.WriteLine(name + " " + surName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + "m.");
            Console.WriteLine("Body Mass Index measured for " + name + " " + surName + " is " + bodyMassIndex);
        }

        public static float CalculateBMI(float weight, float height)
        {
            if(weight <= 0f || height <= 0f)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (height <= 0f) Console.WriteLine("Height cannot be equal or less than zero, but was " + height);
                if (weight <= 0f) Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight);
                return -1f;
            }
            float bodyMassIndex = (weight / (height * height));
            return bodyMassIndex;
        }

        public static int PromptInt(string Message)
        {
            int age;
            Console.WriteLine(Message);
            string Input = Console.ReadLine();
            bool isAgeValid = int.TryParse(Input, out age);
            if (!isAgeValid)
            {
                Console.Write("\"" + Input + "\" is not a valid number." + Environment.NewLine);
                _ = Environment.NewLine;
                return -1;
            }
            return age;

        }

        public static float PromptFloat(string Message)
        {
            float metrics;
            Console.WriteLine(Message);
            string Input = Console.ReadLine();
            bool IsValidHeight_Weigth = float.TryParse(Input, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out metrics);
            if (!IsValidHeight_Weigth) 
            {
                Console.Write( "\"" + Input + "\" is not a valid number." + Environment.NewLine);
               
                return -1f;
            }
            return metrics;
        }

        public static string PromptString(string Message)
        {
            string Name;
            Console.WriteLine(Message);
            Name = Console.ReadLine();
            if(!String.IsNullOrEmpty(Name)) return Name;
            Console.WriteLine("Name cannot be empty" + Environment.NewLine);
            return "-";
        }
    }
}
