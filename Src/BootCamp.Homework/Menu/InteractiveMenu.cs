using System;
using System.Collections.Generic;

namespace BootCamp.Homework.Menu
{
    public class InteractiveMenu
    {
        private readonly Dictionary<Options, string> _options;
        private int _selectedOption;

        public InteractiveMenu()
        {
            var menuOptions = new MenuOptions();
            _options = menuOptions.Labels;
            _selectedOption = 0;
        }
        
        public Options Build()
        {
            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome.");
                Console.WriteLine("Select an option.");
                Console.WriteLine("==================================================");

                DrawSelection();
                var keyPressed = Console.ReadKey(false).Key;
                if (keyPressed == ConsoleKey.Enter)
                {
                    Console.CursorVisible = true;
                    return (Options) _selectedOption;
                }
                    
                GetSelection(keyPressed);
            } while (true);
        }

        private void GetSelection(ConsoleKey key)
        {
            var maxMenuLength = _options.Count - 1;
            
            switch (key)
            {
                case ConsoleKey.UpArrow when _selectedOption != 0:
                    _selectedOption--;
                    break;
                case ConsoleKey.UpArrow:
                    _selectedOption = maxMenuLength;
                    break;
                case ConsoleKey.DownArrow when _selectedOption != maxMenuLength:
                    _selectedOption++;
                    break;
                case ConsoleKey.DownArrow:
                    _selectedOption = 0;
                    break;
            }
        }

        private void DrawSelection()
        {
            foreach (var (key, value) in _options)
            {
                if (key == (Options) _selectedOption)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(value);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}