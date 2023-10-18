using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        static void CheckForInvalidCharInName(string[] lineArr)
        {
            string str = lineArr[0];
            if (!(str.All(x => Char.IsLetter(x) || x == ' ' || x == '\'' || x == '-')))
                throw new InvalidBalancesException("Invalid Character in Name", new Exception());
        }

        static void CheckForInvalidCharInBalance(string[] lineArr)
        {
            float balance = 0.0f;
            for (int i = 1; i < lineArr.Length; i++)
            {
                bool tryFloat = float.TryParse(lineArr[i], NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out balance);
                if (!tryFloat) throw new InvalidBalancesException("Balance is not valid", new Exception());
            }

        }

        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            try
            {
                if (dirtyFile == null || dirtyFile.Length == 0)
                {
                    throw new ArgumentException();
                }

                if (!File.Exists(dirtyFile))
                {
                    throw new ArgumentException();
                }

                string stringFile = File.ReadAllText(dirtyFile);

                if (stringFile.Length > 0)
                {
                    if (stringFile.Contains('_'))
                    {
                        stringFile = stringFile.Replace("_", "");
                    }
                    var arrStr = stringFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var str in arrStr)
                    {
                        var lineArr = str.Split(",", StringSplitOptions.RemoveEmptyEntries);
                        CheckForInvalidCharInName(lineArr);
                        CheckForInvalidCharInBalance(lineArr);
                    }
                    File.WriteAllText(cleanedFile, stringFile.ToString());
                }
                File.WriteAllText(cleanedFile, stringFile.ToString());
            }
            catch(InvalidBalancesException e)
            {
                throw e;
            }

}
    }
}
