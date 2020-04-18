using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    
    public static class Demo
    {
        //TODO mo this using events-based user input.
        //Display controls, handle input presses for for the following events:
        //a) DemoStarted
        //b) Example selected(from 2) a, b, c)
        //c) DemoEnded
        //d) Application closed
        public static void StartDemo()
        {
            Dictionary<string, ConsoleKey> consoleOptions = new Dictionary<string, ConsoleKey>();
            consoleOptions.Add("Start", ConsoleKey.Enter);
            consoleOptions.Add("A", ConsoleKey.A);
            consoleOptions.Add("B", ConsoleKey.B);
            consoleOptions.Add("C", ConsoleKey.C);
            consoleOptions.Add("Close", ConsoleKey.Escape);

            MainMenu(consoleOptions);
            ReadKeys(consoleOptions);
        }

        private static void MainMenu(Dictionary<string, ConsoleKey> consoleOptions)
        {

            Console.Clear();
            foreach (var option in consoleOptions)
            {
                System.Console.WriteLine($"For {option.Key} press {option.Value}");
            }
        }

        private static void ReadKeys(Dictionary<string, ConsoleKey> consoleOptions)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            while (!Console.KeyAvailable && key.Key != ConsoleKey.Escape)
            {

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        StartPressed();
                        break;
                    case ConsoleKey.A:
                        APressed();
                        break;
                    case ConsoleKey.B:
                        BPressed();
                        break;
                    case ConsoleKey.C:
                        CPressed();
                        break;
                    case ConsoleKey.Escape:
                        EscapePressed();
                        break;
                }
                MainMenu(consoleOptions);
            }
        }

        public static void StartPressed()
        {
            Console.Clear();
            Console.WriteLine("Enter");
            Console.ReadKey();
        }
        public static void APressed()
        {
            Console.Clear();
            Console.WriteLine("A");
            Console.ReadKey();
        }
        public static void BPressed()
        {
            Console.Clear();
            Console.WriteLine("B");
            Console.ReadKey();
        }
        public static void CPressed()
        {
            Console.Clear();
            Console.WriteLine("C");
            Console.ReadKey();
        }
        public static void EscapePressed()
        {
            Console.Clear();
            Console.WriteLine("Escape");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
