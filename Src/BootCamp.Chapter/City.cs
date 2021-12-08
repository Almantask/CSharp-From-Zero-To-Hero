using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class City
    {
        public static List<City> CityList { get; set; } = new List<City>();

        private string cityName;
        public string CityName
        {
            get { return cityName; }
            private set { cityName = value; }
        }
        private decimal totalMoney;
        public decimal TotalMoney
        {
            get { return totalMoney; }
            private set { totalMoney = value; }
        }
        private int totalItemCount;
        public int TotalItemCount
        {
            get { return totalItemCount; }
            private set { totalItemCount = value; }
        }

        public City(string name, decimal totalMoney, int itemCount)
        {
            this.cityName = name;
            this.totalMoney = totalMoney;
            this.totalItemCount = itemCount;
            CityList.Add(this);
        }

    }
}
