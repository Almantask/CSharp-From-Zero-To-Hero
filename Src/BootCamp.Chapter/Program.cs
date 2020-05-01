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
            Print(1);
            Print(2);
        }
        static void Print(int number)
        {
            Console.WriteLine("Person #" + number);

            Console.Write("Full Name: ");
            var inputName = Console.ReadLine();
            var errorName = ErrorString(inputName);

            if (errorName == null)
            {

            }
            else
            {
                Console.WriteLine(errorName);
            }

            Console.Write("Age: ");
            var inputAge = Console.ReadLine();
            var errorAge = ErrorInt("Age", inputAge);
            if (errorAge == null)
            {

            }
            else
            {
                Console.WriteLine(errorAge);
            }

            Console.Write("Weight (kg): ");
            var inputWeight = Console.ReadLine();
            var errorWeight = ErrorFloat(inputWeight, "Weight");
            if (errorWeight == null)
            {

            }
            else
            {
                Console.WriteLine(errorWeight);
            }

            Console.Write("Height (m): ");
            var inputHeight = Console.ReadLine();
            var errorHeight = ErrorFloat(inputHeight, "Height");
            if (errorHeight == null)
            {

            }
            else
            {
                Console.WriteLine(errorHeight);
            }

            var bmi = CalculateBmi(inputName, inputAge, inputWeight, inputHeight);
            Console.WriteLine(bmi);
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
        static float BmiErrorWeight(float weight)
        {
            
            if (weight <= 0) return -1;
            
            
            else
            {
                return 0;
            }
        }
        static float BmiErrorHeight(float height)
        {
            if (height <= 0) return -1;

            else
            {
                return 0;
            }
        }

        //returns error messages for height and weight
        static string BmiErroMessages(float weight, float height)
        {
            var errorMsg = "Failed calculating BMI. Reason: ";
            var errorWeight = BmiErrorWeight(weight);
            var errorHeight = BmiErrorHeight(height);
            var errorMsg1 = errorMsg + "Weight cannot be equal or less than zero, but was " + weight;
            var errorMsg2 = errorMsg + "Height cannot be equal or less than zero, but was " + height;

            if (errorWeight == -1) 
                if (errorHeight == -1) return errorMsg1 + "\n" + errorMsg2;
                else
                {
                    return errorMsg1;
                }

            if (errorHeight == -1)
                if (errorWeight == -1) return errorMsg1 + "\n" + errorMsg2;
                else
                {
                    return errorMsg2;
                }



                else
                {
                    return null;
                }
        }
        static string CalculateBmi(string name, string age, string weight, string height)
        {

            var parsedWeight = float.Parse(weight);
            var parsedHeight = float.Parse(height);
            float bmi =( parsedWeight / parsedHeight / parsedHeight);
            var error = BmiErroMessages(parsedWeight, parsedHeight);
            var printBmi = name + " is " + age + " years old, his weight is " + weight + " kg, his height is " + height + "m and his bmi is " + bmi;

            if (error == null) return printBmi;
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
        
        static float PromptFloat(string input)
        {
            bool isNumber = float.TryParse(input, out var output);
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

        static string ErrorFloat(string input, string error)
        {
            var variable = PromptFloat(input);
            var error1 = input + " is not a number";
            var error2 = error + " cannot be empty";

            if (variable == -1) return error1;
            else if (variable == 0) return error2;
            else
            {
                return null;
            }
        }





    }
}
