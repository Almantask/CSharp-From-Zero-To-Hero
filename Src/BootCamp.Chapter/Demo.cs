using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{

    public class Demo
    {
        Dictionary<string, ConsoleKey> consoleOptions = new Dictionary<string, ConsoleKey>();
        public event LogEventHandler logEventHandler;
        private ContactsCenter center;

        public Demo()
        {
            // Dont forget to add a case in ReadKey().
            consoleOptions.Add("Start", ConsoleKey.Enter);
            consoleOptions.Add("A", ConsoleKey.A);
            consoleOptions.Add("B", ConsoleKey.B);
            consoleOptions.Add("C", ConsoleKey.C);
            consoleOptions.Add("Close", ConsoleKey.Escape);
        }
        public void StartDemo()
        {
            ShowMainMenu(consoleOptions);
            ReadKeys(consoleOptions);
        }

        private void ShowMainMenu(Dictionary<string, ConsoleKey> consoleOptions)
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
                try
                {
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
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Dont Forget To start First!");
                    Console.ReadKey();
                }

                ShowMainMenu(consoleOptions);
            }
        }

        public void StartPressed()
        {
            Console.Clear();
            logEventHandler(this, new LoggerArgs { Message = "Demo Started" });
            center = new ContactsCenter(@"C:\Users\Max\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv");
            Console.ReadKey();
        }
        public void APressed()
        {
            Console.Clear();
            logEventHandler(this, new LoggerArgs { Message = "Demo A" });

            List<Person> persons = center.Filter(PeoplePredicates.IsA);

            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadKey();
        }
        public void BPressed()
        {
            Console.Clear();

            logEventHandler(this, new LoggerArgs { Message = "Demo B" });

            List<Person> persons = center.Filter(PeoplePredicates.IsB);
            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadKey();
        }
        public void CPressed()
        {
            Console.Clear();
            logEventHandler(this, new LoggerArgs { Message = "Demo C" });

            List<Person> persons = center.Filter(PeoplePredicates.IsB);

            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadKey();
        }
        public void EscapePressed()
        {
            Console.Clear();
            logEventHandler(this, new LoggerArgs { Message = "Demo Exit" });
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
