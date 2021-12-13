using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Time
    {
        public static void GroupByShopName(List<Transactions> data)
        {
            var groupDataByShopName = data.Select(x => new DailyRepData(x.Shop, x.Time.ToString("dddd", CultureInfo.GetCultureInfoByIetfLanguageTag("en-GB")), x.Price))
            .GroupBy(element => element.ShopName)
            .OrderBy(x => x.Key)
            .ToList();
        }

        public static List<IGrouping<int, Transactions>> GroupByHourIntRange(List<Transactions> data, int startTime, int endTime)
        {
            var groupDataByHourRange = data.Where(x => x.Time.Hour >= startTime && x.Time.Hour <= endTime)
                .GroupBy(element => element.Time.Hour)
                .OrderBy(x => x.Key).ToList();

            return groupDataByHourRange;
        }
        public static List<IGrouping<int, Transactions>> GroupByHourRange(List<Transactions> data, DateTime startTime, DateTime endTime)
        {
            List<IGrouping<int, Transactions>> groupDataByHourRange;
            if (endTime.Hour == 0)
            {
                ///<summary>
                ///     start and end times are in different days         
                /// </summary>
                groupDataByHourRange = data.Where(x => x.Time.TimeOfDay.Hours >= startTime.TimeOfDay.Hours || x.Time.TimeOfDay.Hours <= 24)
                    .GroupBy(element => element.Time.Hour)
                    .OrderBy(x => x.Key).ToList();
            }
            else
            {
                ///<summary>
                ///     start and end times are in the same day       
                /// </summary>
                groupDataByHourRange = data.Where(x => x.Time.TimeOfDay.Hours >= startTime.TimeOfDay.Hours && x.Time.TimeOfDay.Hours <= endTime.TimeOfDay.Hours)
                    .GroupBy(element => element.Time.Hour)
                    .OrderBy(x => x.Key).ToList();
            }


            return groupDataByHourRange;
        }
        public static List<IGrouping<int, Transactions>> GroupByHour(List<Transactions> data)
        {
            var groupDataByHour = data.GroupBy(element => element.Time.Hour)
                    .OrderBy(x => x.Key).ToList();

            return groupDataByHour;
        }

        public static List<decimal> GetTotalPriceByHour(List<IGrouping<int, Transactions>> data)
        {
            var GetTotalPriceByHour = data.Select(
                group => (
                group.Key,
                group.Sum(item => item.Price))).ToList();

            List<decimal> totalPricePerHour = new List<decimal>();
            foreach(var total in GetTotalPriceByHour)
            {
                totalPricePerHour.Add(total.Item2);
            }

            return totalPricePerHour;
        }

        public static List<int> GetItemCountByHour(List<IGrouping<int, Transactions>> data)
        {
            //var getItemCountPerHour = data.Select(group => (group.Key, group.GroupBy(item => item.Price)));
            var getItemCountPerHour = data.Select(
                group => (
                group.Key,
                group.Count())).ToList();

            List<int> totalCountPerHour = new List<int>();
            foreach (var total in getItemCountPerHour)
            {
                totalCountPerHour.Add(total.Item2);
            }

            return totalCountPerHour;
        }

        public static void FullDayReportData(List<decimal> getTotalPriceByHour, List<int> getItemCountByHour, List<string> avgMoneyPerHour, List<string> rushHourDataSave, List<List<string>> fullDayReportData)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < getTotalPriceByHour.Count; j++)
                {
                    List<string> test = new List<string>();
                    test.Add(j.ToString());
                    test.Add(getItemCountByHour[j].ToString());
                    test.Add(avgMoneyPerHour[j].ToString());

                    fullDayReportData.Add(test);
                }

                fullDayReportData.Add(rushHourDataSave);
            }
        }

        public static void GetRushHour(List<string> avgMoneyPerHour, List<string> rushHourDataSave)
        {
            var rushHourValue = avgMoneyPerHour.Max();
            var rushHour = avgMoneyPerHour.Select(x => x == rushHourValue).ToList();
            int value = 0;
            foreach (var hour in rushHour)
            {
                if (hour == true)
                {
                    Console.Write(value);
                    string input = ("Rush hour: " + value);
                    rushHourDataSave.Add(input);
                }
                value++;
            }
        }

        public static void GetAverageMoney(List<decimal> getTotalPriceByHourRange, List<int> getItemCountByHourRange, List<string> avgMoneyPerHour)
        {
            for (int i = 0; i < getTotalPriceByHourRange.Count; i++)
            {
                avgMoneyPerHour.Add((getTotalPriceByHourRange[i] / getItemCountByHourRange[i]).ToString("0.##"));
            }
        }
    }
}
