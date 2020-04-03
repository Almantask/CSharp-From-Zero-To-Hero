using MenuLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Demo
    {
        private const string inputFile = "Input/MOCK_DATA.csv";
        private static readonly Menu menu = new Menu("Main menu", PopulateMainMenu());

        public static void Run()
        {
            menu.DisplayMainMenu();
        }

        private static List<MenuItem> PopulateMainMenu()
        {
            var mainMenu = new List<MenuItem>
            {
                new MenuItem("Over 18, who do not live in UK, whose surename does not contain letter 'a'", ViewMenuOptionOne, '1'),
                new MenuItem("Under 18,  who do not live in UK, whose surename does not contain letter 'a'", ViewMenuOptionTwo, '2'),
                new MenuItem("Who do not live in UK, whose surename and name does not contain letter 'a'", ViewMenuOptionThree, '3'),
                new MenuItem("All of above", ViewMenuOptionFour, '4')
            };

            return mainMenu;
        }

        private static void ViewMenuOptionOne()
        {
        }

        private static void ViewMenuOptionTwo()
        {
            Console.WriteLine("Menu option two");
        }

        private static void ViewMenuOptionThree()
        {
            Console.WriteLine("Menu option three");
        }

        private static void ViewMenuOptionFour()
        {
            Console.WriteLine("Menu option three");
        }
    }
}