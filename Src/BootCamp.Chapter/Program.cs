using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.");

            var Tomweight = (64);

            var Tomheight = (156.5);

            var TomheightM = Tomheight / 100;

            var TombmiResult = Tomweight / TomheightM / TomheightM;

            Console.WriteLine("That means..");

            Console.Write("Tom Jefferson's total BMI is: " + (Math.Round(TombmiResult, 1)));

            Console.Write(" at the age of 19 years");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Caroline Jackson is 43 years old, her weight is 64 kg and her height is 154.8 cm.");

            var Carolineweight = 64;

            var Carolineheight = 154.8;

            var CarolineheightM = Carolineheight / 100;

            var CarolinebmiResult = Carolineweight / CarolineheightM / CarolineheightM;

            Console.WriteLine("That means..");

            Console.Write("Caroline Jackson's total BMI is: " + (Math.Round(CarolinebmiResult, 1)));
            Console.Write(" at the age of 43 years.");
             
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
