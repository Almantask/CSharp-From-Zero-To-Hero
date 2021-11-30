using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Time
    {
        public static List<IGrouping<int, Transactions>> GroupByHour(List<Transactions> data)
        {
            var groupDataByHour = data.GroupBy(element => element.Time.Hour)
                    .OrderBy(x => x.Key).ToList();

            return groupDataByHour;
        }

        public static List<IGrouping<int, Transactions>> GetTotalPriceByHour(List<IGrouping<int, Transactions>> data)
        {
            var getItemCountPerHour = data.Select(
                group => (
                group.Key,
                group.Sum(item => item.Price)));

            return data;
        }

        public static List<IGrouping<int, Transactions>> GetItemCountByHour(List<IGrouping<int, Transactions>> data)
        {
            //var getItemCountPerHour = data.Select(group => (group.Key, group.GroupBy(item => item.Price)));
            var getItemCountPerHour = data.Select(
                group => (
                group.Key,
                group.Count()));

            return data;
        }

    }
}
