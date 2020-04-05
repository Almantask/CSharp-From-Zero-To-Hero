using System;

namespace BootCamp.Chapter
{
    public class Demo
    {
        public Person person;

        public event EventHandler DemoStarted;

        public event EventHandler<PredicateEventArgs> PredicateChosen; 

        public event EventHandler DemoEnded;

        public event EventHandler ApplicationClosed;

        public void Run()
        {
            DemoStarted?.Invoke(this, EventArgs.Empty);
            ChoosePredicates(); 
            DemoEnded?.Invoke(this, EventArgs.Empty);
            ApplicationClosed?.Invoke(this, EventArgs.Empty);
        }

        protected static void ChoosePredicates()
        {
            var menuChoice = DisplayPredicateChoises();
            Program.OnPredicateChosen(null, new PredicateEventArgs(menuChoice));
        }

        private static string DisplayPredicateChoises()
        {
            Console.WriteLine($"Choose on the following fiters you want to use. {Environment.NewLine}");
            Console.WriteLine("1) Persons older then 18 which do not live in the UK and which surname does not contain the character a ");
            Console.WriteLine("2) Persons who are younger then 18 and who surname does not contain the character a");
            Console.WriteLine("3) Persons who do no live in the Uk and where both the name and surnmae contains the character a");
            var choice = Console.ReadLine();
            return choice;
        }
    }
}