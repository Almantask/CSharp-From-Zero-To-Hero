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
            Console.CursorVisible = false;
            Console.WriteLine("Main menu");
            Console.WriteLine("Choose where you want to go: ");

            Console.WriteLine("(1) Conversion =>");
            Console.WriteLine("(2) Play with WASD arrows.");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                ConsoleKey pressedKey = Console.ReadKey(true).Key;
                if (pressedKey == ConsoleKey.D1 || pressedKey == ConsoleKey.NumPad1)
                {
                    ConversionMenu();
                    break;
                }
                if (pressedKey == ConsoleKey.D2 || pressedKey == ConsoleKey.NumPad2)
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
        }

        private static void ConversionMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversions");
            Console.WriteLine("Select conversion type: ");
            Console.WriteLine("(1) Convert Decimal to Binary");
            Console.WriteLine("(2) Convert Binary to Decimal");

            var pressedKey = Console.ReadKey(true).Key;
            while (pressedKey != ConsoleKey.Escape)
            {
                if (pressedKey == ConsoleKey.D1 || pressedKey == ConsoleKey.NumPad1)
                {
                    DecToBinOption();
                    break;
                }
                if (pressedKey == ConsoleKey.D2 || pressedKey == ConsoleKey.NumPad2)
                {
                    BinToDecOption();
                    break;
                }
                return;
            }
        }

        private static void DecToBinOption()
        {
            Console.CursorVisible = true;
            Console.Write("Enter a number: ");

            string input = Console.ReadLine();
            var pressedKey = Console.ReadKey(true).Key;
            while (!string.IsNullOrEmpty(input) && pressedKey != ConsoleKey.Escape)
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

                return;
            }
        }

        private static void BinToDecOption()
        {
            Console.CursorVisible = true;
            Console.Write("Enter a binary number: ");
            string input = Console.ReadLine();
            var pressedKey = Console.ReadKey(true).Key;
            while (!string.IsNullOrEmpty(input) && pressedKey != ConsoleKey.Escape)
            {
                if (IsBinary(input))
                {
                    Console.WriteLine($"Converted from binary to decimal result: {ConvertBinToDec(input)}");
                    BinToDecOption();
                }
                else
                {
                    Console.WriteLine("Not a valid binary number!");
                    BinToDecOption();
                }

                return;
            }
        }

        private static string ConvertDecToBin(int input)
        {
            if (IsNumber(input.ToString()))
            {
                string output = Convert.ToString(input, 2);
                return output;
            }
            return default;
        }

        private static decimal ConvertBinToDec(string input)
        {
            if (IsBinary(input))
            {
                decimal value = Convert.ToInt64(input, 2);
                return value;
            }
            return default;
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