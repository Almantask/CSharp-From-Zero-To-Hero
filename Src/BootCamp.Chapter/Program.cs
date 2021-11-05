using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Please inter information for person------");
            personalinfo();
            Console.WriteLine("");
            Console.WriteLine("-----Please inter information for another person------");
            personalinfo();
            Console.ReadKey();
        }


        public static void personalinfo()
        {
            // private string name { get; set; }


            Console.WriteLine("Please inter your name:");
            info.name = Console.ReadLine();

            Console.WriteLine("Please inter your surename:");
            info.surename = Console.ReadLine();

            Console.WriteLine("Please inter your Age:");
            info.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please inter your Wight(kg):");
            info.weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please inter your height(cm):");
            info.height = float.Parse(Console.ReadLine());

            Console.WriteLine($"{info.name} {info.surename} is {info.age} years old, his weight is {info.weight}kg and his height is {info.height}cm.");

            Console.WriteLine($"and ({info.name} {info.surename}) BMI is:" + BMI(info.weight, info.height));
        }

        public static int BMI(double weight, double height)
        {
            return Convert.ToInt32(weight / ((height * height) / 10000));
        }
    }
}
