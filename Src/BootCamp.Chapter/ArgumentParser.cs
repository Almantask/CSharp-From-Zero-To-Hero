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
            var secondaryCommand = arguments.Length == 2 ? arguments[1] : "";

            var outputCsv = mainCommand.ToLower() switch
            {
                "time" => ByTime.CheckByTime(transactions, secondaryCommand),
                "daily" => throw new NotImplementedException(),
                "city" => throw new NotImplementedException(),
                "full" => throw new NotImplementedException(),
                _ => default
            };

            try
            {
                File.WriteAllText(args[2], outputCsv);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}