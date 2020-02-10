using System;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main menu");
            Console.WriteLine("(1) Conversion =>");
            Console.WriteLine("(2) Play with WASD arrows.");

            string response;
            Console.Write("Choose where you want to go: ");

            while (!string.IsNullOrEmpty(response = Console.ReadLine()))
            {
                if (response == "1")
                {
                    ConversionMenu();
                    break;
                }
                if (response == "2")
                {
                    PlayWithArrows();
                    break;
                }
            }
            MainMenu();
        }

        private static void PlayWithArrows()
        {
            const char arrowUp = '\u21a5';
            const char arrowDown = '\u21a7';
            const char arrowLeft = '\u21a4';
            const char arrowRight = '\u21a6';

            Console.Clear();
            Console.WriteLine("Play with WASD keys");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                ConsoleKey pressedKey = Console.ReadKey(true).Key; // giving ReadKey argument to not show key press echo

                if (pressedKey == ConsoleKey.W)
                {
                    Console.Write(arrowUp);
                }
                if (pressedKey == ConsoleKey.S)
                {
                    Console.Write(arrowDown);
                }
                if (pressedKey == ConsoleKey.A)
                {
                    Console.Write(arrowLeft);
                }
                if (pressedKey == ConsoleKey.D)
                {
                    Console.Write(arrowRight);
                }
            }
            MainMenu();
        }

        private static void ConversionMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversions:");
            Console.WriteLine("(1) Convert Decimal to Binary");
            Console.WriteLine("(2) Convert Binary to Decimal");
            Console.Write("Select conversion type: ");

            string response;
            while (!string.IsNullOrEmpty(response = Console.ReadLine()))
            {
                if (response == "1")
                {
                    DecToBinOption();
                    break;
                }
                if (response == "2")
                {
                    BinToDecOption();
                    break;
                }
                ConversionMenu();
            }
        }

        private static void DecToBinOption()
        {
            Console.WriteLine("You selected Decimal to Binary!");
            Console.Write("Enter a number: ");
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                if (IsNumber(input))
                {
                    int dec = StringToInt(input);
                    Console.WriteLine($"Converted from decimal to binary result: {ConvertDecToBin(dec)}");
                    DecToBinOption();
                }
                else
                {
                    Console.WriteLine("Not a valid binary number!");
                    DecToBinOption();
                }
            }

            DecToBinOption();
        }

        private static void BinToDecOption()
        {
            Console.Write("Enter a binary number: ");
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                if (IsBinary(input))
                {
                    Console.WriteLine($"Converted to decimal result: {ConvertBinToDec(input)}");
                    BinToDecOption();
                }
                else
                {
                    Console.WriteLine("Not a valid binary number!");
                    BinToDecOption();
                }
            }

            BinToDecOption();
        }

        private static string ConvertDecToBin(int input)
        {
            string output;

            if (IsNumber(input.ToString()))
            {
                output = Convert.ToString(input, 2);
                return output;
            }
            throw new Exception("Not a valid number");
        }

        private static decimal ConvertBinToDec(string input)
        {
            decimal value;
            if (IsBinary(input))
            {
                value = Convert.ToInt64(input, 2);
                return value;
            }

            throw new Exception("Not a valid binary number");
        }

        private static int StringToInt(string input)
        {
            int.TryParse(input, out int value);
            return value;
        }

        private static bool IsNumber(string input)
        {
            if (int.TryParse(input, out _))
            {
                return true;
            }

            return false;
        }

        private static bool IsBinary(string input)
        {
            foreach (var character in input)
            {
                if (character != '0' && character != '1')
                {
                    return false;
                }
            }

            return true;
        }
    }
}