using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class TimeCommand : ICommand
    {
        private string _Path;
        private string[] _Command;
        private List<Transaction> _Transactions;

        public TimeCommand(string path, string[] command, List<Transaction> transactions)
        {
            _Path = path;
            _Command = command;
            _Transactions = transactions;
        }

        public void Execute()
        {
            var toBeWritten = CreateReport();
            WriteToCSV(toBeWritten);
        }

        private IEnumerable<string> CreateReport()
        {
            DateTime[] times = new DateTime[2] { new DateTime(2020, 01, 01, 00, 00, 00), new DateTime(2020, 01, 01, 23, 00, 00) };

            if (_Command.Length == 1)
            {
                //Time Command given without any times uses whole day.
                return GroupedByTime(_Transactions, times);
            }
            else if (_Command.Length == 2)
            {
                //Time Command given with times only gives a report within time frame.
                if (IsHoursValid(_Command[1], out times))
                {
                    return GroupedByTime(_Transactions, times);
                }
                throw new InvalidCommandException($"{_Command[0]} has the wrong Times.");
            }
            else
            {
                throw new InvalidCommandException($"{_Command[0]} has to many parameters.");
            }
        }

        private static IEnumerable<String> GroupedByTime(List<Transaction> transactions, DateTime[] times)
        {
            const string headers = "Hour, Count, Earned";

            var soldByTime = transactions.GroupBy(t => t.DateTime.Hour).Select(z => new HourCountEarned
            {
                Hour = z.First().DateTime.Hour,
                Count = z.Count(),
                Earned = z.Sum(x => x.Price) / z.Select(x => x.DateTime.Date).Distinct().Count()
            }
            ).ToList();

            return CreateTabelForSoldByTime(headers, soldByTime, times[0].Hour, times[1].Hour);
        }

        private static IEnumerable<String> CreateTabelForSoldByTime(string topRow, IEnumerable<HourCountEarned> soldByTime, int startTime, int EndTime)
        {
            List<String> toBeWritten = new List<string>();

            toBeWritten.Add(topRow);

            int rushHour = AddTimesToBeWritten(soldByTime, startTime, EndTime, toBeWritten);

            toBeWritten.Add($"Rush hour: {rushHour}");

            return toBeWritten;
        }

        private static int AddTimesToBeWritten(IEnumerable<HourCountEarned> soldByTime, int startTime, int EndTime, List<string> toBeWritten)
        {
            int rushHour = 0;
            decimal mostEarned = Decimal.MinValue;

            for (int i = startTime; i <= EndTime; i++)
            {
                int count = 0;
                decimal earned = 0;

                foreach (HourCountEarned timeNumberEarned in soldByTime)
                {
                    if (timeNumberEarned.Hour == i)
                    {
                        count = timeNumberEarned.Count;
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

        private void WriteToCSV(IEnumerable<string> toBeWritten)
        {
            ReportsManager.WriteTimeTransaction(_Path, toBeWritten);
        }
    }
}