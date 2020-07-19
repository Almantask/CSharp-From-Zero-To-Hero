using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            PromptPerson(1);
            PromptPerson(2); 
            CloseProgram("Press any key to quit");
        }

        public static float CalculateBMI(float weight, float height)
        {
            if (weight <= 0.0F && height <= 0.0F )
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");              
                return -1;
            }
            if (weight <= 0.0F)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }
            if (height <= 0.0F)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }
            return weight / MathF.Pow(height, 2);
        }

        public static int InputInt(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return 0;
            var isValid =  int.TryParse(input,out int number);
            if (!isValid)
            { 
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            if (number == 0) return 0;
            return number;
        }

        public static float InputFloat(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return 0.0F;
            var isValid =  float.TryParse(input,NumberStyles.Float, CultureInfo.InvariantCulture, out float number);
            if (!isValid)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            if (number == 0.0F) return 0.0F;
            return number;
        }

        public static string InputString(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            var isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty)
            { 
                Console.Write("Name cannot be empty.");
                return "-";
            }
            return input;  
        }

        public static void NewPerson()
        {
            //Gather Input
            string firstName = InputString("Enter First Name: ");
            string lastName = InputString("Enter Last Name: ");
            int personsAge = InputInt("Enter Age: ");
            float personsWeight = InputFloat("Enter Weight in kg: ");
            float personsHeight = InputFloat("Enter Height in m: ");

            //Echo data to console
            Console.WriteLine(firstName + " " + lastName + " is " + personsAge + " years old, their weight is "
                                + personsWeight + " and their height is " + personsHeight + " m.");

            //Calculate and Display BMI
            Console.WriteLine("Their BMI is " + string.Format("{0:0.#}", CalculateBMI(personsWeight, personsHeight)));
            Console.WriteLine();

        }
        
        public static void PromptPerson(int index)
        {
            Console.WriteLine("Please enter the information for person " + index);
            NewPerson();
        }

        public static void CloseProgram(string message)
        {
            if (!String.IsNullOrEmpty(message))
                Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}


