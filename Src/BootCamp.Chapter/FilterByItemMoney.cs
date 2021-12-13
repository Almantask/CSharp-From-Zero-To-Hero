using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FilterByItemMoney
    {
        public static void FindCityNameMinMax(ImportTransactionsData dataInput, List<string> command, string outputFilePath)
        {
            if (command[1] == "items" || command[1] == "money")
            {
                ///<summary>>
                ///     prepare data for evaluation
                /// </summary>
                FindMinMaxByCity.GroupDataByCity(dataInput.Data);

                //var curDir = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
                var curDir = "";

                ///<summary>
                ///     search for min or max
                /// </summary>            
                switch (command[2])
                {
                    case "min":
                        if (command[1] == "items")
                        {
                            var cityNameWithLowestItemCount = FindMinMaxByCity.FindCityItemsMin(City.CityList);
                            ExportDataToReport.PrintMinMaxReport(cityNameWithLowestItemCount, Path.Combine(curDir, outputFilePath), "CityItemsMin.csv");
                        }
                        else
                        {
                            var cityNameWithLowestMoneyCount = FindMinMaxByCity.FindCityMoneyMin(City.CityList);
                            ExportDataToReport.PrintMinMaxReport(cityNameWithLowestMoneyCount, Path.Combine(curDir, outputFilePath), "CityMoneyMin.csv");
                        }
                        break;
                    case "max":
                        if (command[1] == "items")
                        {
                            var cityNameWithMaxItemCount = FindMinMaxByCity.FindCityItemsMax(City.CityList);
                            ExportDataToReport.PrintMinMaxReport(cityNameWithMaxItemCount, Path.Combine(curDir, outputFilePath), "CityItemsMax.csv");
                        }
                        else
                        {
                            var cityNameWithMaxMoneyCount = FindMinMaxByCity.FindCityMoneyMax(City.CityList);
                            ExportDataToReport.PrintMinMaxReport(cityNameWithMaxMoneyCount, Path.Combine(curDir, outputFilePath), "CityMoneyMax.csv");
                        }
                        break;
                }
            }
        }
    }
}
