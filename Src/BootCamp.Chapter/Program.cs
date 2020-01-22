using System;

namespace BootCamp.Chapter
{
    class Program
    {

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var age = ParseAge(input);

            string ageValue;
            if (age == -1)
            {
                ageValue = "invalid";
            }
            else
            {
                ageValue = age.ToString();
            }

            Console.WriteLine("Age is " + ageValue);

            // && and not &
            // Prints check1
            if (Check1() && Check2())
            {
                //..
            }

            Console.WriteLine("------------");

            // Prints check1 and check2
            if (Check1() & Check2())
            {
                // ..
            }

            bool result = true;
            result = !result;
            Console.WriteLine(result);

        }

        static bool Check1()
        {
            Console.WriteLine("Check1");
            return false;
        }

        static bool Check2()
        {
            Console.WriteLine("Check2");
            return true;
        }

    static int ParseAge(string input)
        {
            var isNumber = int.TryParse(input, out var age);
            
            // If you can, terminate function early.
            // for a single line of code brackets are optional.
            if (!isNumber) return -1;
            bool isValidAge = age < 200 && age >= 0;
            if (!isValidAge) return -1;

            return age;
        }
    }
}
