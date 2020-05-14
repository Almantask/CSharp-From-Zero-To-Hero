using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Objects;

namespace BootCamp.Chapter.CvsProcessors
{
    public static class ByTime
    {
        private static CultureInfo CurrentCultureInfo => CultureInfo.GetCultureInfo("lt-LT");
        
        public static string CheckByTime(IEnumerable<Transaction> transactions, string command)
        {
            var timeInterval = GetTimeInterval(command);
            
            var data = transactions
                .GroupBy
                (
                    transaction => transaction.DateTime,
                    (date, values) =>
                    {
                        var transaction = values.ToList();
                        return new
                        {
                            Date = date,
                            Price = transaction.Select(n => n.Price).Sum(),
                            Count = transaction.Select(n => n.Price).Count()
                        };
                    }
                )
                .GroupBy
                (
                    transaction => transaction.Date.Hour,
                    (hour, values) =>
                    {
                        var transaction =  values.ToList();
                        return new SummaryByTime
                        (
                            hour,
                            transaction.Select(n => n.Price).Average(),
                            transaction.Select(n => n.Count).Sum()
                        );
                    }
                )
                .ToDictionary(key => key.Hour);

            return BuildSummaryByTime(data, timeInterval);
        }

        private static string BuildSummaryByTime(Dictionary<int, SummaryByTime> data,
            List<int> timeInterval)
        {
            var summary = new StringBuilder();
            summary.AppendLine("Hour, Count, Earned");
            
            int rushHour = default;
            decimal rushValue = default;
            for (var i = timeInterval[0]; i <= timeInterval[1]; i++)
            {
                if (data.ContainsKey(i))
                {
                    var count = data[i].Count;
                    var earns = data[i].Earn;
                    if (earns > rushValue)
                    {
                        rushHour = i;
                        rushValue = earns;
                    }
            
                    // 20, 4, "9,00 €"
                    summary.AppendLine($"{i:D2}, {count}, \"{earns.ToString("C", CurrentCultureInfo)}\"");
                    // summary.AppendLine($"{i:D2}, {count}, \"{earns:C}\"");
                }
                else
                {
                    summary.AppendLine($"{i:D2}, {0}, \"{0.ToString("C", CurrentCultureInfo)}\"");
                }
            }
            
            // Rush hour: ##
            summary.AppendLine($"Rush hour: {rushHour:D2}");
            
            return summary.ToString();
        }
        
        private static List<int> GetTimeInterval(string command)
        {
            if (string.IsNullOrEmpty(command)) return new List<int> {0, 23};
            
            var interval = command.Split('-');
            if (interval.Length != 2) throw new InvalidCommandException();

            var isBeginValid =
                DateTimeOffset.TryParse(interval[0], CurrentCultureInfo, DateTimeStyles.None, out var timeBegin);
            var isEndValid =
                DateTimeOffset.TryParse(interval[1], CurrentCultureInfo, DateTimeStyles.None, out var timeEnd);
            if (!isBeginValid && !isEndValid) throw new InvalidCommandException();
            
            var timeBeginHour = timeBegin.Hour;
            var timeEndHour = (timeEnd.Hour == 0) ? 23 : timeEnd.Hour - 1;
            if (timeBeginHour >= timeEndHour) throw new InvalidCommandException();
            
            return new List<int> {timeBeginHour, timeEndHour};
        }
    }
}