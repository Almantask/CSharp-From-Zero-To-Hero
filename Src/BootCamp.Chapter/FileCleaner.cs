using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
            if (!File.Exists(dirtyFile)) throw new ArgumentException($"Provided file path \"{dirtyFile}\" does't exist or invalid.");

            var content = File.ReadAllText(dirtyFile);
            var contentArr = content.Split('_');
            string cleaned = String.Join("", contentArr);

            var cleanedArr = cleaned.Split("\r\n");
            for (int i = 0; i < cleanedArr.Length; i++)
            {
                var lineArr = cleanedArr[i].Split(",");
                var name = lineArr[0];
                string pattern = @"[^a-zA-Z '-]";
                bool containsInvalidChars = Regex.IsMatch(name, pattern);
                if (containsInvalidChars)
                {                   
                    throw new InvalidBalancesException($"line {i + 1} of the file is not a valid balance",
                            new InvalidBPersonNameException(name));                    
                }

                for (int j = 1; j < lineArr.Length; j++)
                {
                    string pattern2 = @"[^-.£\d]";
                    bool containsInvalidChars2 = Regex.IsMatch(lineArr[j], pattern2);
                    if (containsInvalidChars2)
                    {
                        throw new InvalidBalancesException($"line {i + 1} of the file is not a valid balance",
                                new InvalidBalanceException(lineArr[j]));
                    }

                }

            }



            File.WriteAllText(cleanedFile, cleaned);
        }
    }
}
