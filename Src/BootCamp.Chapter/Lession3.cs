using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lession3
    {
        
        public static void Demo()
        {
            GatherUserInput();
            CalcBMI(weight, height);
            PrintConsole(firstname, secondname, age, weightsingle, heightsingle, BMI);
        }
        public static void GatherUserInput()
        {
            //User data input
            Console.WriteLine("What is your first name?");
            var firstname = Console.ReadLine();

            Console.WriteLine("What is your second name?");
            var secondname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What is your weight in kg?");
            var weight = Console.ReadLine();

            Console.WriteLine("What is your height in Meters?");
            var height = Console.ReadLine();

        }
        public static void CalcBMI(int weight, int height)
        {
            //Convert to Singles
            var weightsingle = Convert.ToSingle(weight);
            var heightsingle = Convert.ToSingle(height);

            //Calc for BMI
            var Calc1 = weightsingle / heightsingle;
            var BMI = Calc1 / heightsingle;
        }
        static void PrintConsole(string firstname, string secondname, int age, float weightsingle, float heightsingle, float BMI)
        {
            //Display output to user
            Console.WriteLine(firstname + " " + secondname + "is " + age + " years old, his weight is " + weightsingle + " kg and his height is " + heightsingle + " cm ");
            Console.WriteLine("Your BMI is " + BMI);

        }



    }




            

}
     