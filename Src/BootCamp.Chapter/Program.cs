using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program : ILogger
    {
        static void Main(string[] args)
        {
            /*            var p = new Program();
                        p.LogToFile("Again");
                        p.LogToConsole("We logged to file.");*/

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("First name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Sure Name: ");
                string sureName = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Weight: ");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Height: ");
                double height = double.Parse(Console.ReadLine());

                var bmi = BMICalc(weight, height);

                Console.WriteLine($"{name} {sureName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                Console.WriteLine($"Your BMI - {bmi:N2}");
            }
        }

        public void LogToConsole(string text)
        {
            Console.WriteLine(text);
        }

        public void LogToFile(string text)
        {
            string path = @"C:\Users\Rabanian\Desktop\C# Bootcamp\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Logs.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(text);
                }
            }
            else
            {
                using(StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(text);
                }
            }
        }
    }
}
