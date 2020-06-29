using BootCamp.Chapter.Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Events
{
    public static class InputEvents
    {
        public static void OnInputPressed(object sender, EventArgs e)
        {
            var key = sender as ConsoleKey?;

            switch (key)
            {
                case ConsoleKey.A:
                    ContactsCentreInitializer.Initialize(PeoplePredicates.IsA);
                    break;
                case ConsoleKey.B:
                    ContactsCentreInitializer.Initialize(PeoplePredicates.IsB);
                    break;
                case ConsoleKey.C:
                    ContactsCentreInitializer.Initialize(PeoplePredicates.IsC);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
