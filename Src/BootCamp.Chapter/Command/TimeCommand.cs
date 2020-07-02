using BootCamp.Chapter.Models;
using BootCamp.Chapter.ReportsManagers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    internal class TimeCommand : ICommand
    {
        private string _Path;
        private List<string> _Command;
        private List<Transaction> _Transactions;
        private ReportsManager _ReportsManager;

        public TimeCommand(string path, List<string> command, List<Transaction> transactions, ReportsManager reportsManager)
        {
            _Path = path;
            _Command = command;
            _Transactions = transactions;
            _ReportsManager = reportsManager;
        }

        public void Execute()
        {
            var toBeWritten = CreateReport();
            _ReportsManager.WriteModel(_Path, toBeWritten);
        }

        private TimesModel CreateReport()
        {
            DateTime[] times = new DateTime[2] { new DateTime(2020, 01, 01, 00, 00, 00), new DateTime(2020, 01, 01, 23, 00, 00) };

            if (_Command.Count == 1)
            {
                //Time Command given without any times uses whole day.
                return GroupedByTime(_Transactions, times);
            }
            else if (_Command.Count == 2)
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

        private static TimesModel GroupedByTime(List<Transaction> transactions, DateTime[] times)
        {
            List<HourCountEarnedDecimal> soldByTime = transactions.GroupBy(t => t.DateTime.Hour).Select(z => new HourCountEarnedDecimal
            {
                Hour = z.First().DateTime.Hour,
                Count = z.Count(),
                Earned = z.Sum(x => x.Price) / z.Select(x => x.DateTime.Date).Distinct().Count()
            }
            ).ToList();

            return CreateModelWithTimes(soldByTime, times[0].Hour, times[1].Hour);
        }
        private static int FindRushHour(IEnumerable<HourCountEarnedDecimal> soldByTime, int startTime, int EndTime)
        {
            int rushHour = 0;
            decimal mostEarned = Decimal.MinValue;

            for (int time = startTime; time <= EndTime; time++)
            {
                int count = 0;
                decimal earned = 0;

                foreach (HourCountEarnedDecimal timeNumberEarned in soldByTime)
                {
                    if (timeNumberEarned.Hour == time)
                    {
                        count = timeNumberEarned.Count;
                        earned = timeNumberEarned.Earned;
                        if (mostEarned < earned)
                        {
                            mostEarned = earned;
                            rushHour = time;
                        }
                    }
                }
            }

            return rushHour;
        }

        private static TimesModel CreateModelWithTimes(List<HourCountEarnedDecimal> soldByTime, int startTime, int EndTime)
        {
            List<Time> hourCountEarneds = new List<Time>();

            for (int time = startTime; time <= EndTime; time++)
            {
                bool isTimeAdded = false;

                foreach (HourCountEarnedDecimal timeNumberEarned in soldByTime)
                {
                    if (timeNumberEarned.Hour == time)
                    {
                        hourCountEarneds.Add(Time.ConvertFromDecimal(timeNumberEarned));
                        isTimeAdded = true;
                    }
                }
                if (!isTimeAdded)
                {
                    hourCountEarneds.Add(new Time() { Hour = time, Count = 0, Earned = 0.ToString("C2", CultureInfo.GetCultureInfo("lt-LT")) });
                }
            }
            return new TimesModel(hourCountEarneds, FindRushHour(soldByTime, startTime, EndTime));
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