using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{

    public class Demo
    {
        public event EventHandler OnKeyPressed;
        public event EventHandler OnDemoEnds;

        ContactsCenter contactsCenter = new ContactsCenter("./Input/MOCK_DATA.csv");

        private List<char> validChars = new List<char> { 'a', 'b', 'c', 'q' };
        public char currentChar;

        public Demo()
        {
            // TODO - Remove from constructor, create/,move to own class
            OnKeyPressed += RunDemoMenu;

            Console.WriteLine("Welcome! Please press space to start Demo.");
            
            do
            {
                GetKeyChar();
            } while (currentChar != ' ');

            OnKeyPressed?.Invoke(this, null);
        }

        private void RunDemoMenu(object sender, EventArgs eventArgs)
        {
            OnKeyPressed -= RunDemoMenu;
            OnKeyPressed += PrintPeopleWithFilter;

            Console.WriteLine("Demo started. Please choose filter or quit demo: ");

            PrintChoice();

            do
            {
                if (validChars.Contains(GetKeyChar()))
                {
                    OnKeyPressed?.Invoke(this, null);
                }
            } while (!currentChar.Equals('q'));

            OnKeyPressed -= PrintPeopleWithFilter;
        }

        private void PrintChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Press 'a' for people over 18, who do not live in UK, whose surename does not contain letter 'a'.");
            Console.WriteLine("Press 'b' for people under 18, who do not live in UK, whose surename does not contain letter 'a'.");
            Console.WriteLine("Press 'c' for people who do not live in UK, whose surename and name does not contain letter 'a'.");
            Console.WriteLine("Press 'q' to exit demo.");
            Console.WriteLine();
        }

        private char GetKeyChar()
        {
            currentChar = Console.ReadKey(true).KeyChar;
            return currentChar;
        }

        private void PrintPeopleWithFilter(object sender, EventArgs eventArgs)
        {
            var demoInstance = sender as Demo;
            
            switch (demoInstance.currentChar)
            {
                case 'a':
                    foreach (var person in contactsCenter.Filter(PeoplePredicates.IsA))
                    {
                        Console.WriteLine(person);
                    }

                    PrintChoice();
                    break;
                case 'b':
                    foreach (var person in contactsCenter.Filter(PeoplePredicates.IsB))
                    {
                        Console.WriteLine(person);
                    }

                    PrintChoice();
                    break;
                case 'c':
                    foreach (var person in contactsCenter.Filter(PeoplePredicates.IsC))
                    {
                        Console.WriteLine(person);
                    }

                    PrintChoice();
                    break;
                case 'q':
                    OnDemoEnds?.Invoke(this, null);
                    break;
                default:
                    break;
            }
        }
    }
}
