using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class ConsoleArgumentsParser
    {
        public static void ArgumentsParser(string[] args)
        {
            var inputFile = args[0];
            var parser = new TransactionCVSParser(@$"{inputFile}");
            

            if (args[1] == "city -money -min")
            {
                var outcome = ShopStatistics.FindCityWithLowestSales(parser.Transactions);

                CVSWriter.WriteCityData(args[2], "city", outcome);
            }

            if (args[1] == "city -money -max")
            {
                var outcome = ShopStatistics.FindCityWithHighestSales(parser.Transactions) ;

                CVSWriter.WriteCityData(args[2], "city", outcome);
            }

            if (args[1] == "city -items -max")
            {
                var outcome =  ShopStatistics.FindCityWithHighestSoldItems(parser.Transactions) ;

                CVSWriter.WriteCityData(args[2], "city", outcome);
            }

            if (args[1] == "city -items -min")
            {
                var outcome = ShopStatistics.FindCityWithLowestSoldItems(parser.Transactions) ;

                CVSWriter.WriteCityData(args[2], "city", outcome);
            }




        }
    }
}