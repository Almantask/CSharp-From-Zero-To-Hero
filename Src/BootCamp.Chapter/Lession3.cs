using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lession3
    {
        
        public static void Demo()
        {
            bool backtotop = true;
            while(backtotop)
            { 
            //User data input
            var firstname = MessageString("What is your first name ?");
            var secondname = MessageString("What is your second name ? ");
            var age = MessageInt("What is your age?");
            var weight = MessageFloat("What is your weight in kg?");
            var height = MessageFloat("What is your height in Meters?");
            float BMI = CalcBMI(weight, height);
           
            //Calc and return BMI
            CalcBMI(weight, height);

            //Display output to user
            Console.WriteLine(firstname + " " + secondname + "is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm ");
            Console.WriteLine("Your BMI is " + BMI);

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
            return Console.ReadLine();
        }
        public static float MessageFloat(string message)
        {
            return Convert.ToSingle(MessageString(message));
        }

        public static int MessageInt(string message)
        {
            return Convert.ToInt32(MessageString(message));
        }

        public static float CalcBMI(float weight, float height)
        {
                //Convert to Singles
                var weightsingle = Convert.ToSingle(weight);
                var heightsingle = Convert.ToSingle(height);

                //Calc for BMI
                var Calc1 = weightsingle / heightsingle;
                return Calc1 / heightsingle;
        }
    }     
}
     