using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = PrintString();
            Console.WriteLine(name);

            var age = PrintInt("Age: ", "Age");
            Console.WriteLine(age);

            float weight = PrintInt("Weight (kg): ", "Weight");
            Console.WriteLine(weight);

            float height = PrintInt("Height (m): ", "Height");
            Console.WriteLine(height);
           
            var bmi = CalculateBmi(name, age, weight, height);
        }
        //Error messages for strings
        static string ErrorString(string input)
        {
            var str = PromptString(input);
            var error = "Name cannot be empty";

            if (str == "-") return error;

            else
            {
                return null;
            }
        }
        //Returns "-" if the input is empty
        public static string PromptString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "-";
            }
            else return input;
        }
        //returns error message if there is an error and returns null if there is no error
        static string PrintString()
        {
            Console.Write("Full Name: ");
            var input = Console.ReadLine();
            var error = ErrorString(input);
            
            if (error == null) return null;
            else
            {
                return error;
            }
        }
        //Returns error message if there is an error, if there isn't it returns null
        static string PrintInt(string message, string errorName)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            var error = ErrorInt(errorName, input);
            if (error == null) return null;
            else
            {
                return error;
            }
        }
        //error messages for int
        static string ErrorInt(string error, string input)
        {
            var variable = PromptInt(input);
            var error1 = input + " is not a number";
            var error2 = error + " cannot be empty";

            if (variable == -1) return error1;
            else if (variable == 0) return error2;
            else
            {
                return null;
            }
        }
        //checks if any of the variables needed to calculate bmi is less than 0
        static float BmiError(float weight, float height)
        {
            if (weight <= 0) return -0;
            if (height <= 0) return -1;
            if (height >= 0) return 0;
            else if (weight >= 0) return 0;
            else
            {
                return -2;
            }
        }

        //returns error messages for height and weight
        static string BmiErroMessages(float weight, float height)
        {
            var errorMsg = "Failed calculating BMI. Reason: ";
            var error = BmiError(weight, height);
            var errorMsg1 = errorMsg + "Weight cannot be equal or less than zero, but was " + weight;
            var errorMsg2 = errorMsg + "Height cannot be equal or less than zero, but was " + height;

            if (error == -0) return errorMsg1;
            else if (error == -1) return errorMsg2;
            else if (error == -2) return errorMsg1 + "\n" + errorMsg2;
            else
            {
                return null;
            }
        }
        static string CalculateBmi(string name, string age, float weight, float height)
        {
            var bmi = weight / height / height;
            var error = BmiErroMessages(weight, height);
            var printBmi = name + " is " + age + " years old, his weight is " + weight + " kg, his height is " + height + " and his bmi is " + bmi;

            if (error == null) return printBmi ;
            else
            {
                return error;
            }
        }
        
        //returns -1 if input is not a number, returns 0 if it is empty and returns output if there isn't a problem
        public static int PromptInt(string input)
        {
           
            bool isNumber = int.TryParse(input, out var output);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (!isNumber) return -1;

            else
            {
                return output;
            }

        }



    }
}
