using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            var doAnotherPerson = true;
            while (doAnotherPerson)
            {
                Console.Write("First name:");
                var firstName = Console.ReadLine();
                Console.Write("Surname:");
                var surname = Console.ReadLine();
                Console.Write("Age:");
                //If need to, age can be converted to int.
                //As it is not used as int anywhere, for now leaving it as a string.
                var age = Console.ReadLine();
                Console.Write("Weight:");
                var weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Height:");
                var height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(firstName + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
                var heightInMeters = height / 100;
                var bmi = (weight / heightInMeters) / heightInMeters;
                Console.WriteLine("Body-mass index (BMI) is: " + String.Format("{0:F2}", bmi));

                Console.Write("\nDo you want to check BMI for another person? y/n: ");
                var answer = Console.ReadLine().ToLowerInvariant();
                doAnotherPerson = answer.Equals("y") || answer.Equals("yes");
            }

        }
    }
}
