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
            ///     Check imported data
            ///</summary>
            bool debug = false;
            if (debug)
            {
                DebugInput(dataInput);
            }


            if (command.ToLowerInvariant() == "time")
            {
                //var objectsWithMaxHour = dataInput.Data.GroupBy(o => o.Time.Hour)
                //                .OrderByDescending(g => g.Key)
                //                .Take(1)
                //                .SelectMany(g => g);
                var result = dataInput.Data.GroupBy(element => element.Time.Date)
                     //.SelectMany(group => group.OrderByDescending(g => g.Time.Hour))
                //.Take(1)
                .SelectMany(group => group.Where(element => element.Time.Hour == group.Max(obj => obj.Time.Hour)));

                //var result = dataInput.Data.GroupBy(n => new DateTime(n.Time.Year, n.Time.Month, n.Time.Day, n.Time.Hour, 0, 0))
                //     .SelectMany(group => group.OrderByDescending(g => new DateTime(g.Time.Year, g.Time.Month, g.Time.Day, g.Time.Hour, 0, 0)));

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
