using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FileCleaner
    {
        

        public void Clean(string inputFile, string outputFile)
        {
            if (String.IsNullOrEmpty(inputFile) || String.IsNullOrEmpty(outputFile))
            {
                throw new ArgumentException("File path is null or empty.");
            }

            var corruptedFileContent = File.ReadAllText(inputFile);
            if (String.IsNullOrEmpty(corruptedFileContent))
            {
                File.WriteAllText(outputFile, corruptedFileContent);
                return;
            }
            var cleanFileContent = corruptedFileContent.Replace("_", "");
            File.WriteAllText(outputFile, cleanFileContent);

            try
            {
                ValidateName(cleanFileContent);
               // ValidateBalance(cleanFileContent);
            }
            catch (Exception ex)
            {
          //     throw new InvalidBalancesException("");
            }
        }

        public static void ValidateBalance(string fileContent)
        {
            var peopleAndBalances = fileContent.Split(Environment.NewLine);
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                ArrayHandler.ConvertToBalanceArray(peopleAndBalances[i]);
            }
        }

        public static void ValidateName(string fileContent)
        {
            var name = ArrayHandler.ConvertToArray(fileContent)[0];
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
