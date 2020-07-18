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
        /// 

        public static void Clean(string dirtyFile, string cleanedFile)
        {
            if (string.IsNullOrEmpty(dirtyFile) || string.IsNullOrEmpty(cleanedFile))
            {
                throw new ArgumentException("File can not be null or empty");
            }

            var insideACorruptedFile = File.ReadAllText(dirtyFile);

            if (string.IsNullOrEmpty(insideACorruptedFile))
            {
                File.WriteAllText(cleanedFile, insideACorruptedFile);
                return;
            }

            insideACorruptedFile = insideACorruptedFile.Replace("_", "");
            File.WriteAllText(cleanedFile, insideACorruptedFile);

            try
            {
                var insideAFile = File.ReadAllText(cleanedFile);
                string[] arrayString = insideAFile.Split(Environment.NewLine);
                var people = BalanceStats.ArrayOfPeople(arrayString);
                
            }
            catch (Exception exc)
            {
                throw new InvalidBalancesException("Invalid name or balance", exc);
            }

          
        }
    }
}



