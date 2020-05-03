﻿using System;

namespace BootCamp.Chapter.Demo
{
    public class KeyWatcher
    {
        public static void PressedKey(object sender, EventArgs e)
        {
            var key = sender as ConsoleKey?;

            switch (key)
            {
                case ConsoleKey.A:
                    DemoCreateDB.OnValidChoice(PeoplePredicates.IsA);
                    break;
                case ConsoleKey.B:
                    DemoCreateDB.OnValidChoice(PeoplePredicates.IsB);
                    break;
                case ConsoleKey.C:
                    DemoCreateDB.OnValidChoice(PeoplePredicates.IsC);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}