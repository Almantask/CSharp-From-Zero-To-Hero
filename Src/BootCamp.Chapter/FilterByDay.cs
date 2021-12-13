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
            string shopName = string.Empty;
            string fileName = "Daily" + command[1] + ".csv";
            if (command.Count > 2) shopName = command[1] + " " + command[2];
            if (command.Count == 2) shopName = command[1];

            Time.GroupByShopName(dataInput.Data);

            var gatheredData2 = DailyRepData.DataList.Where(name => name.ShopName == shopName);
            var fullWeek = gatheredData2.Where(name => name.ShopName == shopName)
                .GroupBy(day => day.WeekDay);

            List<string> writeDataToFile = new List<string>();

            List<string> mondayDataToWrite, tuesdayDataToWrite, wednesdayDataToWrite, thursdayDataToWrite, fridayDataToWrite, saturdayDataToWrite, sundayDataToWrite;
            GatherDataForFullWeek(fullWeek, out mondayDataToWrite, out tuesdayDataToWrite, out wednesdayDataToWrite, out thursdayDataToWrite, out fridayDataToWrite, out saturdayDataToWrite, out sundayDataToWrite);

            List<List<string>> writeData = new List<List<string>>();
            CreateList(mondayDataToWrite, tuesdayDataToWrite, wednesdayDataToWrite, thursdayDataToWrite, fridayDataToWrite, saturdayDataToWrite, sundayDataToWrite, writeData);

            ExportDataToReport.PrintDailyReport(writeData, Path.Combine(curDir, outputFilePath), shopName, fileName);
        }

        private static void GatherDataForFullWeek(IEnumerable<IGrouping<string, DailyRepData>> fullWeek, out List<string> mondayDataToWrite, out List<string> tuesdayDataToWrite, out List<string> wednesdayDataToWrite, out List<string> thursdayDataToWrite, out List<string> fridayDataToWrite, out List<string> saturdayDataToWrite, out List<string> sundayDataToWrite)
        {
            mondayDataToWrite = new List<string>();
            var monday = fullWeek.Where(name => name.Key.ToLowerInvariant() == "monday");
            mondayDataToWrite = GatherDataByDay(monday);

            tuesdayDataToWrite = new List<string>();
            var tuesday = fullWeek?.Where(name => name.Key.ToLowerInvariant() == "tuesday");
            tuesdayDataToWrite = GatherDataByDay(tuesday);

            wednesdayDataToWrite = new List<string>();
            var wednesday = fullWeek?.Where(name => name.Key.ToLowerInvariant() == "wednesday");
            wednesdayDataToWrite = GatherDataByDay(wednesday);

            thursdayDataToWrite = new List<string>();
            var thursday = fullWeek?.Where(name => name.Key.ToLowerInvariant() == "thursday");
            thursdayDataToWrite = GatherDataByDay(thursday);

            fridayDataToWrite = new List<string>();
            var friday = fullWeek?.Where(name => name.Key.ToLowerInvariant() == "friday");
            fridayDataToWrite = GatherDataByDay(friday);

            saturdayDataToWrite = new List<string>();
            var saturday = fullWeek?.Where(name => name.Key.ToLowerInvariant() == "saturday");
            saturdayDataToWrite = GatherDataByDay(saturday);

            sundayDataToWrite = new List<string>();
            var sunday = fullWeek?.Where(name => name.Key.ToLowerInvariant() == "sunday");
            sundayDataToWrite = GatherDataByDay(sunday);
        }

        private static void CreateList(List<string> mondayDataToWrite, List<string> tuesdayDataToWrite, List<string> wednesdayDataToWrite, List<string> thursdayDataToWrite, List<string> fridayDataToWrite, List<string> saturdayDataToWrite, List<string> sundayDataToWrite, List<List<string>> writeData)
        {
            writeData.Add(mondayDataToWrite);
            writeData.Add(tuesdayDataToWrite);
            writeData.Add(wednesdayDataToWrite);
            writeData.Add(thursdayDataToWrite);
            writeData.Add(fridayDataToWrite);
            writeData.Add(saturdayDataToWrite);
            writeData.Add(sundayDataToWrite);
        }

        public static List<string> GatherDataByDay(IEnumerable<IGrouping<string, DailyRepData>> data)
        {
            List<string> dataToWrite = new List<string>();
            if (data.Any())
            {
                var name = data.Select(x => x.Key.ToString()).ToArray();
                var day = data.SelectMany(x => x);
                var totalMoney = day.Select(x => x.Price).Sum().ToString();
                dataToWrite.Add(name[0]);
                dataToWrite.Add(totalMoney);
            }

            return dataToWrite;
        }
    }
}
