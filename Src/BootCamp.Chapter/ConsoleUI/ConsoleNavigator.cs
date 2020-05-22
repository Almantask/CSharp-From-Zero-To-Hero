using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.ConsoleUI
{
    public class ConsoleNavigator
    {
        public List<MenuOptions> MenuOptions { get; }

        public ConsoleNavigator()
        {
            MenuOptions = Enum.GetValues(typeof(MenuOptions)).Cast<MenuOptions>().ToList();
        }

        public int RenderMenu()
        {
            var selectedMenu = 0;
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to our our Credentials Manager Simulation.");
                Console.WriteLine("Please select an option from the below menu.");
                Console.WriteLine("*=================================================*");

                foreach (var option in MenuOptions)
                {
                    if ((int)option == selectedMenu)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine(option);
                    Console.ResetColor();
                }

                var lastKeyPressed = Console.ReadKey(false);
                switch (lastKeyPressed.Key)
                {
                    case ConsoleKey.DownArrow:
                        selectedMenu = (selectedMenu + 1) % MenuOptions.Count;
                        break;

                    case ConsoleKey.UpArrow:
                        if (selectedMenu == 0)
                        {
                            selectedMenu = MenuOptions.Count - 1;
                        }
                        else
                        {
                            selectedMenu = ((selectedMenu - 1) % MenuOptions.Count);
                        }
                        break;

                    case ConsoleKey.Enter:
                        return selectedMenu;
                }
            }
        }
    }
}
