using System;
using System.Collections.Generic;

namespace MenuLibrary
{
    public static class MenuDemo
    {
        private const string mainMenuTitle = "Main Menu";
        private static readonly List<MenuItem> mainMenu = PopulateMenu();

        private static List<MenuItem> PopulateMenu()
        {
            var mainMenu = new List<MenuItem>
            {
                new MenuItem("Menu 1", ViewMenuOptionOne, '1'),
                new MenuItem("Menu 2", ViewMenuOptionTwo, '2'),
                new MenuItem("Menu 3", ViewMenuOptionThree, '3'),
                new MenuItem("Exit", Exit, '0')
            };

            return mainMenu;
        }

        private static void ViewMenuOptionOne()
        {
            Console.WriteLine("Menu option one");
            GoToMainMenu();
        }

        private static void ViewMenuOptionTwo()
        {
            Console.WriteLine("Menu option two");
            GoToMainMenu();
        }

        private static void ViewMenuOptionThree()
        {
            Console.WriteLine("Menu option three");
            GoToMainMenu();
        }

        private static void ShowHeading(string heading)
        {
            Console.WriteLine(heading);
            Console.WriteLine(new string('-', heading?.Length ?? 0));
        }

        private static void GoToMainMenu()
        {
            Console.WriteLine($"{Environment.NewLine}Press any key to return to main menu");
            Console.ReadKey();
            DisplayMainMenu();
        }

        public static void DisplayMainMenu()
        {
            ConsoleInit();
            ShowHeading(mainMenuTitle);
            DisplayMenuOptions();
            ReadUserInput();
        }

        private static void ReadUserInput()
        {
            var userInput = Console.ReadKey(true).KeyChar;
            for (int i = 0; i < mainMenu.Count; i++)
            {
                if (mainMenu[i].Key == userInput)
                {
                    mainMenu[i].Execute();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Invalid option!");
            GoToMainMenu();
        }

        private static void DisplayMenuOptions()
        {
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"({mainMenu[i].Key}) {mainMenu[i].Title}");
            }
        }

        private static void Wait()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }

        private static void ConsoleInit(bool cursorVisible = false)
        {
            Console.Clear();
            Console.CursorVisible = cursorVisible;
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }
    }
}