using System;

namespace BootCamp.Chapter
{
    public class InteractiveMenu
    {
        public int Build(string[] options)
        {
            var index = 0;
            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Password Manager.");
                Console.WriteLine("Select an option.");
                Console.WriteLine("==================================================");
                
                for (var i = 0; i < options.Length; i++)
                {
                    if (index == i) Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(options[i]);
                    Console.ResetColor();
                }
                
                var key = Console.ReadKey(false);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index != 0) index--;
                        else index = options.Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        if (index != options.Length - 1) index++;
                        else index = 0;
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        return index;
                }
            } while (true);
        }
    }
}