using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int myAge = 25;
            decimal myWeight = 77m;
            decimal myHeight = 167.6m;
            string myName = "Al";
            string mySurname = "Serna";
            Console.WriteLine( "My name is " + myName + " " + mySurname + " " + "I am " + myAge + " " + "years old, " + "I weigh " + myWeight + " " + "kilograms " + "and I measure " + myHeight + " " + "centimeters." );
            




            decimal myHeightInMeters = 1.676m;
            decimal myHeightInMetersSquared = myHeightInMeters * myHeightInMeters;
            var myBmi = myWeight / myHeightInMetersSquared;
            Console.WriteLine("My BMI is " + myBmi );






            int otherAge = 21;
            decimal otherWeight = 63.5m;
            decimal otherHeight = 162.6m;
            string otherName = "Rafa";
            string otherSurname = "Erende";
            Console.WriteLine(otherName + " " + otherSurname + " " + "is " + otherAge + " " +"years old " + "and weighs " + otherWeight + " " + "kilograms " + "and measures " + otherHeight + " " + "centimeters.");




            decimal otherHeightInMeters = 1.626m;
            decimal otherHeightInMetersSquared = otherHeightInMeters * otherHeightInMeters;
            var otherBmi = otherWeight / otherHeightInMetersSquared;
            Console.WriteLine("Rafa's BMI is " + otherBmi);


            
            
            
            Console.ReadLine();




        }
    }
}
