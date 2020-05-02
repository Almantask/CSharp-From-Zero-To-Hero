using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class TimeStatics
    {
        public static void CalculateTimeReport(List<Transaction> transactions)
        {
            var transactionByHour = transactions.GroupBy(x => x.TimeWhenSold.Hour).ToList();
            var earningsByHour = GetEarningsByHour(transactions);
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var reportLines = earningsByHour.Select(x => new
            {
                Hour = x.Key,
                Count = transactionByHour[x.Key].Count(),
                AverageByHour = earningsByHour[x.Key].Average()
            }).ToArray();

            Console.WriteLine("Hour, Count, Earned");

            foreach (var line in reportLines)
            {
                var moneyString = $"\"{line.AverageByHour:c}\"";

                Console.Write(line.Hour.ToString("00"));
                Console.Write(", ");
                Console.Write(line.Count);
                Console.Write(", ");
                Console.Write(moneyString.ToString(CultureInfo.CreateSpecificCulture("en-GB")));
                Console.Write(Environment.NewLine);
            }
        }

        private static IDictionary<int, IList<decimal>> GetEarningsByHour(List<Transaction> transactions)
        {
            var earningsByHour = new Dictionary<int, IList<decimal>>(
               Enumerable.Range(0, 24)
                   .Select(x => new KeyValuePair<int, IList<decimal>>(x, new List<decimal>())
               )
           );

            var transactionsByDay = transactions.GroupBy(x => x.TimeWhenSold.Date);

            foreach (var daysTransactions in transactionsByDay)
            {
                var byHour = daysTransactions.GroupBy(x => x.TimeWhenSold.Hour);
                foreach (var hour in byHour)
                {
                    earningsByHour[hour.Key].Add(hour.Sum(x => x.TotalPrice));
                }
            }

            return earningsByHour;
        }
    }
}