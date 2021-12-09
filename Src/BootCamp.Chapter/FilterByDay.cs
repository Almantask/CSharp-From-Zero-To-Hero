using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace BootCamp.Chapter
{
    public static class FilterByDay
    {
        public static void PrintDayAndMoneyEarned(ImportTransactionsData dataInput, List<string> command, string outputFilePath)
        {
            //var curDir = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
            var curDir = "";

            Time.GroupByShopName(dataInput.Data);

            var gatheredData = DailyRepData.DataList;
            var groupByShopName = gatheredData.GroupBy(x => x.ShopName).ToList();
            var writeDataToFile = groupByShopName.SelectMany(group => group).ToList();

            string shopName = command[1] + " " + command[2];

            ExportDataToReport.PrintDailyReport(writeDataToFile, Path.Combine(curDir, outputFilePath), shopName);
        }
    }
}
