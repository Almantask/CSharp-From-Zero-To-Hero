using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.");
            int TomsWeight = 50;
            float TomsHeight = 156.5f;
            float TomsBMI = ((TomsWeight / TomsHeight)/TomsHeight)*10000;
            Console.WriteLine("Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. His BMI is " + TomsBMI + ".");

            Console.WriteLine("Samson is 30 years old, his weight is 200 lbs and his height is 69 inches.");
            float SamsonsWeight = 200;
            float SamsonsHeight = 69;
            float SamsonsBMI = ((SamsonsWeight / SamsonsHeight)/SamsonsHeight)*703;
            Console.WriteLine("Samson is 30 years old, his weight is 200 lbs and his height is 69 inches. His BMI is " + SamsonsBMI + ".");
        }
    }
}
