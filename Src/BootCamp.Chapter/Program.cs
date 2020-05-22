using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args) 
        {
            string firstName = "Mert Efe";
            string surName = "Isikgor"; 
            int age = 24;
            double weight = 85; 
            double height = 1.81; 
            double BMI = weight / (height * height); 

            string name = "Cagan";
            string lastName = "Satir";
            int ageOf = 24;
            double caganWeight = 75; 
            double caganHeight = 1.78;
            double caganBMI = caganWeight / (caganHeight * caganHeight);
            

            Console.WriteLine(firstName + " is " + age + " years old. And his last name is " + surName + ". His BMI Score is: " + BMI + ".");
            Console.WriteLine("And the friend of " + firstName + " which is his name " + name + " " + lastName + ". His Age and BMI Scores are: " + ageOf + " and " + caganBMI + ".");

        }
    }
}
