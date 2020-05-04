﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter
{
    public static class TimeStatics
    {
        public static List<OutputTime> CalculateTimeReport(List<Transaction> transactions, TimeSpan beginTime, TimeSpan endTime)
        {
            //var filteronTime = transactions.Where(x => x.TimeWhenSold.TimeOfDay >= beginTime && x.TimeWhenSold.TimeOfDay <= endTime).ToList(); 
            var transactionsByHours = transactions.ToLookup(x => x.TimeWhenSold.Hour);
            var earningsByHour = GetEarningsByHour(transactions, beginTime, endTime);

            var reportLines = earningsByHour.Select(x => new OutputTime
            {
                Hour = x.Key,
                Count =  transactionsByHours[x.Key].Count(),
                Average = earningsByHour[x.Key].Count != 0 ? earningsByHour[x.Key].Average() : 0m
            });

            var sortedReportLines = reportLines.OrderBy(x => x.Hour).ToList();

            return sortedReportLines;
        }

        private static IDictionary<int, IList<decimal>> GetEarningsByHour(List<Transaction> transactions, TimeSpan beginTime, TimeSpan endTime)
        {
            var beginningHour = (int)beginTime.TotalHours;
            
            if (endTime == default)
            {
                endTime = endTime.Add(new TimeSpan(24, 0, 0)); 
            }

            var endHour = (int)endTime.TotalHours ;

            if (endHour == 23)
            {
                endHour = endHour + 1; 
            }

            var earningsByHour = new Dictionary<int, IList<decimal>>(
               Enumerable.Range( beginningHour, endHour - beginningHour )
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