using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BootCamp.Chapter;

namespace BootCamp.Chapter
{
    public static class FilterByTime
    {
        public static void FilterByTimeHourRange(ImportTransactionsData dataInput, List<string> command, string outputFilePath)
        {
            ///<summary>
            ///     Data filtered by hour range
            /// </summary>
            if (command.Count > 1 && command[0].ToLowerInvariant() == "time")
            {
                DateTime startTime = Convert.ToDateTime(command[1]);
                DateTime endTime = Convert.ToDateTime(command[2]);
                if (endTime.Hour == 0) endTime = endTime.AddDays(1.0d);

                var dataGroupedByHourRange = Time.GroupByHourRange(dataInput.Data, startTime, endTime);
                var getTotalPriceByHourRange = Time.GetTotalPriceByHour(dataGroupedByHourRange);
                var getItemCountByHourRange = Time.GetItemCountByHour(dataGroupedByHourRange);

                ///<summary>
                ///     Get average money earn, by dividing total price by item count
                /// </summary>
                List<string> avgMoneyPerHour = new List<string>();
                Time.GetAverageMoney(getTotalPriceByHourRange, getItemCountByHourRange, avgMoneyPerHour);

                ///<summary> 
                ///     Get rush hour
                /// </summary>
                List<string> rushHourDataSave = new List<string>();
                Time.GetRushHour(avgMoneyPerHour, rushHourDataSave);

                ///<summary>
                ///     Prepare collected data to export
                /// </summary>
                List<List<string>> fullDayReportData = new List<List<string>>();
                // add start/end time to print correct hour into report!!
                Time.FullDayReportData(getTotalPriceByHourRange, getItemCountByHourRange, avgMoneyPerHour, rushHourDataSave, fullDayReportData);

                ///<summary>
                ///     Export data to FullDayRange.csv
                /// </summary>
                //var curDir = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
                var curDir = "";
               ExportDataToReport.PrintTimeReport(fullDayReportData, Path.Combine(curDir, outputFilePath), "FullDayRange.csv");
            }
        }
    
        public static void FilterByTimeFullDay(ImportTransactionsData dataInput, List<string> command, string outputFilePath)
        {
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
                Time.GetAverageMoney(getTotalPriceByHour, getItemCountByHour, avgMoneyPerHour);

                ///<summary> 
                ///     Get rush hour
                /// </summary>
                List<string> rushHourDataSave = new List<string>();
                Time.GetRushHour(avgMoneyPerHour, rushHourDataSave);

                ///<summary>
                ///     Prepare collected data to export
                /// </summary>
                List<List<string>> fullDayReportData = new List<List<string>>();
                Time.FullDayReportData(getTotalPriceByHour, getItemCountByHour, avgMoneyPerHour, rushHourDataSave, fullDayReportData);

                ///<summary>
                ///     Export data to FullDay.csv
                /// </summary>
                var curDir = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
                ExportDataToReport.PrintTimeReport(fullDayReportData, Path.Combine(curDir, outputFilePath), "FullDay.csv");
            }
        }
    }
}
