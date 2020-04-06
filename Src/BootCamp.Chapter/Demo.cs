﻿using MenuLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Demo
    {
        private static readonly ContactsCenter contactsCenter = new ContactsCenter("Input/MOCK_DATA.csv");
        private static readonly Menu menu = new Menu("Main menu", PopulateMainMenu());

        public static void Run()
        {
            menu.MenuItemSelectedEvent += SelectMenuItem;
            menu.DisplayMainMenu();
        }

        private static void SelectMenuItem(object sender, Action action)
        {
            action();
        }

        private static List<MenuItem> PopulateMainMenu()
        {
            var mainMenu = new List<MenuItem>
            {
                new MenuItem("Over 18, who do not live in UK, whose surname does not contain letter 'a'", ViewMenuOptionOne, '1'),
                new MenuItem("Under 18,  who do not live in UK, whose surname does not contain letter 'a'", ViewMenuOptionTwo, '2'),
                new MenuItem("Who do not live in UK, whose surname and name does not contain letter 'a'", ViewMenuOptionThree, '3'),
                new MenuItem("Exit", Exit, '0')
            };

            return mainMenu;
        }

        private static void ViewMenuOptionOne()
        {
            var temp = contactsCenter.Filter(PeoplePredicates.IsA);
            PrintList(temp);
        }

        private static void ViewMenuOptionTwo()
        {
            var temp = contactsCenter.Filter(PeoplePredicates.IsB);
            PrintList(temp);
        }

        private static void ViewMenuOptionThree()
        {
            var temp = contactsCenter.Filter(PeoplePredicates.IsC);
            PrintList(temp);
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }

        private static void PrintList(List<Person> people)
        {
            var tableHeader = string.Format(
                "|{0,12}|{1,15}|{2,15}|{3,4}|{4,12}|{5,27}|{6,27}|{7,37}|",
                "Name",
                "Surname",
                "BirthDate",
                "Age",
                "Gender",
                "Country",
                "StreetAdress",
                "Email");

            var sb = new StringBuilder(tableHeader);
            sb.Append(Environment.NewLine);
            sb.Append('-', tableHeader.Length);

            Console.WriteLine(sb.ToString());

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine($"{Environment.NewLine}Total records: {people.Count}");
        }
    }
}