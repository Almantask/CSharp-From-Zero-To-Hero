using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Objects;

namespace BootCamp.Chapter.UnusedClasses
{
    public class Test
    {
        // This freak code is working
        public static void Run(IEnumerable<Transaction> transactions)
        {

            var data = transactions
                .GroupBy(n=> n.DateTime)
                .Select(n=> new
                {
                    Date = n.First().DateTime,
                    Price = n.Select(x => x.Price).Sum(),
                    Count = n.Select(x => x.Price).Count()
                })
                .GroupBy(n=> n.Date.Hour)
                .ToDictionary(a => a.Key);
            
            var strbuilder = new StringBuilder();
            strbuilder.AppendLine("Hour, Count, Earned");
            var rushHour = 0;
            decimal rushValue = 0;

            for (var i = 0; i < 24; i++)
            {
                if (data.ContainsKey(i))
                {
                    var count = data[i].Select(n => n.Count).Sum();
                    var earns = data[i].Select(n => n.Price).Average();
                    if (earns > rushValue)
                    {
                        rushHour = i;
                        rushValue = earns;
                    }
                
                    // 20, 4, "9,00 €"
                    strbuilder.AppendLine($"{i:D2}, {count}, \"{earns:F} €\"");
                }
                else
                {
                    strbuilder.AppendLine($"{i:D2}, {0}, \"{0:F} €\"");
                }
                
            }
            
            // Rush hour: ##
            strbuilder.AppendLine($"Rush hour: {rushHour}");
            Console.WriteLine(strbuilder.ToString());
            Console.WriteLine();
        }
        
        // This freak code is working
        public static void Run3(IEnumerable<Transaction> transactions)
        {

            var data = transactions
                .GroupBy(n=> n.DateTime)
                .Select(n=> new
                {
                    Date = n.First().DateTime,
                    Price = n.Select(x => x.Price).Sum(),
                    Count = n.Select(x => x.Price).Count()
                })
                .GroupBy(n=> n.Date.Hour)
                .ToDictionary(a => a.Key);
            
            var strbuilder = new StringBuilder();
            strbuilder.AppendLine("Hour, Count, Earned");
            var rushHour = 0;
            decimal rushValue = default;

            foreach (var (key, value) in data)
            {
                var count = value.Select(n => n.Count).Sum();
                var earns = value.Select(n => n.Price).Average();
                if (earns > rushValue)
                {
                    rushHour = key;
                    rushValue = earns;
                }
                
                // 20, 4, "9,00 €"
                strbuilder.AppendLine($"{key}, {count}, \"{earns:F} €\"");
            }
            
            // Rush hour: ##
            strbuilder.AppendLine($"Rush hour: {rushHour}");
            Console.WriteLine(strbuilder.ToString());
            Console.WriteLine();
        }
        
        // Working 2
        public static void Run2(IEnumerable<Transaction> transactions)
        {

            var data = transactions
                // .GroupBy(n => n.DateTime.Hour, j=> new
                // {
                //     Date = j.DateTime.Date,
                //     Price = j.Price
                // })
                .GroupBy(n=> n.DateTime)
                .Select(n=> new
                {
                    Date = n.First().DateTime,
                    Price = 
                    (
                        from x in n
                        select x.Price
                    )
                    .Sum()
                })
                .GroupBy(n=> n.Date.Hour)
                .ToDictionary(a => a.Key);

            foreach (var (key, value) in data)
            {
                var count = value.Count();
                var earns = (from prices in value
                    select prices.Price).Sum() / count;

                Console.WriteLine(key);
                Console.WriteLine(earns);
            }
            
            Console.WriteLine();
        }
        
        // "Working" 1
        public static void Run1(IEnumerable<Transaction> transactions)
        {

            var data = transactions
                // .GroupBy(n => n.DateTime.Hour, j=> new
                // {
                //     Date = j.DateTime.Date,
                //     Price = j.Price
                // })
                .GroupBy(n=> n.DateTime)
                .Select(n=> new
                {
                    Date = n.First().DateTime,
                    Price = 
                    (
                        from x in n
                        select x.Price
                    )
                    .Sum()
                })
                .GroupBy(n=> n.Date.Hour)
                .ToDictionary(a => a.Key);

            // var hue = data
            //     .Select(n => n.Value)
            //     .ToList();
                
            
            Console.WriteLine();
        }
        
        // public static void Run(IEnumerable<Transaction> transactions)
        // {
        //     var hour = new List<int>();
        //     var earnDay = new Dictionary<DateTimeOffset, decimal>();
        //     var day = new List<DateTime>();
        //     var earn = new List<decimal>();
        //
        //     foreach (var transaction in transactions)
        //     {
        //         var hourFe = transaction.DateTime.Hour;
        //         var dayFe = transaction.DateTime;
        //         var earnFe = transaction.Price;
        //         if (hour.Contains(hourFe))
        //         {
        //             if (earnDay.ContainsKey(dayFe))
        //             {
        //                 earnDay[dayFe] += earnFe;
        //             }
        //             else
        //             {
        //                 earnDay.Add(dayFe, earnFe);
        //             }
        //         }
        //         else
        //         {
        //             hour.Add(hourFe);
        //             earnDay.Add(dayFe, earnFe);
        //         }
        //         
        //     }
        //     
        //     Console.WriteLine();
        // }
    }
}