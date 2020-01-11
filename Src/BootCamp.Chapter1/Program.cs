// Ignore using System; for now
using System;

// Ignore namespace BootCamp.Chapter1 for now
namespace BootCamp.Chapter1
{
    // Ignore class Program for now.
    class Program
    {
        // In C# comments are with "//"
        /*
         This is a multiline comment. It start with 
         "/*" and ends with "* /" (no space) 
        */
        // Comments are just text which will taken as an instruction, thus will be skipped.
        // Running with VS menu will put application in debug mode.
        // Running with "ctrl + F5" will put it in release mode.

        // Every function has some entry point.
        // Starting (entry) point of a console application is Main.
        // Write code below, within Main.
        static void Main(string[] args)
        {
            // PascalCase (first letter is capital and all other words start with capital letter)
            // camelCase (first letter is non-capital and all other words start with capital letter)

            // for variable names we can use: [aA-zZ], [0-9], _

            // whole numbers:
            // 32 bit
            int myAge = 25;

            // 64 bit
            long lightyears = 9999999999999999;

            // numbers with a fraction:
            // floats are fast, 32 bit
            float weight = 80.5f;
            float height = 201.1f;

            // double precision compared:
            // doubles are slower, 64 bit
            // double is a default number type with fraction
            double number6 = 2.5;

            // decimal is explicitly used for money and scientific calculations
            // (decimal) means that from double to decimal
            // 128 bit
            decimal money = (decimal)10000000000000000000000.156465465465465464654654654654654654654654;

            // string is used to store text:
            // double quotes ("")
            string myName = "Kaisinel";

            // char is used for storing a single symbol
            // single quotes ('')
            char firstLetter = 'K';

            // for binary types (logical- true or false) we use boolean.
            bool isItFirstLesson = true;
            bool isItLastLesson = false;

            // var can be used as an alternative to define a variable with a type.
            var variablesDone = "Variables done";
            var timeNow = 10;
            // doesn't work -var unknown;
            Console.WriteLine(myName);

            // We can add any two nubmers together
            int sum = 1 + 5; // 6
            int sumx2 = sum + sum; // 12
            sumx2 = sumx2 * 2; // 24
            var sumMoreFloat = sumx2 + 2.0f;
            var sumMoreDecimal = (decimal)sumMoreFloat + (decimal)1.000001;
            Console.WriteLine(sumMoreDecimal);

            // We can add string and other primitives to a string and so they all become string:
            var greetings = "Hello world!";
            var fullGreeting = myName + ", " + greetings;
            var fullGreetingTimes = fullGreeting + 1;
            Console.WriteLine(fullGreetingTimes);

            var a = 'a';
            // char + string = string
            // (int)char = ascii 
            Console.WriteLine(a + " is " + (int)a);
            var b = 'b';
            Console.WriteLine(b + " is " + (int)b);
            // char + char = int
            var aAndB = a + b;
            Console.WriteLine("a + b =" + aAndB);
            Console.WriteLine("What symbol goes after 'Z' in ascii?");
            // char + int = int
            var afterZ = Convert.ToChar('Z' + 1);
            Console.WriteLine("Answer: " + afterZ);

            // we cannot substract string
            // how many letters in alphabet: 
            Console.WriteLine("Letters in alphabet: " + ('z' - 'a') + 1);

            // you can only multiply and divide number
            // dividing an integer from an integer ignores a fraction part.
            var divisionResult = 1 / 100;
            Console.WriteLine(divisionResult);
            // dividing an integer from a number with a fraction keeps a fraction part.
            var divisionResultFraction = 1 / 100.0;
            Console.WriteLine(divisionResultFraction);
            var hundred = 100;
            var hundredHundreds = hundred * 100.0f;
            Console.WriteLine(hundredHundreds);

            // Values that don't change, should be used as a constant.
            const double pi = 3.1415926535;

            Console.Write("Input your name: ");
            // Read line of text from console.
            string name = Console.ReadLine();
            Console.WriteLine("Hello again, " + name);
        }
    }
}
