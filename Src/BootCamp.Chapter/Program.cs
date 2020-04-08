using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //experimenting with variables
            string exampleName = "Tom Jefferson";

            int age1 = 19;
            float weightTom = 50.0f;
            float heightTom = 156.5f;
            Console.WriteLine(exampleName + " is " + age1 + " years old, his weight is " + weightTom + " kg and his height is " + heightTom + " cm.");

            float tomHeightInMetersSquared = heightTom / 100.0f;
            tomHeightInMetersSquared = tomHeightInMetersSquared * tomHeightInMetersSquared;
            var bodyMassIndex = weightTom / tomHeightInMetersSquared;
            Console.WriteLine("Tom's BMI is " + bodyMassIndex);

            //second person, different approach
            Console.WriteLine("Zache Hutchingson is 25 years old, his weight is 65 kg and his height is 178.6 cm");
            float heightZache = 178.6f;
            heightZache = heightZache / 100.0f;
            float weightZache = 65.0f;
            float zacheHeightSquared = heightZache * heightZache;
            var bodyMassIndexZache = weightZache / zacheHeightSquared;
            Console.WriteLine("Zache's BMI is " + bodyMassIndexZache);
        }
    }
}
