using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class DailyRepData
    {
        public string ShopName { get; set; }
        public string WeekDay { get; set; }
        public decimal Price { get; set; }
        public static List<DailyRepData> DataList { get; set; } = new List<DailyRepData>();

        public DailyRepData(string shopName, string weekDay, decimal price)
        {
            ShopName = shopName;
            WeekDay = weekDay;
            Price = price;
            DataList.Add(this);
        }

        public override string ToString()
        {
            return string.Format(ShopName);
        }

    }
}
