using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class Command
    {
        public static IEnumerable<String> CreateTimeReport(string[] command, List<Transaction> transactions)
        {
            DateTime[] times = new DateTime[2] { new DateTime(2020, 01, 01, 00, 00, 00), new DateTime(2020, 01, 01, 23, 00, 00) };

            if (command.Length == 1)
            {
                //Time Command given without any times uses whole day.
                return GroupedByTime(transactions, times);
            }
            else if (command.Length == 2)
            {
                //Time Command given with times only gives a report within time frame.
                if (IsHoursValid(command[1], out times))
                {
                    return GroupedByTime(transactions, times);
                }
                throw new InvalidCommandException($"{command[0]} has the wrong Times.");
            }
            else
            {
                throw new InvalidCommandException($"{command[0]} has to many parameters.");
            }
        }

        public static IEnumerable<String> CreateCityReport(string[] command, List<Transaction> transactions)
        {
            const string money = "-money";
            const string items = "-items";
            const string min = "-min";
            const string max = "-max";

            if (command.Length != 3)
            {
                throw new InvalidCommandException($"{command[0]} has the wrong amount of parameters.");
            }

            if (command[1] == items)
            {
                if (command[2] == min || command[2] == max)
                {
                    return FindItemsMaxOrMin(transactions, command[2]);
                }
                else
                {
                    throw new InvalidCommandException($"{command[2]} is not a valid parameter.");
                }
            }
            else if (command[1] == money)
            {
                if (command[2] == min || command[2] == max)
                {
                    return FindMoneyMaxOrMin(transactions, command[2]);
                }
                else
                {
                    throw new InvalidCommandException($"{command[2]} is not a valid parameter.");
                }
            }
            else
            {
                throw new InvalidCommandException($"{command[1]} is not a valid parameter.");
            }
        }

        private static IEnumerable<String> GroupedByTime(List<Transaction> transactions, DateTime[] times)
        {
            const string topRow = "Hour, Count, Earned";

            var soldByTime = transactions.GroupBy(t => t.DateTime.Hour).Select(z => new TimeNumberEarned
            {
                Time = z.First().DateTime.Hour,
                Number = z.Count(),
                Earned = z.Sum(x => x.Price) / z.Select(x => x.DateTime.Date).Distinct().Count()
            }
            ).ToList();

            return CreateTabelForSoldByTime(topRow, soldByTime, times[0].Hour, times[1].Hour);
        }

        private static IEnumerable<String> FindMoneyMaxOrMin(List<Transaction> transactions, string maxOrMin)
        {
            /*
            var groupedcity = from i in transactions
                              group i by i.City into g
                              select new { g.Key, Total = g.Sum(i => i.Price) };

            */
            var groupedcity = transactions.GroupBy(i => i.City)
                                          .Select(g => new { g.Key, Total = g.Sum(i => i.Price) });

            decimal itemsPerCityMaxOrMin = maxOrMin == "-max" ? groupedcity.Max(g => g.Total) : groupedcity.Min(g => g.Total);

            var toReturn = from i in groupedcity
                           where i.Total == itemsPerCityMaxOrMin
                           select i.Key.Trim();
            return toReturn;
        }

        private static IEnumerable<String> FindItemsMaxOrMin(List<Transaction> transactions, string maxOrMin)
        {
            var groupedcity = from i in transactions
                              group i.City by i.City into g
                              select new { g.Key, Count = g.Count() };

            int itemsPerCityMaxOrMin = maxOrMin == "-max" ? groupedcity.Max(g => g.Count) : groupedcity.Min(g => g.Count);

            var toReturn = from i in groupedcity
                           where i.Count == itemsPerCityMaxOrMin
                           select i.Key.Trim();
            return toReturn;
        }

        private static IEnumerable<String> CreateTabelForSoldByTime(string topRow, IEnumerable<TimeNumberEarned> soldByTime, int startTime, int EndTime)
        {
            List<String> toBeWritten = new List<string>();

            toBeWritten.Add(topRow);

            int rushHour = AddTimesToBeWritten(soldByTime, startTime, EndTime, toBeWritten);

            toBeWritten.Add($"Rush hour: {rushHour}");

            return toBeWritten;
        }

        private static int AddTimesToBeWritten(IEnumerable<TimeNumberEarned> soldByTime, int startTime, int EndTime, List<string> toBeWritten)
        {
            int rushHour = 0;
            decimal mostEarned = Decimal.MinValue;

            for (int i = startTime; i <= EndTime; i++)
            {
                int count = 0;
                decimal earned = 0;

                foreach (TimeNumberEarned timeNumberEarned in soldByTime)
                {
                    if (timeNumberEarned.Time == i)
                    {
                        count = timeNumberEarned.Number;
                        earned = timeNumberEarned.Earned;
                        if (mostEarned < earned)
                        {
                            mostEarned = earned;
                            rushHour = i;
                        }
                    }
                }
                toBeWritten.Add($"{i.ToString("D2")}, {count}, \"{earned.ToString("C2", CultureInfo.GetCultureInfo("lt-LT"))}\"");
            }

            return rushHour;
        }

        private static bool IsHoursValid(string hours, out DateTime[] times)
        {
            string[] timesString = hours.Split('-');
            times = new DateTime[2];

            for (int i = 0; i < 2; i++)
            {
                if (!DateTime.TryParse(timesString[i], out times[i]))
                {
                    return false;
                }
            }
            // if time given is 24:00 it defaults to 00:00 but that is also the start of the day so overwite to last hour printed. 23:00
            if (times[1].Hour == 0)
            {
                times[1] = new DateTime(2020, 01, 01, 23, 00, 00);
            }

            return true;
        }
    }
}