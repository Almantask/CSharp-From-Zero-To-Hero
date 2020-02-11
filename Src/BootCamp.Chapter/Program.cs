using System;
using System.Text;
using System.Threading;

namespace BootCamp.Chapter
{
    /// <summary>
    /// I decided to treat this like a very small game and created
    /// a menu for the requirements I had to cover.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// In introduced Thread.Sleep() to help with program functionality
        /// </summary>
        private const int displayTimeout = 3000;

        // stored Unicode character codes in constants
        private const char arrowUp = '\u21a5';

        private const char arrowDown = '\u21a7';
        private const char arrowLeft = '\u21a4';
        private const char arrowRight = '\u21a6';

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MainMenu();
        }

        private static void MainMenu()
        {
            // hide typing cursor and clear previous screen
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("Main Menu");
            Console.WriteLine("  (1) Conversion =>");
            Console.WriteLine("  (2) Play with WASD arrows.");
            Console.WriteLine("(Esc) Quit!");

            while (true)
            {
                ConsoleKey pressedKey = Console.ReadKey(true).Key;
                if (pressedKey == ConsoleKey.Escape)
                {
                    Console.WriteLine("Escape key pressed! Program terminated.");
                    Environment.Exit(0);
                }
                if (pressedKey == ConsoleKey.D1 || pressedKey == ConsoleKey.NumPad1)
                {
                    ConversionMenuOption();
                    break;
                }
                if (pressedKey == ConsoleKey.D2 || pressedKey == ConsoleKey.NumPad2)
                {
                    PlayWithArrowsOption();
                    break;
                }
            }
        }

        /// <summary>
        /// This method covers part 2 of the homework
        /// </summary>
        private static void PlayWithArrowsOption()
        {
            Console.CursorVisible = false;
            Console.Clear();

            Console.WriteLine("(Esc) Back to Main Menu!");
            Console.WriteLine("Press WASD to play");
            // if W, A, S, D is pressed will print corresponding character on screen
            // until Escape is pressed then will return the user to the main menu
            while (true)
            {
                ConsoleKey pressedKey = Console.ReadKey(true).Key;

                if (pressedKey == ConsoleKey.Escape)
                {
                    MainMenu();
                }

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

        /// <summary>
        /// Creates sub-menu for Decimal to Binary conversion
        /// </summary>
        private static void ConversionMenuOption()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine("Conversions");
            Console.WriteLine("  (1) Conversion =>");
            Console.WriteLine("  (2) Play with WASD arrows.");
            Console.WriteLine("(Esc) Back to Main Menu!");

            while (true)
            {
                ConsoleKey pressedKey = Console.ReadKey(true).Key;

                if (pressedKey == ConsoleKey.Escape)
                {
                    MainMenu();
                }
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
            }
        }

        /// <summary>
        /// Creates sub-menu for Decimal to Binary conversion
        /// </summary>
        private static void DecToBinOption()
        {
            Console.CursorVisible = true;
            Console.Write("Enter integer number: ");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Null or Empty string not allowed!");
                    Thread.Sleep(displayTimeout);
                    ConversionMenuOption();
                }

                if (IsNumber(input))
                {
                    int dec = StringToInt(input);
                    Console.WriteLine($"Converted from decimal to binary result: {ConvertDecToBin(dec)}");
                    Thread.Sleep(displayTimeout);
                    ConversionMenuOption();
                }
                else
                {
                    Console.WriteLine("Not a valid integer number!");
                    Thread.Sleep(displayTimeout);
                    ConversionMenuOption();
                }
            }
        }

        /// <summary>
        /// Creates sub-menu for Binary to Decimal conversion
        /// </summary>
        private static void BinToDecOption()
        {
            Console.CursorVisible = true;
            Console.Write("Enter a binary number: ");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Null or Empty string not allowed!");
                    Thread.Sleep(displayTimeout);
                    ConversionMenuOption();
                }
                if (IsBinary(input))
                {
                    Console.WriteLine($"Converted from binary to decimal result: {ConvertBinToDec(input)}");
                    Thread.Sleep(displayTimeout);
                    ConversionMenuOption();
                }
                else
                {
                    Console.WriteLine("Not a valid binary number!");
                    Thread.Sleep(displayTimeout);
                    ConversionMenuOption();
                }
            }
        }

        /// <summary>
        /// Convert string from base 10 to base 2
        /// </summary>
        private static string ConvertDecToBin(int input)
        {
            if (IsNumber(input.ToString()))
            {
                string output = Convert.ToString(input, 2);
                return output;
            }
            return default;
        }

        /// <summary>
        /// Convert string from base 2 to base 10
        /// </summary>
        private static decimal ConvertBinToDec(string input)
        {
            if (IsBinary(input))
            {
                decimal value = Convert.ToInt64(input, 2);
                return value;
            }
            return default;
        }

        /// <summary>
        /// Helper method to convert string to integer
        /// </summary>
        private static int StringToInt(string input)
        {
            int.TryParse(input, out int value);
            return value;
        }

        /// <summary>
        /// Helper method to determine if a string is a number
        /// </summary>
        private static bool IsNumber(string input)
        {
            return int.TryParse(input, out _);
        }

        /// <summary>
        /// Helper method to determine if a string is in binary format
        /// </summary>
        private static bool IsBinary(string input)
        {
            //treat binary as a char array of one and zero.
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