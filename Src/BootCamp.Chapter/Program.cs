using System;
using System.Collections.Generic;
using System.Threading;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            MainMenu();

        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome! Choose one option");

            var options = new List<string>
            {
                "Exit",                         // [0]
                "Example of movement keys",     // [1]
                "Convert binary to integer",    // [2]
                "Convert integer to binary"     // [3]
            };
            for (var i = 1; i < options.Count; i++) Console.WriteLine($"{i}. {options[i]}");
            Console.WriteLine($"{0}. {options[0]}");

            while (true)
            {
                var selected = Console.ReadKey().KeyChar;
                switch (selected)
                {
                    case '1':
                        Console.Clear();
                        MoveKeys();
                        break;
                    case '2':
                        Console.Clear();
                        ConvertToInteger();
                        break;
                    case '3':
                        Console.Clear();
                        ConvertToBinary();
                        break;
                    case '0':
                        ClearLine();
                        Console.Write("\nGoodbye");
                        Thread.Sleep(800);
                        System.Environment.Exit(1);
                        break;
                    default:
                        ClearLine();
                        Console.Write($"\nInvalid option, try again:{Environment.NewLine}");
                        Thread.Sleep(800);
                        ClearLine();
                        break;
                }
            }   
        }

        private static void ConvertToBinary()
        {
            const string text = "Convert [integer => binary].\nEnter your number:";
            Console.WriteLine(text);
            long.TryParse(Console.ReadLine(), out var number);
            var bin = BinaryConverter.ToBinary(number);
            Console.WriteLine(bin);

            PressAnyKeyToContinue();
        }
        
        private static void ConvertToInteger()
        {
            const string text = "Convert [binary => integer].\nEnter your binary:";
            Console.WriteLine(text);
            var bin = BinaryConverter.ToInteger(Console.ReadLine());
            Console.WriteLine(bin);

            PressAnyKeyToContinue();
        }

        
        private static void MoveKeys()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;

            const string text = "Hello!! Press \"w\", \"a\", \"s\" or \"d\" to move (\"0\" to exit).";
            Console.WriteLine(text);

            while (true)
            {
                var key = Console.ReadKey(true).KeyChar;
                if (key == '0') break;
                Console.WriteLine(ArrowMovement.GetIndicator(key));
                ClearLine();
            }

            PressAnyKeyToContinue();
        }

        private static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            MainMenu();
        }

        private static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
