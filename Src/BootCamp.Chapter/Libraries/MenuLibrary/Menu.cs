using System;
using System.Collections.Generic;

namespace MenuLibrary
{
    public class Menu
    {
        public event EventHandler<Action> MenuItemSelectedEvent;

        public string MenuTitle { get; }

        public List<MenuItem> MainMenu { get; } = new List<MenuItem>();

        public Menu(string menuTitle, List<MenuItem> menuItems)
        {
            MenuTitle = menuTitle;
            MainMenu.AddRange(menuItems);
        }

        public void DisplayMainMenu()
        {
            ConsoleInit();
            ShowHeading();
            DisplayMenuOptions();
            ReadUserInput();
        }

        private static void ConsoleInit(bool cursorVisible = false)
        {
            Console.CursorVisible = cursorVisible;
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Console.Clear();
        }

        private void ShowHeading()
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(new string('-', MenuTitle.Length));
        }

        private void DisplayMenuOptions()
        {
            for (int i = 0; i < MainMenu.Count; i++)
            {
                Console.WriteLine($"({MainMenu[i].Key}) {MainMenu[i].Title}");
            }
        }

        private void ReadUserInput()
        {
            var userInput = Console.ReadKey(true).KeyChar;
            for (int i = 0; i < MainMenu.Count; i++)
            {
                if (MainMenu[i].Key == userInput)
                {
                    ConsoleInit();
                    MenuItemSelectedEvent?.Invoke(this, MainMenu[i].Execute);
                    Wait();
                }
            }

            DisplayMainMenu();
        }

        private static void Wait()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
    }
}