using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{

    public class Demo
    {
        public event EventHandler OnKeyPressed;

        private List<char> validChars = new List<char> { 'a', 'b', 'c', 'q' };

        ContactsCenter contactsCenter = new ContactsCenter("./Input/MOCK_DATA.csv");

        public char currentChar;

        private bool _demoRunning = false;

        public bool DemoRunning
        {
            get { return _demoRunning; }
            set
            {
                if (_demoRunning != value)
                {
                    _demoRunning = value;
                    Console.WriteLine(_demoRunning == true ? "Demo started." : "Demo Ended.");
                }
            }
        }

        public Demo()
        {
            StartDemo();
        }

        private void StartDemo()
        {
            PrintMenuChoice();

            OnKeyPressed += RunDemoMenu;

            do
            {
                if (GetKeyChar() == ' ')
                {
                    DemoRunning = true;
                    OnKeyPressed?.Invoke(this, null);
                }
            } while (DemoRunning);
        }

        private void RunDemoMenu(object sender, EventArgs eventArgs)
        {
            OnKeyPressed -= RunDemoMenu;
            OnKeyPressed += ChoosePeopleFilter;

            PrintMenuChoice();

            do
            {
                if (validChars.Contains(GetKeyChar()))
                {
                    OnKeyPressed?.Invoke(this, null);
                }
            } while (!currentChar.Equals('q'));

            OnKeyPressed -= ChoosePeopleFilter;
        }

        private void PrintMenuChoice()
        {
            if (DemoRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Press 'a' for people over 18, who do not live in UK, whose surename does not contain letter 'a'.");
                Console.WriteLine("Press 'b' for people under 18, who do not live in UK, whose surename does not contain letter 'a'.");
                Console.WriteLine("Press 'c' for people who do not live in UK, whose surename and name does not contain letter 'a'.");
                Console.WriteLine("Press 'q' to exit demo.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Start demo with pressing space or any other key to quit program.");
            }
        }

        private char GetKeyChar()
        {
            currentChar = Console.ReadKey(true).KeyChar;
            return currentChar;
        }

        private void ChoosePeopleFilter(object sender, EventArgs eventArgs)
        {
            var demoInstance = sender as Demo;
            
            switch (demoInstance.currentChar)
            {
                case 'a':
                    PrintPeople(PeoplePredicates.IsA);
                    break;
                case 'b':
                    PrintPeople(PeoplePredicates.IsB);
                    break;
                case 'c':
                    PrintPeople(PeoplePredicates.IsC);
                    break;
                case 'q':
                    DemoRunning = false;
                    break;
                default:
                    break;
            }
        }

        private void PrintPeople(Predicate<Person> predicate)
        {
            foreach (var person in contactsCenter.Filter(predicate))
            {
                Console.WriteLine(person);
            }

            PrintMenuChoice();
        }
    }
}
