using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class TimeStatics
    {
        public static void CalculateTimeReport(List<Transaction> transactions)
        {
            var transactionByHour = transactions.GroupBy(x => x.TimeWhenSold.Hour).ToList();
            var earningsByHour = GetEarningsByHour(transactions);
            var encoding = new UTF8Encoding();

            var reportLines = transactionByHour.Select(x => new
            {
                Hour = x.Key,
                Count = transactionByHour[x.Key].Count(),
                AverageByHour = earningsByHour[x.Key].Average()
            }).ToArray();

            var sortedReportLines = reportLines.OrderBy(x => x.Hour); 

            var file = @"Output\time.csv"; 

            File.WriteAllText(file,$"Hour, Count, Earned, {Environment.NewLine}");

            foreach (var line in sortedReportLines)
            {
                var moneyString = $"\"{line.AverageByHour:c}\"";
                
                File.AppendAllText(file, line.Hour.ToString("00"));
                File.AppendAllText(file, ", ");
                File.AppendAllText(file, line.Count.ToString());
                File.AppendAllText(file, ", ");
                File.AppendAllText(file, moneyString.ToString(CultureInfo.CreateSpecificCulture("en-GB")), encoding); 
                File.AppendAllText(file, Environment.NewLine);
            }

            var rushHour = reportLines.OrderByDescending(x => x.AverageByHour).First().Hour;

            File.AppendAllText(file,$"Rush hour: {rushHour:00}");
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