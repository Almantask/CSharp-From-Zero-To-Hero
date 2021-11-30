using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ImportTransactionsData dataInput = new ImportTransactionsData();

            string filePath = string.Empty;
            string command = string.Empty;
            string outputFilePath = string.Empty;

            if (args == null || args.Length == 0)
            {
                filePath = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv";
                command = "time";
            }
            else
            {
                filePath = args[0];
                command = args[1];
                outputFilePath = args[2];
            }

            dataInput.ImportTransactionsDataT(filePath);

            ///<summary>
            ///     check if any data was imported
            /// </summary>
            var isNotEmpty = dataInput.Data.Any();

            ///<summary>
            ///     Check imported data (for manual debug)
            ///</summary>
            bool debug = false;
            if (debug)
            {
                DebugInput(dataInput);
            }

            if (command.ToLowerInvariant() == "time")
            {
                var dataGroupedByHour = Time.GroupByHour(dataInput.Data);
                var getTotalPriceByHour = Time.GetTotalPriceByHour(dataGroupedByHour);
                var getItemCountByHour = Time.GetItemCountByHour(dataGroupedByHour);

                var test = dataGroupedByHour
                    .GroupJoin(getTotalPriceByHour,
                    byHour => byHour.Key,
                    byPrice => byPrice.Key,
                    (Transactions, getTotalPriceByHour) => new Transactions((dataGroupedByHour, getTotalPriceByHour));
                    
            }

            if (command.ToLowerInvariant() == "time")
            {
                var groupDataByHour = dataInput.Data.GroupBy(element => element.Time.Hour)
                    .OrderBy(x => x.Key);
                    

                var result6 = dataInput.Data.GroupBy(element => element.Time.Hour)
                   .Select(
                    kvp => (
                    kvp.Key,
                    kvp.GroupBy(item => item.Price)
                    .Select(priceGroup => (priceGroup.Key, priceGroup.Count()))
                    .ToList()));

                var result7 = dataInput.Data.GroupBy(transaction => transaction.Time.Hour)
                        .Select(
                        group => (
                        group.Key,
                        group.GroupBy(item => item.Price)
                        .Select(priceGroup => (priceGroup.Key, priceGroup.Count()))
                        .ToList()))
                        .ToDictionary(magic => magic.Key, magic => magic.Item2);


                var result = dataInput.Data.GroupBy(element => element.Time.Hour)
                    .ToDictionary(grp => grp.Key)
                    .Select(kvp => new
                    {
                        Hour = kvp.Key,
                        ItemCount = kvp.Value.Count(),
                    }
                    ).ToList();

                var result3 = dataInput.Data.Select(p => new { p.Time.Hour, p.Price })
                .GroupBy(element => element.Hour).ToList();

                var orderByResult3 = from s in result3
                                    orderby s.Key
                                    select s;

                var test3 = orderByResult3.ToList();

                var totalPrice = 0m;
                var itemCountPerHour = 0;
                foreach (var hours in test3)
                {
                    foreach( var data in hours)
                    {
                        var testtt2 = hours.Count();
                        Console.WriteLine($"{data.Hour} {data.Price}");
                        
                        totalPrice += data.Price;
                    }
                    itemCountPerHour = hours.Count();
                }

                //get an hour
                var hour = test3[0].Key;
                // convert each hour to list
                var itemCount = test3[0].ToList();
                // get itemCount per hour
                var test = itemCount.Count();
                // get overall price
                var price = 0m;
                foreach(var item in itemCount)
                {
                    price += item.Price;
                }
                
                // pomoc z czatu:
                {
                    /*
                     public static Dictionary<int, List<(decimal Price, int ItemCount)>> GroupByHour(List<Transactions> transactions)
                     {
                            var hourGroups = transactions
                            .GroupBy(transaction => transaction.Time.Hour);

                            var result = new Dictionary<int, List<(decimal Price, int ItemCount)>>();

                            foreach (var hourGroup in hourGroups)
                            {
                                int hour = hourGroup.Key;

                                var priceCountWithinHour = hourGroup
                                    .GroupBy(item => item.Price)
                                    .Select(priceGroup => (priceGroup.Key, priceGroup.Count()))
                                    .ToList();

                                result.Add(hour, priceCountWithinHour);
                            }

                            return result;
                     }


                        //Or the super linq version.. ^^ don't try at home..
                       return transactions
                        .GroupBy(transaction => transaction.Time.Hour)
                        .Select(
                        group => (
                        group.Key,
                        group.GroupBy(item => item.Price)
                        .Select(priceGroup => (priceGroup.Key, priceGroup.Count()))
                        .ToList()))
                        .ToDictionary(magic => magic.Key, magic => magic.Item2);


                        //Result with your sample input
                        //10, 
                        //     [0]    (64.90, 1)    (decimal, int)
                        //
                        //18,  [0]    (92.70, 1)    (decimal, int)
                        //     [1]    (29.08, 1)    (decimal, int)
                                         */
                                    }
            }
            Console.ReadKey();
        }

        private static void DebugInput(ImportTransactionsData dataInput)
        {
            List<Transactions> data = dataInput.Data;

            for (int i = 0; i < dataInput.Data.Count; i++)
            {
                Console.WriteLine(dataInput.Data[i]);
            }
        }
    }
}
