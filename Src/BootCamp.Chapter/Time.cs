using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Time
    {
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

    }
}
