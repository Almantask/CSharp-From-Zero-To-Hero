using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Transactions;
using BootCamp.Chapter.CvsProcessors;

namespace BootCamp.Chapter
{
    public static class ArgumentParser
    {
        public static void Parse(string[] args)
        {
            var transactions = CsvReader.Read(args[0]);
            var arguments = args[1].Split(new char[] {' '}, 2);
            
            var mainCommand = arguments[0];
            if (args.Length == 2 && mainCommand.ToLower() != "full") throw new InvalidCommandException();
            var secondaryCommand = arguments.Length == 2 ? arguments[1] : "";

            string outputCsv = mainCommand.ToLower() switch
            {
                "time" => ByTime.CheckByTime(transactions, secondaryCommand),
                "daily" => Daily.CheckShopDailyByName(transactions, secondaryCommand),
                "city" => ByCity.CheckByCity(transactions, secondaryCommand),
                "full" => throw new NotImplementedException(),
                _ => throw new InvalidCommandException()
            };

            var outputFilePath = args[2];
            File.WriteAllText(outputFilePath, outputCsv);
        }
    }
}