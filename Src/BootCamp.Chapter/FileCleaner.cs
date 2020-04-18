using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            Thread.CurrentThread.CurrentCulture = Config.Culture();

            if (string.IsNullOrEmpty(dirtyFile) || string.IsNullOrEmpty(cleanedFile)) throw new System.ArgumentException(Constants.PathNullOrEmpty);
            if (!File.Exists(dirtyFile)) throw new FileNotFoundException($"File \"{Path.GetFullPath(dirtyFile)}\" does not exist");
            string[] openedFile = null;
            try
            {
                openedFile = File.ReadAllLines(dirtyFile);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{AppDomain.CurrentDomain.FriendlyName} has stopped working");
                Console.ResetColor();
                throw new InvalidBalancesException(Constants.GenericMessageError, ex);
            }
            
            var tempText = new List<string>();
            var log = new List<string>();
            
            for (var i = 0; i < openedFile.Length; i++)
            {
                var newLine = openedFile[i].Replace("_", "");

                try
                {
                    CheckData(newLine);
                }
                catch (Exception ex)
                {
                    log.Add(ex.ToString());
                    log.Add($"File:{Path.GetFileName(dirtyFile)}, Line:{i}");
                    log.Add($"{newLine}{Environment.NewLine}");
                    //throw; // Test porpuse
                    continue;
                }

                tempText.Add(newLine);
            }

            var newText = string.Join(Environment.NewLine, tempText);
            try
            {
                File.WriteAllText(cleanedFile, newText);
            }
            catch (Exception ex)
            {
                var exceptionLog = $"{cleanedFile} cannot be saved to disk.";
                log.Add(exceptionLog);
                log.Add(ex.ToString());

                Console.WriteLine(exceptionLog);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.ResetColor();
            }

            if (log.Count > 1) SaveLog(log);
        }

        // Old CheckData implementation
        //
        //private static void CheckData(string line)
        //{
        //    const string emptyLine = "Line is null or empty.";
        //    const string emptyName = "Name of account not found.";
        //    const string nonLatin = "[Name] has non-latin character valid for name.";
        //    const string money = "Error in money registry.";

        //    var data = line.Split(",");
        //    if (data.Length == 0) throw new InvalidBalancesException(emptyLine);
        //    if (string.IsNullOrWhiteSpace(data[0])) throw new InvalidBalancesException(emptyName);
        //    if (!Regex.IsMatch(data[0], Constants.AllCommonLatinLetters)) throw new InvalidBalancesException(nonLatin);

        //    var successAttempts = 0;
        //    for (var i = 1; i < data.Length; i++)
        //    {
        //        var isCash = decimal.TryParse(data[i],NumberStyles.Currency, CultureInfo.CurrentCulture, out _);
        //        if (!isCash) throw new InvalidBalancesException(money);

        //        successAttempts++;
        //    }

        //    if (successAttempts != data.Length - 1) throw new InvalidBalancesException(Constants.GenericMessageError); //False -> fallback
        //}

        private static void CheckData(string line)
        {
            const string emptyLine = "Line is null or empty.";
            const string emptyName = "Name of account not found.";
            const string nonLatin = "[Name] has non-latin character valid for name.";
            const string moneyError = "Error in money registry.";

            var data = line.Split(",");
            if (data.Length == 0) throw new InvalidBalancesException(emptyLine);
            if (data[0] == "" || string.IsNullOrWhiteSpace(data[0])) throw new InvalidBalancesException(emptyName);
            if (!Regex.IsMatch(data[0], Constants.AllCommonLatinLetters)) throw new InvalidBalancesException(nonLatin);

            var successAttempts = 0;
            for (var i = 1; i < data.Length; i++)
            {
                if (data[i] == "" || string.IsNullOrWhiteSpace(data[i])) throw new InvalidBalancesException($"{moneyError} | \"{data[i]}\" not valid");
                var isMoney = decimal.TryParse(data[i], NumberStyles.Currency, CultureInfo.CurrentCulture, out _);
                if (!isMoney) throw new InvalidBalancesException($"{moneyError} | \"{data[i]}\" not valid.");
                successAttempts++;
            }

            if (successAttempts != data.Length - 1) throw new InvalidBalancesException($"{Constants.GenericMessageError} | Function: CheckData()"); //False -> fallback
        }

        private static void SaveLog(List<string> log)
        {
            var logToString = string.Join(Environment.NewLine, log.ToArray());
            Console.WriteLine(logToString);

            var fileName = $@"Input/Log-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}.txt";
            try
            {
                File.WriteAllText(fileName, logToString);
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Log saved to file: \"{Path.GetFullPath(fileName)}\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Cannot save errors to log.");
            }
        }
    }
}
