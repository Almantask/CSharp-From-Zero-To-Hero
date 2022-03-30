using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName1;
            string surname1;
            int age1;
            float weight1;
            float height1;
            float bmi1;

            Console.Write("Please enter your first name: ");
            firstName1 = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            surname1 = Console.ReadLine();
            Console.Write("Welcome " + firstName1 + " " + surname1);

            Console.Write("Please enter your age: ");
            age1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter your weight (kg): ");
            weight1 = float.Parse(Console.ReadLine());

            Console.Write("Please enter your height (cm): ");
            height1 = float.Parse(Console.ReadLine());
            height1 = height1/100;

            bmi1 = weight1/(height1*height1);
            Console.WriteLine("Thank you " + firstName1 + " " + surname1 + " " + "Your BMI is: " + bmi1);

            Console.WriteLine("Press any key to restart");
            Console.ReadKey();

            string firstName2;
            string surname2;
            int age2;
            float weight2;
            float height2;
            float bmi2;

            Console.Write("Please enter your first name: ");
            firstName2 = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            surname2 = Console.ReadLine();
            Console.Write("Welcome " + firstName2 + " " + surname2);

            Console.Write("Please enter your age: ");
            age2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter your weight (kg): ");
            weight2 = float.Parse(Console.ReadLine());

            Console.Write("Please enter your height (cm): ");
            height2 = float.Parse(Console.ReadLine());
            height2 = height2/100;

            bmi2 = weight2/(height2*height2);
            Console.WriteLine("Thank you " + firstName2 + " " + surname2 + " " + "Your BMI is: " + bmi2);
            Console.WriteLine("Press any key to restart");
            Console.ReadKey();


            string firstName3;
            string surname3;
            int age3;
            float weight3;
            float height3;
            float bmi3;

            Console.Write("Please enter your first name: ");
            firstName3 = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            surname3 = Console.ReadLine();
            Console.Write("Welcome " + firstName3 + " " + surname3);

            Console.Write("Please enter your age: ");
            age3 = int.Parse(Console.ReadLine());

            Console.Write("Please enter your weight (kg): ");
            weight3 = float.Parse(Console.ReadLine());

            Console.Write("Please enter your height (cm): ");
            height3 = float.Parse(Console.ReadLine());
            height3 = height3/100;

            bmi3 = weight3/(height3*height3);
            Console.WriteLine("Thank you " + firstName3 + " " + surname3 + " " + "Your BMI is: " + bmi3);
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        
        }
    }
}
            
        }
    }
}
