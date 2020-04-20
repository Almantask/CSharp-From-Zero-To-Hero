using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

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
            if (string.IsNullOrEmpty(dirtyFile)) File.WriteAllText(cleanedFile, "");
            const string corruptedCharacter = "_";

            var fileToAnalysis = File.ReadAllText(dirtyFile);

            // Fix file corruption
            var fileFixed = fileToAnalysis.Replace(corruptedCharacter, "");
            ValidateBalancesFile(fileFixed);

            File.WriteAllText(cleanedFile, fileFixed);
        }
        
        public static void ValidateBalancesFile(string balance)
        {
            var lines = balance.Split(Environment.NewLine);

            foreach (var person in lines)
            {
                var stats = person.Split(",");
                ValidateName(stats[0]);
                if (stats.Length <= 1) continue;

                for (var i = 1; i < stats.Length; i++)
                {
                    if(string.IsNullOrEmpty(stats[i])) continue;
                    if(string.IsNullOrWhiteSpace(stats[i])) continue;
                    try
                    {
                        _ = decimal.Parse(stats[i], NumberStyles.Currency, CultureInfo.GetCultureInfo(Constants.CultureLocale));
                    }
                    catch
                    {
                        throw new InvalidBalancesException($"{stats[i]}: invalid currency format.");
                    }
                }
            }
        }

        private static void ValidateName(string name)
        {
            var whiteList = new[]
            {
                ' ',
                '-',
                '\''
            };

            var isValid = name.All(letter => char.IsLetter(letter) || whiteList.Contains(letter));
            if (!isValid) throw new InvalidBalancesException($"{name} is an invalid name.");
        }
    }
}