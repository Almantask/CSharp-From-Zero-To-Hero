using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person number 1
            Console.WriteLine("Entre your name and surname");
            string nameSurname1 = Console.ReadLine();
            Console.WriteLine("Entre your age");
            string age1 = Console.ReadLine();
            Console.WriteLine("Entre your weight in kg");
            string weight1 = Console.ReadLine();
            Console.WriteLine("Entre your height in cm");
            string height1 = Console.ReadLine();
            Console.WriteLine(nameSurname1 + " is " + age1 + " years old, his weight is " + weight1 + " kg and his height is " + height1 + " cm");


            var weightBMI = Convert.ToDouble(weight1);
            var heightBMI = Convert.ToDouble(height1) / 100;

            double BMI1 = weightBMI / (heightBMI * heightBMI);
            Console.WriteLine("Your body-mass index is " + BMI1);

            // Person number 2
            Console.WriteLine("Entre your name and surname");
            string nameSurname2 = Console.ReadLine();
            Console.WriteLine("Entre your age");
            string age2 = Console.ReadLine();
            Console.WriteLine("Entre your weight in kg");
            string weight2 = Console.ReadLine();
            Console.WriteLine("Entre your height in cm");
            string height2 = Console.ReadLine();
            Console.WriteLine(nameSurname2 + " is " + age2 + " years old, his weight is " + weight2 + " kg and his height is " + height2 + " cm");


            var weightBMI2 = Convert.ToDouble(weight2);
            var heightBMI2 = Convert.ToDouble(height2) / 100;

            double BMI2 = weightBMI2 / (heightBMI2 * heightBMI2);
            Console.WriteLine("Your body-mass index is " + BMI2);
        }
    }
}
