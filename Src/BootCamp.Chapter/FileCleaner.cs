using System;
using System.Collections.Generic;
using System.IO;
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
            if(String.IsNullOrEmpty(dirtyFile) || String.IsNullOrEmpty(cleanedFile))
            {
                throw new ArgumentException("File path is null or empty.");
            }

            var corruptedFileContent = File.ReadAllText(dirtyFile);
            if (String.IsNullOrEmpty(corruptedFileContent))
            {
                File.WriteAllText(cleanedFile, corruptedFileContent);
                return;
            }

            var cleanFileContent = corruptedFileContent.Replace("_", "");

            try
            {
                ValidateName(cleanFileContent);
                ValidateBalance(cleanFileContent);
            }
            catch (Exception ex)
            {
                throw new InvalidBalancesException("Invalid name or Balance format", ex);
            }

            File.WriteAllText(cleanedFile, cleanFileContent);
        }

        public static void ValidateBalance(string fileContent)
        {
            var peopleAndBalances = fileContent.Split(Environment.NewLine);
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                BalanceStats.ConvertToBalanceArray(peopleAndBalances[i]);
            }
        }

        public static void ValidateName(string fileContent)
        {
            var name = BalanceStats.ConvertToArray(fileContent)[0];
            foreach (char letter in name)
            {
                if (!Char.IsLetter(letter) && !letter.Equals(' '))
                {
                    throw new ArgumentException("Name contains invalid characters!");
                }                    
            }
        }
    }
}
