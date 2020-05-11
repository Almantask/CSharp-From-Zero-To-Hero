using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Command
    {
        public static IEnumerable<String> GetTimeReport(string[] command, List<Transaction> transactions)
        {
            //TODO RunTimeCommand
            /*
            By time(time)
            how many items have been bought during every hour of time of day,
            how much money did every hour total(on average),
            and get rush hour(most mony earned on average).
            Support getting items sold count and money earned for a selected range of hours as well.
            */
            //"time 11:00-17:00"
            DateTime[] times = new DateTime[2] { new DateTime(2020, 01, 01, 00, 00, 00), new DateTime(2020, 01, 01, 23, 00, 00) };

            if (command.Length == 1)
            {
                return GroupedByTime(transactions, times);
            }
            else if (command.Length == 2)
            {
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
        private static IEnumerable<String> CreateTabel(string topRow, IEnumerable<TimeNumberEarned> soldByTime, int startTime, int EndTime)
        {
            List<String> toBeWritten = new List<string>();

            //00, 0, "0,00 €"
            toBeWritten.Add(topRow);
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

            //Rush hour: 22
            toBeWritten.Add($"Rush hour: {rushHour}");

            return toBeWritten;
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

            return CreateTabel(topRow, soldByTime, times[0].Hour, times[1].Hour);
        }
        public static IEnumerable<String> GetCityReport(string[] command, List<Transaction> transactions)
        {
            //TODO RunCityCommand
            //What city(can be parsed from address) earned the most / least money and what city sold the most / least items ? (city[-min / -max][-items / -money])
            throw new NotImplementedException();
        }

        private static bool IsHoursValid(string hours, out DateTime[] times)
        {
            //TODO IsHoursCorrect() 11:00-17:00
            string[] timesString = hours.Split('-');
            times = new DateTime[2];

            for ( int i = 0; i < 2; i++)
            {
                if(!DateTime.TryParse(timesString[i], out times[i]))
                {
                    return false;
                }
            }
            if (times[1].Hour == 0)
            {
                times[1] = new DateTime(2020, 01, 01, 23, 00, 00);
            }

            return true;
        }
    }
}
