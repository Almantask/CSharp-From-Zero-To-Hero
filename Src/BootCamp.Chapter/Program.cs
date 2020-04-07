using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            //Get Name
            Console.Write("What is your name? ");
            var myName = Console.ReadLine();
            Console.WriteLine("Hello, " + myName + "!");
            //Get Age
            Console.Write("How old are you? ");
            var myAge = Console.ReadLine();
            //Get Weight
            Console.Write("How much do you weigh? ");
            double myWeight = Convert.ToDouble(Console.ReadLine());
            //Get Height
            Console.Write("What is your height? ");
            double myHeight = Convert.ToDouble(Console.ReadLine());
            //User Info
            Console.WriteLine(myName + " is " + myAge + " years old, their weight is " + myWeight + "kg and their height is " + myHeight + " cm.");


            //BMI formula = kg/m^2, convert cm to metres ^2
            double myHeightM = ((myHeight / 100) * (myHeight / 100));
            double BMI = myWeight / myHeightM;
            Console.WriteLine("Your BMI is " + BMI);

            //New Person

            Console.WriteLine("Hello World!");
            //Get Name
            Console.Write("What is your name? ");
            var myName2 = Console.ReadLine();
            Console.WriteLine("Hello, " + myName2 + "!");
            //Get Age
            Console.Write("How old are you? ");
            var myAge2 = Console.ReadLine();
            //Get Weight
            Console.Write("How much do you weigh? ");
            double myWeight2 = Convert.ToDouble(Console.ReadLine());
            //Get Height
            Console.Write("What is your height? ");
            double myHeight2 = Convert.ToDouble(Console.ReadLine());
            //User Info
            Console.WriteLine(myName2 + " is " + myAge2 + " years old, their weight is " + myWeight2 + "kg and their height is " + myHeight2 + " cm.");


            //BMI formula = kg/m^2, convert cm to metres ^2
            double myHeightM2 = ((myHeight2 / 100) * (myHeight2 / 100));
            double BMI2 = myWeight2 / myHeightM2;
            Console.WriteLine("Your BMI is " + BMI2);

        }
    }
}
