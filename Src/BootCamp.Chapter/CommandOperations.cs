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
            Console.WriteLine(" - the cities in order of min/max of items sold/money made");
            Console.WriteLine("---------------");
            Console.WriteLine("\"daily [shop name]\":");
            Console.WriteLine(" - daily money earnt for a specific shop");
            Console.WriteLine("---------------");
            Console.WriteLine("\"full\":");
            Console.WriteLine(" - what items were sold in what shop, at what price and when");
            Console.WriteLine(" - creates a [shop name].csv for all shops in the input .csv file");
        } 
    }
}
