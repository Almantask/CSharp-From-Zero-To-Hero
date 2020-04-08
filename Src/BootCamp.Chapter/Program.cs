using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();         //NAME
            Console.WriteLine("What's your surname?");
            string surname = Console.ReadLine();      //SURNAME
            Console.Write("How old are you?");
            var age = Console.ReadLine();             //AGE
            Console.Write("How much do you weight?"); 
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("How high are you (in meters)?");  //HEIGH
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(name+" "+surname+" is "+age+" years old, weight "+weight+" kg and is "+height+" m tall.");   //PRINTING INFO
            Console.WriteLine("His BMI equals: "+ weight /(height*height)+".");   //BMI

            //ANOTHER PERSON

            Console.WriteLine("What's your name?");
            string name2 = Console.ReadLine();         //NAME2
            Console.WriteLine("What's your surname?");
            string surname2 = Console.ReadLine();      //SURNAME2
            Console.Write("How old are you?");
            var age2 = Console.ReadLine();             //AGE2
            Console.Write("How much do you weight?");
            double weight2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("How high are you (in meters)?");  //HEIGH2
            double height2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(name2 + " " + surname2 + " is " + age2 + " years old, weight " + weight2 + " kg and is " + height2 + " m tall.");   //PRINTING INFO
            Console.WriteLine("His BMI equals: " + weight2 / (height2 * height2) + ".");   //BMI2
        }
    }
}
