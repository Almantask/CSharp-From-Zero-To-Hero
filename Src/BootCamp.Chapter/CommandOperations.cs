using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CommandOperations
    {
        public static void HelpOperation()
        {
            Console.WriteLine("The following commands generate reports to display the following information:");
            Console.WriteLine("---------------");
            Console.WriteLine("\"time [insert time]\":");
            Console.WriteLine(" - how many items have been bought during every hour of time of day");
            Console.WriteLine(" - how much money did every hour total (on average)");
            Console.WriteLine(" - which operating hour was the most profitable");
            Console.WriteLine("---------------");
            Console.WriteLine("\"city [-min/-max] [-items/-money]\":");
            Console.WriteLine(" - how many items have been bought during every hour of time of day");
            Console.WriteLine(" - how much money did every hour total (on average)");
            Console.WriteLine(" - which operating hour was the most profitable");
            Console.WriteLine("---------------");
            Console.WriteLine("\"daily [shop name]\":");
            Console.WriteLine(" - how many items have been bought during every hour of time of day");
            Console.WriteLine(" - how much money did every hour total (on average)");
            Console.WriteLine(" - which operating hour was the most profitable");
            Console.WriteLine("---------------");
            Console.WriteLine("\"full [shop name]\":");
            Console.WriteLine(" - how many items have been bought during every hour of time of day");
            Console.WriteLine(" - how much money did every hour total (on average)");
            Console.WriteLine(" - which operating hour was the most profitable");

        } 
    }
}
