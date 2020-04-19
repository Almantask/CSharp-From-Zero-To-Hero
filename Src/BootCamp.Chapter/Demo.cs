using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    
    public class Demo
    {
        //TODO mo this using events-based user input.
        //Display controls, handle input presses for for the following events:
        //a) DemoStarted
        //b) Example selected(from 2) a, b, c)
        //c) DemoEnded
        //d) Application closed
        Dictionary<string, ConsoleKey> consoleOptions = new Dictionary<string, ConsoleKey>();
        public event LogEventHandler logger;

        public Demo()
        {
            consoleOptions.Add("Start", ConsoleKey.Enter);
            consoleOptions.Add("A", ConsoleKey.A);
            consoleOptions.Add("B", ConsoleKey.B);
            consoleOptions.Add("C", ConsoleKey.C);
            consoleOptions.Add("Close", ConsoleKey.Escape);
        }
        public void StartDemo()
        {
            logger(this, new LoggerArgs { Message = "Demo Started" });
            MainMenu(consoleOptions);
            ReadKeys(consoleOptions);
        }

        private void MainMenu(Dictionary<string, ConsoleKey> consoleOptions)
        {

            Console.Clear();
            foreach (var option in consoleOptions)
            {
                System.Console.WriteLine($"For {option.Key} press {option.Value}");
            }
        }

        private void ReadKeys(Dictionary<string, ConsoleKey> consoleOptions)
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

        public void StartPressed()
        {
            Console.Clear();
            logger(this, new LoggerArgs { Message = "Demo Started" });
            Console.ReadKey();
        }
        public void APressed()
        {
            Console.Clear();
            logger(this, new LoggerArgs { Message = "Demo A" });
            Console.ReadKey();
        }
        public void BPressed()
        {
            Console.Clear();
            logger(this, new LoggerArgs { Message = "Demo B" });
            Console.ReadKey();
        }
        public void CPressed()
        {
            Console.Clear();
            logger(this, new LoggerArgs { Message = "Demo C" });
            Console.ReadKey();
        }
        public void EscapePressed()
        {
            Console.Clear();
            logger(this, new LoggerArgs { Message = "Demo Exit" });
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
