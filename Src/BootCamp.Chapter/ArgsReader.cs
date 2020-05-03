using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class ArgsReader
    {
        //TODO finish ArgsReader
/*
You need to generate the following reports:

By time (time)
how many items have been bought during every hour of time of day,
how much money did every hour total (on average),
and get rush hour (most mony earned on average).
Support getting items sold count and money earned for a selected range of hours as well.

What city (can be parsed from address) earned the most/least money and what city sold the most/least items? (city [-min/-max] [-items/-money])
--- Extra challenge:

Daily money earned for specific shop. (daily Shop Name)

What items were sold in what shop, at what price and when (file, named after shop). (full)

Results should be printed to a file in .csv format.

(3) and (4) supports sorting by shop name (or city name) in either ascending or descending order.
If not sorting is provided, it should sort in ascending order. 
Sorting is just 1 extra arg: -asc (sorts in ascending order by shop name); -desc (sorts in descending order by shop name)
*/
        public static void Read(string[] args)
        {
            if (args == null || args.Length != 3)
            {
                throw new InvalidCommandException($"The {nameof(args)} must contain 1. a File Path 2. The command 3. to write to file path");
            }
        }
    }
}
