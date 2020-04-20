using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Menu
    {
        public event LogEventHandler OnMenuKeyPressed;
        private ContactsCenter center;

        public void Start(Dictionary<string, ConsoleKey> consoleOptions)
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
                catch( Exception e )
                {
                    Console.Clear();
                    Console.WriteLine("Dont Forget To start First!");
                    Console.WriteLine(e.ToString());
                    Console.ReadKey();
                }

                ShowMainMenu(consoleOptions);
            }
        }

        public void StartPressed()
        {
            Console.Clear();
            OnMenuKeyPressed(this, new LoggerArgs { Message = "Demo Started" });
            center = new ContactsCenter(@"C:\Users\Max\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv");
            Console.ReadKey();
        }
        public void APressed()
        {
            Console.Clear();
            OnMenuKeyPressed(this, new LoggerArgs { Message = "Demo A" });

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
            OnMenuKeyPressed(this, new LoggerArgs { Message = "Demo B" });

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
            OnMenuKeyPressed(this, new LoggerArgs { Message = "Demo C" });

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
            OnMenuKeyPressed(this, new LoggerArgs { Message = "Demo Exit" });
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
