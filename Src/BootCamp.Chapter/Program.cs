using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ImportTransactionsData dataInput = new ImportTransactionsData();

            string filePath = string.Empty;
            List<string> command = new List<string>();
            string outputFilePath = string.Empty;
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();

            if (args == null || args.Length == 0)
            {
                filePath = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv";
                command.Add("time");
                startTime = new DateTime(2021, 1, 1, 0, 11, 0, 0);
                endTime = new DateTime(2021, 1, 1, 0, 17, 0, 0); ;
                outputFilePath = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
            }
            else
            {
                filePath = args[0];
                string[] commandString = args[1].Split(new char[] { '-', ' ' });
                foreach (var data in commandString)
                {
                    command.Add(data);
                }
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

            ///<summary>
            ///     Data filtered by hour range
            /// </summary>
            if (command.Count > 1 && command[0].ToLowerInvariant() == "time")
            {
                startTime = Convert.ToDateTime(command[1]);
                endTime = Convert.ToDateTime(command[2]);
                if (endTime.Hour == 0) endTime = endTime.AddDays(1.0d);

                var dataGroupedByHourRange = Time.GroupByHourRange(dataInput.Data, startTime, endTime);
                var getTotalPriceByHourRange = Time.GetTotalPriceByHour(dataGroupedByHourRange);
                var getItemCountByHourRange = Time.GetItemCountByHour(dataGroupedByHourRange);

                ///<summary>
                ///     Get average money earn, by dividing total price by item count
                /// </summary>
                List<string> avgMoneyPerHour = new List<string>();
                GetAverageMoney(getTotalPriceByHourRange, getItemCountByHourRange, avgMoneyPerHour);

                ///<summary> 
                ///     Get rush hour
                /// </summary>
                List<string> rushHourDataSave = new List<string>();
                GetRushHour(avgMoneyPerHour, rushHourDataSave);

                ///<summary>
                ///     Prepare collected data to export
                /// </summary>
                List<List<string>> fullDayReportData = new List<List<string>>();
                // add start/end time to print correct hour into report!!
                FullDayReportData(getTotalPriceByHourRange, getItemCountByHourRange, avgMoneyPerHour, rushHourDataSave, fullDayReportData);

                ///<summary>
                ///     Export data to FullDay.csv
                /// </summary>
                var curDir = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
                ExportDataToReport.printReport(fullDayReportData, Path.Combine(curDir, outputFilePath), "FullDayRange.csv");
            }

            ///<summary>
            ///     Full day data without time filter
            /// </summary>
            if (command.Count == 1 && command[0].ToLowerInvariant() == "time")
            {
                var dataGroupedByHour = Time.GroupByHour(dataInput.Data);
                var getTotalPriceByHour = Time.GetTotalPriceByHour(dataGroupedByHour);
                var getItemCountByHour = Time.GetItemCountByHour(dataGroupedByHour);

                ///<summary>
                ///     Get average money earn, by dividing total price by item count
                /// </summary>
                List<string> avgMoneyPerHour = new List<string>();
                GetAverageMoney(getTotalPriceByHour, getItemCountByHour, avgMoneyPerHour);

                ///<summary> 
                ///     Get rush hour
                /// </summary>
                List<string> rushHourDataSave = new List<string>();
                GetRushHour(avgMoneyPerHour, rushHourDataSave);

                ///<summary>
                ///     Prepare collected data to export
                /// </summary>
                List<List<string>> fullDayReportData = new List<List<string>>();
                FullDayReportData(getTotalPriceByHour, getItemCountByHour, avgMoneyPerHour, rushHourDataSave, fullDayReportData);

                ///<summary>
                ///     Export data to FullDay.csv
                /// </summary>
                var curDir = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
                ExportDataToReport.printReport(fullDayReportData, Path.Combine(curDir, outputFilePath), "FullDay.csv");
            }

            // old code to evaluate
            {
                  //if (command.ToLowerInvariant() == "time")
            //{
            //    var groupDataByHour = dataInput.Data.GroupBy(element => element.Time.Hour)
            //        .OrderBy(x => x.Key);
                    

            //    var result6 = dataInput.Data.GroupBy(element => element.Time.Hour)
            //       .Select(
            //        kvp => (
            //        kvp.Key,
            //        kvp.GroupBy(item => item.Price)
            //        .Select(priceGroup => (priceGroup.Key, priceGroup.Count()))
            //        .ToList()));

            //    var result7 = dataInput.Data.GroupBy(transaction => transaction.Time.Hour)
            //            .Select(
            //            group => (
            //            group.Key,
            //            group.GroupBy(item => item.Price)
            //            .Select(priceGroup => (priceGroup.Key, priceGroup.Count()))
            //            .ToList()))
            //            .ToDictionary(magic => magic.Key, magic => magic.Item2);


            //    var result = dataInput.Data.GroupBy(element => element.Time.Hour)
            //        .ToDictionary(grp => grp.Key)
            //        .Select(kvp => new
            //        {
            //            Hour = kvp.Key,
            //            ItemCount = kvp.Value.Count(),
            //        }
            //        ).ToList();

            //    var result3 = dataInput.Data.Select(p => new { p.Time.Hour, p.Price })
            //    .GroupBy(element => element.Hour).ToList();

            //    var orderByResult3 = from s in result3
            //                        orderby s.Key
            //                        select s;

            //    var test3 = orderByResult3.ToList();

            //    var totalPrice = 0m;
            //    var itemCountPerHour = 0;
            //    foreach (var hours in test3)
            //    {
            //        foreach( var data in hours)
            //        {
            //            var testtt2 = hours.Count();
            //            Console.WriteLine($"{data.Hour} {data.Price}");
                        
            //            totalPrice += data.Price;
            //        }
            //        itemCountPerHour = hours.Count();
            //    }

            //    //get an hour
            //    var hour = test3[0].Key;
            //    // convert each hour to list
            //    var itemCount = test3[0].ToList();
            //    // get itemCount per hour
            //    var test = itemCount.Count();
            //    // get overall price
            //    var price = 0m;
            //    foreach(var item in itemCount)
            //    {
            //        price += item.Price;
            //    }
                
            //    // pomoc z czatu:
            //    {
            //        /*
            //         public static Dictionary<int, List<(decimal Price, int ItemCount)>> GroupByHour(List<Transactions> transactions)
            //         {
            //                var hourGroups = transactions
            //                .GroupBy(transaction => transaction.Time.Hour);

            //                var result = new Dictionary<int, List<(decimal Price, int ItemCount)>>();

            //                foreach (var hourGroup in hourGroups)
            //                {
            //                    int hour = hourGroup.Key;

            //                    var priceCountWithinHour = hourGroup
            //                        .GroupBy(item => item.Price)
            //                        .Select(priceGroup => (priceGroup.Key, priceGroup.Count()))
            //                        .ToList();

            //                    result.Add(hour, priceCountWithinHour);
            //                }

            //                return result;
            //         }


            //            //Or the super linq version.. ^^ don't try at home..
            //           return transactions
            //            .GroupBy(transaction => transaction.Time.Hour)
            //            .Select(
            //            group => (
            //            group.Key,
            //            group.GroupBy(item => item.Price)
            //            .Select(priceGroup => (priceGroup.Key, priceGroup.Count()))
            //            .ToList()))
            //            .ToDictionary(magic => magic.Key, magic => magic.Item2);


            //            //Result with your sample input
            //            //10, 
            //            //     [0]    (64.90, 1)    (decimal, int)
            //            //
            //            //18,  [0]    (92.70, 1)    (decimal, int)
            //            //     [1]    (29.08, 1)    (decimal, int)
            //                             */
            //                        }
            //}
            }

            Console.ReadKey();
        }

        private static void FullDayReportData(List<decimal> getTotalPriceByHour, List<int> getItemCountByHour, List<string> avgMoneyPerHour, List<string> rushHourDataSave, List<List<string>> fullDayReportData)
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

        private static void GetRushHour(List<string> avgMoneyPerHour, List<string> rushHourDataSave)
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

        private static void GetAverageMoney(List<decimal> getTotalPriceByHourRange, List<int> getItemCountByHourRange, List<string> avgMoneyPerHour)
        {
            for (int i = 0; i < getTotalPriceByHourRange.Count; i++)
            {
                avgMoneyPerHour.Add((getTotalPriceByHourRange[i] / getItemCountByHourRange[i]).ToString("0.##"));
            }
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
