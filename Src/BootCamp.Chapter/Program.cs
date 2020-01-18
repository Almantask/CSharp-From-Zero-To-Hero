using System;

namespace BootCamp.Chapter
{
    
    class Program
    {
        // public static is like a global variable.
        // It will be alive across the whole application lifetime.
        // This is private.
        static float weight = 75;

        static void Main(string[] args)
        {

            ColorfulConsole.Print("Every program will start with this.", ConsoleColor.Blue);
            ColorfulConsole.Print("This is a fun story.", ConsoleColor.Green);
            ColorfulConsole.Print("But it had to end now.", ConsoleColor.Red);
            Console.ReadLine();

            // Prints input
            var input = Console.ReadLine();
            Console.WriteLine(input);

            // Also prints input
            var input1 = Console.ReadLine();
            Console.WriteLine(input1);


            // prints 75
            Console.WriteLine("Weight before: " + weight);
            {
                weight = 100;
                float height = 1.619f;
                var bmi = weight / height / height;
            }

            // prints 100
            Console.WriteLine("Weight after: " + weight);
            
            // No value is returned, just a function returns to the calling context.
            //var result = Something();

            const float vatInLithuania = 0.25f;
            const float fridgePriceBeforeTaxes = 1010;
            var fridgePriceAfterTaxes =  CalculateAfterTaxes(fridgePriceBeforeTaxes, vatInLithuania);
        }

        private static float CalculateAfterTaxes(float priceBeforeTaxes, float vat)
        {
            var totalPrice = priceBeforeTaxes * (1 + vat);
            return totalPrice;
        }

        static void Something()
        {
            {
                float height = 1.619f;
                var bmi = weight / height / height;
            }
        }

        
    }
}
