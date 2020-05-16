using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class UserMenu
    {
        public static void Display()
        {
            Console.WriteLine($"Menu options:{Environment.NewLine}" +
                              $"1) Display items{Environment.NewLine}" +
                              $"2) Display users{Environment.NewLine}");
            
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Items");
                // Do a lot more...
            }
            else if (input == "2")
            {
                Console.WriteLine("Users");
                // Do a lot more...
            }
        }
    }
}
