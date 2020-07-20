using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 35;
            int rAge = 68;
            string myFirstName = "James";
            string myLastName = "Mundy";
            string rFirstName = "Rose";
            string rLastName = "Mundy";
            double myWeight = 111.584;
            double myHeight = 185.42000000000002;
            double rWeight = 80;
            double rHeight = 150;
            double BMIFormula = myWeight / (myHeight * myHeight) * 703;
            double rBMIForuma = rWeight / (rHeight * rHeight) * 703;

            Console.WriteLine(myFirstName + " " + myLastName + " is " + myAge + " years old, his weight is " + myWeight +
                " kg and his height is " + myHeight + ". " + myFirstName + "'s BMI is " + BMIFormula);

            Console.WriteLine(rFirstName + " " + rLastName + " is " + rAge + " years old, his weight is " + rWeight +
                " kg and her height is " + rHeight + ". " + rFirstName + "'s BMI is " + rBMIForuma);

        }
    }
}
