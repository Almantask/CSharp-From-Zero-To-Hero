using System;
namespace BootCamp.Chapter1
{
    class Program
    {
        //test comment
        static void Main(string[] args)
        {
            int age = 21;       // in years
            float weight = 58.9f;   //in kg
            float height = 167.6f;  //in cm
            string myName = "ComV99";
            var bmi = weight / ((height * height) / 1000);

            Console.WriteLine(myName + " is " + age +
                   " years old, his weight is " + weight +
                   " kg and his height is " + height + "cm.");
            Console.WriteLine("His BMI is " + bmi);

            age = 2;
            weight = 12;
            height = 60;
            string otherName = "Todd";
            bmi = weight / ((height * height) / 1000);

            Console.WriteLine(otherName + " is " + age +
                   " years old, his weight is " + weight +
                   " kg and his height is " + height + "cm.");
            Console.WriteLine("His BMI is " + bmi);
            //test comment
        }
    }
}