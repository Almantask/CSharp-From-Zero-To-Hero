using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = PrintAndReadString("Hello, what's the name of the person that you want to calculate the BMI?");
            Console.WriteLine(name);
            string surename = PrintAndReadString("What's the surename?");
            int age = PrintAndReadInt("What's the age? ");
            Console.WriteLine(age);
            float height = PrintAndReadFloat("What's the height in meters?");
            Console.WriteLine(height);
            float weight = PrintAndReadFloat("What's the weight in kg?");
            Console.WriteLine(weight);

            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m ");
            Console.WriteLine(name + " " + surename + "'s BMI is " + BmiCalc(weight, height));

            name = PrintAndReadString("Hello, what's the name of the person that you want to calculate the BMI?");
            surename = PrintAndReadString("What's the surename?");
            age = PrintAndReadInt("What's the age?");
            height = PrintAndReadFloat("What's the height in meters?");
            weight = PrintAndReadFloat("What's the weight in kg?");

            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m ");
            Console.WriteLine(name + " " + surename + "'s BMI is " + BmiCalc(weight, height));

            Console.ReadLine();
        }
        public static float BmiCalc(float weight, float height)
        {
            int control = 0;
            if (height <= 0) control = 1;
            if (weight <= 0) control += 2;
            switch (control)
            {
                case (0):
                    return (weight / (height * height));
                case (1):
                    Console.WriteLine("Failed calculating BMI. Reason:");
                    Console.WriteLine("Height cannot be less than zero, but was " + height);
                    break;
                case (3):
                    Console.WriteLine("Failed calculating BMI. Reason:");
                    Console.WriteLine("Height cannot be less than zero, but was " + height);
                    Console.WriteLine("Weight cannot be less than zero, but was " + weight);
                    break;
            }
            return 0;

        }
        public static string PrintAndReadString(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return name;
        }
        public static int PrintAndReadInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int age;
            bool isNumber;
            if (string.IsNullOrEmpty(input)) return 0;
            else
            {
                isNumber = int.TryParse(input, out age);
            }

            if (!isNumber)
            {
                Console.WriteLine("'" + input + "'" + " is not a valid number");
                return -1;
            }
            else
            {
                return age;
            }
        }
        public static float PrintAndReadFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return 0;
            else
            {
                float output = Convert.ToSingle(input);
                return output;
            }
            
        }
    }
}