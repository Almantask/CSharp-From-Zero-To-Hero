using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //experimenting with variables
            Console.WriteLine("What is your name?");
            string exampleName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age1 = Int32.Parse(Console.ReadLine());
            

            Console.WriteLine("What is your weight in kg?");
            float weight1 = float.Parse(Console.ReadLine());
            

            Console.WriteLine("What is your height in cm?");
            float height1 = float.Parse(Console.ReadLine());
            

            Console.WriteLine(exampleName + " is " + age1 + " years old, your weight is " + weight1 + " kg and your height is " + height1 + " cm.");
         
            float height1InMetersSquared = height1 / 100.0f;
                  height1InMetersSquared = height1InMetersSquared * height1InMetersSquared;
            var bodyMassIndex = weight1 / height1InMetersSquared;
            Console.WriteLine(exampleName + "'s BMI is " + bodyMassIndex);

            //second person
            Console.WriteLine("What is your friend's name?");
            string name2 = Console.ReadLine();

            Console.WriteLine("What is their age?");
            int age2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("What is their weight in kg?");
            float weight2 = float.Parse(Console.ReadLine());


            Console.WriteLine("What is their height in cm?");
            float height2 = float.Parse(Console.ReadLine());


            Console.WriteLine(name2 + " is " + age2 + " years old, their weight is " + weight2 + " kg and their height is " + height2 + " cm.");

            float height2InMetersSquared = height2 / 100.0f;
            height2InMetersSquared = height2InMetersSquared * height2InMetersSquared;
            var bodyMassIndexDeux= weight2 / height2InMetersSquared;
            Console.WriteLine(name2 + "'s BMI is " + bodyMassIndex);


        }

    }
}
                
