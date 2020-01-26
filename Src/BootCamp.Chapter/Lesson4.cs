using System;

namespace BootCamp.Chapter
{
    class Lesson4
    {

        public static void Demo()
        {
            bool backtotop = true;
            while (backtotop)
            {
                //User data input
                var firstname = MessageString("What is your first name ?");
                var secondname = MessageString("What is your second name ? ");
                var age = MessageInt("What is your age?");
                var weight = MessageFloat("What is your weight in kg?");
                var height = MessageFloat("What is your height in Meters?");

                //Calc and return BMI
                CalcBmi(weight, height);

                //Display output to user
                Console.WriteLine(firstname + " " + secondname + "is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm ");
                Console.WriteLine("Your BMI is " + CalcBmi(weight, height));

                //Continue
                Console.WriteLine("Would you like to do another person Y/N?");
                var option = Console.ReadLine();
                if ((option) == "N" || (option) == "n")
                {
                    backtotop = false;
                }
            }
        }
        public static string MessageString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || (input == "-")) 
            {
                Console.WriteLine("- Name cannot be empty");
            }
            bool Isitnumber = int.TryParse(input, out var number);
            if (Isitnumber)
            {
                Console.WriteLine( number +  " This looks like a number, please use string ");
            }
                return input;
        }
        public static float MessageFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(input + " Height/Weight cannot be Null or Empty ");
                return -0;
            }
            bool Isitnumber = int.TryParse(input, out var number);
            if (!Isitnumber)
            {
                Console.WriteLine(number + " This doesn't look like a number ");
                return -1;
            }
            return number;
        }
        public static int MessageInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(input + " Age cannot be Null or Empty ");
                return -1;
            }
            bool Isitnumber = int.TryParse(input, out var number);
            if (!Isitnumber)
            {
                Console.WriteLine(number + " This doesn't look like a number ");
                return -1;
            }
            if (number <= 0 || number >= 200)
            {
                Console.WriteLine(" please put in valid number range between 0 and 200");
                return -1;
            }
            return number;
        }
        public static float CalcBmi(float weight, float height)
        {
            //Convert to Singles
            var weightsingle = Convert.ToSingle(weight);
            var heightsingle = Convert.ToSingle(height);

            //Calc for BMI
            var calc1 = weightsingle / heightsingle;
            var bmi = calc1 / heightsingle;

            if (weight <=0 && height <=0)
            {
                Console.WriteLine("Weight and Height invalid");
            }
            if (weight <= 0)
            {
                Console.WriteLine("Is not a valid weight");
            }
            if (height <= 0)
            {
                Console.WriteLine("Is not a valid height");
            }
            if (bmi <= 0)
            {
                Console.WriteLine("BMI is invalid");
            }
            return bmi;
        }
    }
}
