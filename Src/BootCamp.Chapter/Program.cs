using System;

namespace BootCamp.Chapter
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the data of the prisoner. \n");

            {
                Console.WriteLine("Prisoner Firstname: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Prisoner Lastname: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Prisoner Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Prisoner Weight in Kg: ");
                int weight = int.Parse(Console.ReadLine());

                Console.WriteLine("Prisoner Height in cm: ");
                int height = int.Parse(Console.ReadLine());

                Console.WriteLine("Prisoner Data: " + firstName + " " + lastName + " is " + age + "years old." +
                            " With a weight of " + weight + " Kg, with a height of " + height + " cm.");

                Double heightTu = height * .01;
                Double bodyMassIndex = weight / (heightTu * heightTu);

                Console.WriteLine("Prisoner BMI: " + bodyMassIndex + ".\n");

            }
            Console.WriteLine("Do it again: \n ");
            {
                Console.WriteLine("Prisoner Firstname: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Prisoner Lastname: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Prisoner Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Prisoner Weight in Kg: ");
                int weight = int.Parse(Console.ReadLine());

                Console.WriteLine("Prisoner Height in cm: ");
                int height = int.Parse(Console.ReadLine());

                Console.WriteLine("Prisoner Data: " + firstName + " " + lastName + " is " + age + "years old." +
                            " With a weight of " + weight + " Kg, with a height of " + height + " cm.");

                Double heightTu = height * .01;
                Double bodyMassIndex = weight / (heightTu * heightTu);

                Console.WriteLine("Prisoner BMI: " + bodyMassIndex + ".\n");
                Console.ReadLine();
            }


        }

        
}
}
