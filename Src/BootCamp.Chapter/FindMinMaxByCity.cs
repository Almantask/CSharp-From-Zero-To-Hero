using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class FindMinMaxByCity
    {
       public static void GroupDataByCity(List<Transactions> data)
        {
            var groupDataByCity = data.GroupBy(element => element.City)
                  .OrderBy(x => x.Key).ToList();

            var itemCount = groupDataByCity.Select(
                  group => (
                  group.Key,
                  group.Count())).ToList();

            var totalPriceByCity = groupDataByCity.Select(
               group => (
               group.Key,
               group.Sum(item => item.Price))).ToList();

            var completeDataByCity = itemCount.Join(totalPriceByCity,
                count => count.Key,
                price => price.Key,
                (count, price) => new
                {
                    CityName = count.Key,
                    TotalMoney = price.Item2,
                    TotalItemCount = count.Item2
                }).ToList();

            foreach (var city in completeDataByCity)
            {
                new City(city.CityName, city.TotalMoney, city.TotalItemCount);
            }
        }

        public static string FindCityItemsMin(List<City> data)
        {
            var find = data.Min(city => city.TotalItemCount);
            var cityName = data.Where(city => city.TotalItemCount == find).ToList();

            return cityName[0].CityName;
        }

        public static string FindCityItemsMax(List<City> data)
        {
            var find = data.Max(city => city.TotalItemCount);
            var cityName = data.Where(city => city.TotalItemCount == find).ToList();

            return cityName[0].CityName;
        }

        public static string FindCityMoneyMin(List<City> data)
        {
            var find = data.Min(city => city.TotalMoney);
            var cityName = data.Where(city => city.TotalMoney == find).ToList();

            return cityName[0].CityName;
        }

        public static string FindCityMoneyMax(List<City> data)
        {
            var find = data.Max(city => city.TotalMoney);
            var cityName = data.Where(city => city.TotalMoney == find).ToList();

            return cityName[0].CityName;
        }

    }
    
}
