using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows;
using System.Collections;

namespace BootCamp.Chapter
{

    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
                3) Demo this using events-based user input.  
                Display controls, handle input presses for for the following events:  
                a) DemoStarted  
                b) Example selected (from 2) a, b, c)  
                c) DemoEnded  
                d) Application closed
             * 
             */

            AppEventHandler appEvent = new AppEventHandler();
            appEvent.AppRunning += AppEvent_AppRunning;
            appEvent.aOptionRunning += AppEvent_OptionRunning;
            appEvent.bOptionRunning += AppEvent_OptionRunning;
            appEvent.cOptionRunning += AppEvent_OptionRunning;
            
            appEvent.DemoStart();

            Console.WriteLine("Choose an option:");
            Console.WriteLine("a) over 18, who do not live in UK, whose surename does not contain letter 'a'.");
            Console.WriteLine("b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.");
            Console.WriteLine("c) who do not live in UK, whose surename and name does not contain letter 'a'.");

            bool isRunning = false;

            ContactsCenter contacts = new ContactsCenter(@"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv");

            do
            {
                Console.WriteLine("Type in a, b or c");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "a":
                        appEvent.SelectedAOption();
                        Predicate<Person> predicateIsA = new Predicate<Person>(PeoplePredicates.IsA);
                        List<Person> aList = contacts.Filter(predicateIsA);
                        foreach (Person p in aList)
                        {
                            Console.WriteLine($"{p.Name} {p.Surname} {p.Age} {p.Country}");
                        }

                        Console.WriteLine("Quit app? Y/N");
                        string input = Console.ReadLine();
                        string inputFix = input.ToUpperInvariant();

                        if(inputFix.Equals("Y"))
                        {
                            isRunning = false;
                            appEvent.DemoEnded();
                            appEvent.ProgramEnd += AppEvent_ProgramEnd;
                        }
                        else
                        {
                            isRunning = true;
                        }
                        break;

                    case "b":
                        appEvent.SelectedBOption();
                        Predicate<Person> predicateIsB = new Predicate<Person>(PeoplePredicates.IsB);
                        List<Person> bList = contacts.Filter(predicateIsB);
                        foreach (Person p in bList)
                        {
                            Console.WriteLine($"{p.Name} {p.Surname} {p.Age} {p.Country}");
                        }

                        Console.WriteLine("Quit app? Y/N");
                        string bInput = Console.ReadLine();
                        string bInputFix = bInput.ToUpperInvariant();

                        if (bInputFix.Equals("Y"))
                        {
                            isRunning = false;
                            appEvent.DemoEnded();
                            appEvent.ProgramEnd += AppEvent_ProgramEnd;
                        }
                        else
                        {
                            isRunning = true;
                        }
                        break;

                    case "c":
                        appEvent.SelectedCOption();
                        Predicate<Person> predicateIsC = new Predicate<Person>(PeoplePredicates.IsC);
                        List<Person> cList = contacts.Filter(predicateIsC);
                        foreach (Person p in cList)
                        {
                            Console.WriteLine($"{p.Name} {p.Surname} {p.Age} {p.Country}");
                        }

                        Console.WriteLine("Quit app? Y/N");
                        string cInput = Console.ReadLine();
                        string cInputFix = cInput.ToUpperInvariant();

                        if (cInputFix.Equals("Y"))
                        {
                            isRunning = false;
                            appEvent.DemoEnded();
                            appEvent.ProgramEnd += AppEvent_ProgramEnd;
                        }
                        else
                        {
                            isRunning = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Wrong input, please choose between a, b or c");
                        isRunning = true;
                        break;
                }

            } while (isRunning);

            
            appEvent.AppRunning -= AppEvent_AppRunning;
            appEvent.aOptionRunning -= AppEvent_OptionRunning;
            appEvent.bOptionRunning -= AppEvent_OptionRunning;
            appEvent.cOptionRunning -= AppEvent_OptionRunning;
            Console.ReadKey();
            appEvent.MyProgramEnd();
            appEvent.ProgramEnd -= AppEvent_ProgramEnd;
        }

        private static void AppEvent_ProgramEnd(object sender, AppRunningEventArgs e)
        {
            var progEvent = sender as AppEventHandler;
            Console.WriteLine($"{e.TimeOfEvent} {e.Message}");
        }

        private static void AppEvent_OptionRunning(object sender, AppRunningEventArgs e)
        {
            var progEvent = sender as AppEventHandler;
            Console.WriteLine($"{e.Message}");
        }

        private static void AppEvent_AppRunning(object sender, AppRunningEventArgs e)
        {
            var progEvent = sender as AppEventHandler;
            Console.WriteLine($"{e.TimeOfEvent} {e.Message}");
        }

        public static void MyTests()
        {

            Person p = new Person("Pete", "R", "05/06/1992", "male", "Poland", "mail@mail.com", "some address");

            if (p.Gender == Gender.male)
            {
                Console.WriteLine($"{p.Name} is male");
            }

            ContactsCenter contacts = new ContactsCenter(@"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv");

            Predicate<Person> predicateIsA = new Predicate<Person>(PeoplePredicates.IsA);
            List<Person> aList = contacts.Filter(predicateIsA);

            Predicate<Person> predicateIsB = new Predicate<Person>(PeoplePredicates.IsB);
            List<Person> bList = contacts.Filter(predicateIsB);

            Predicate<Person> predicateIsC = new Predicate<Person>(PeoplePredicates.IsC);
            List<Person> cList = contacts.Filter(predicateIsC);

            // a, b, c zwraca wartosc, zaimplementowac to nowym switch i dodac events
        }
    }

    public class AppEventHandler
    {
        public event EventHandler<AppRunningEventArgs> AppRunning;
        public event EventHandler<AppRunningEventArgs> ProgramEnd;
        public event EventHandler<AppRunningEventArgs> aOptionRunning;
        public event EventHandler<AppRunningEventArgs> bOptionRunning;
        public event EventHandler<AppRunningEventArgs> cOptionRunning;

        public void DemoStart()
        {
            Console.WriteLine("#####################################");
            AppRunning?.Invoke(this, new AppRunningEventArgs(DateTime.Now, "Demo started"));
            Console.WriteLine("#####################################");
            Console.WriteLine("");
        }

        public void DemoEnded()
        {
            Console.WriteLine("");
            Console.WriteLine("#####################################");
            AppRunning?.Invoke(this, new AppRunningEventArgs(DateTime.Now, "Demo ended"));
            Console.WriteLine("#####################################");
        }

        public void MyProgramEnd()
        {
            Console.WriteLine("");
            Console.WriteLine("#####################################");
            ProgramEnd?.Invoke(this, new AppRunningEventArgs(DateTime.Now, "End of program"));
            Console.WriteLine("#####################################");
        }

        public void SelectedAOption()
        {
            Console.WriteLine("");
            Console.WriteLine("#####################################");
            aOptionRunning?.Invoke(this, new AppRunningEventArgs(DateTime.Now, "A option selected"));
            Console.WriteLine("#####################################");
            Console.WriteLine("");
        }

        public void SelectedBOption()
        {
            Console.WriteLine("");
            Console.WriteLine("#####################################");
            bOptionRunning?.Invoke(this, new AppRunningEventArgs(DateTime.Now, "B option selected"));
            Console.WriteLine("#####################################");
            Console.WriteLine("");
        }

        public void SelectedCOption()
        {
            Console.WriteLine("");
            Console.WriteLine("#####################################");
            cOptionRunning?.Invoke(this, new AppRunningEventArgs(DateTime.Now, "C option selected"));
            Console.WriteLine("#####################################");
            Console.WriteLine("");
        }
    }    
} 



