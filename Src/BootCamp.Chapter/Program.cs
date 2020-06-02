using System;

namespace BootCamp
{
    class BMI1
    {
        static void Main(string[] args)
        {
            string Name = "James Ferguson";
            int Age = 30;
            var Sex = "his";

            double Height = 195.0;
            var heightMetres = Height / 100.0;
            var heightMetresMultiplied = heightMetres * heightMetres;
            double Weight = 96.4;
            double BMI = Weight / heightMetresMultiplied;
            BMI = Convert.ToInt32(BMI);

            Console.WriteLine($"{Name} is {Age} years old, {Sex} weight is {Weight} kg and {Sex} height is {Height}cm");

            if (BMI < 18.5)
            { Console.WriteLine($"Your BMI is {BMI}. Which is Underweight. Go have a piece of cake :("); }
            if (BMI >= 18.5 & BMI <= 24.9)
            { Console.WriteLine($"Your BMI is {BMI}. Which is Normal. Good stuff just a small piece of cake should do :)"); }
            if (BMI >= 25 & BMI <= 29.9)
            { Console.WriteLine($"Your BMI is {BMI}. Which is Overweight. Steady on with that next piece of cake mate!"); }
            if (BMI > 30.0)
            { Console.WriteLine($"Your BMI is {BMI}. Which is Obese. listen you ate the cake already there is no second cake!!!"); }
        }
    }
}