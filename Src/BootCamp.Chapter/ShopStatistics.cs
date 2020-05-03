using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter
{
    internal class ShopStatistics
    {
        public static string FindCityWithHighestSales(List<Transaction> transactions)
        {
             return transactions.GroupBy(x => x.City).OrderByDescending(x => x.Sum(x => x.TotalPrice)).First().Key;
        }

        public static string FindCityWithLowestSales(List<Transaction> transactions)
        {
            return transactions.GroupBy(x => x.City).OrderBy(x => x.Sum(x => x.TotalPrice)).First().Key;
        }

        public static string FindCityWithHighestSoldItems(List<Transaction> transactions)
        {
            return transactions.GroupBy(x => x.City).OrderByDescending(x => x.Count()).First().Key;
        }

        public static string FindCityWithLowestSoldItems(List<Transaction> transactions)
        {
            return transactions.GroupBy(x => x.City).OrderBy(x => x.Count()).First().Key;
        }
    }
}  