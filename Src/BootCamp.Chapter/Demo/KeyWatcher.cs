﻿using System;

namespace BootCamp.Chapter.Demo
{
    public static class KeyWatcher
    {
        public static void PressedKey(object sender, EventArgs e)
        {
            var key = sender as ConsoleKey?;

            switch (key)
            {
                case ConsoleKey.A:
                    ContactsDBGenerator.OnValidChoice(PeoplePredicates.IsA);
                    break;
                case ConsoleKey.B:
                    ContactsDBGenerator.OnValidChoice(PeoplePredicates.IsB);
                    break;
                case ConsoleKey.C:
                    ContactsDBGenerator.OnValidChoice(PeoplePredicates.IsC);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
