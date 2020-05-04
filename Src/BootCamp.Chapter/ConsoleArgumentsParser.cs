using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public static class ConsoleArgumentsParser
    {
        public static void ArgumentsParser(string[] args)
        {
            var inputFile = args[0];
            
            if (args.Length != 3)
            {
                throw new InvalidCommandException();
            }
            
            if (!File.Exists(inputFile))
            {
                throw new NoTransactionsFoundException(); 
            }
            
            var parser = new TransactionCVSParser(@$"{inputFile}");
            
            if (parser.Transactions.Count == 0)
            {
                throw new NoTransactionsFoundException(); 
            }

            var splittedCommands = args[1].Split(' '); 

            if (splittedCommands[0] != "city" && splittedCommands[0] != "time")
            {
                throw new InvalidCommandException(); 
            }

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