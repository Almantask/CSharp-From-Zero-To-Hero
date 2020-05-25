using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int tWeight = 50;
            float tHeight = 1.565F;
            float tBmi = tWeight / tHeight;
            int tAge = 19;

            int cWeight = 68;
            float cHeight = 1.55F;
            float cBmi = cWeight / cHeight;
            int cAge = 20;

            int bWeight = 61;
            float bHeight = 1.41F;
            float bBmi = bWeight / bHeight;
            int bAge = 32;

            Console.Write("Hello world!" + System.Environment.NewLine);

            Console.WriteLine("Tom's age is " + tAge + "and his height is " + tHeight + " and his weight is " + tWeight + " BMI is: " + tBmi);
            Console.WriteLine("Colby's age is " + cAge + "and his height is " + cHeight + " and his weight is " + cWeight + " BMI is: " + cBmi);
            Console.WriteLine("Blakes's age is " + bAge + " and his height is " + bHeight + " and his weight is " + bWeight + " BMI is: " + bBmi);
            Console.ReadLine();
        }
    }
}
