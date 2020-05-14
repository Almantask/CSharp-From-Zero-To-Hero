using System.IO;
using BootCamp.Chapter.Exceptions;
using BootCamp.Chapter.Processors;

namespace BootCamp.Chapter
{
    public static class ArgumentReader
    {
        public static void ReadThreeArgs(string[] args)
        {
            var transactions = CsvReader.Read(args[0]);
            var arguments = args[1].Split(new char[] {' '}, 2);
            
            var mainCommand = arguments[0];
            var secondaryCommand = arguments.Length == 2 ? arguments[1] : "";

            string outputCsv = mainCommand.ToLower() switch
            {
                "time" => ByTimeProcessor.CheckByTime(transactions, secondaryCommand),
                "daily" => DailyProcessor.CheckShopDailyByName(transactions, secondaryCommand),
                "city" => ByCityProcessor.CheckByCity(transactions, secondaryCommand),
                _ => throw new InvalidCommandException()
            };

            var outputFilePath = args[2];
            File.WriteAllText(outputFilePath, outputCsv);
        }

        public static void ReadTwoArgs(string[] args)
        {
            var transactions = CsvReader.Read(args[0]);
            var mainCommand = args[1].ToLower();
            if (!mainCommand.Equals("full")) throw new InvalidCommandException();
            
            FullProcessor.ExportFullSummary(transactions);
        }
    }
}
