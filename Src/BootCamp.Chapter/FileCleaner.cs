using System;
using System.IO;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        public static void Clean(string inputFile, string outputFile)
        {
            if (String.IsNullOrEmpty(inputFile) || String.IsNullOrEmpty(outputFile))
            {
                throw new ArgumentException("File path is null or empty.");
            }

            var corruptedFileContent = File.ReadAllText(inputFile);

            if (IsFileClean(corruptedFileContent) || String.IsNullOrEmpty(corruptedFileContent))
            {
                File.WriteAllText(outputFile, corruptedFileContent);
                return;
            }
            
            if (String.IsNullOrEmpty(corruptedFileContent))
            {
                File.WriteAllText(outputFile, corruptedFileContent);
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
               throw new InvalidBalancesException();
            }

            File.WriteAllText(outputFile, cleanFileContent);
        }

        public static bool IsFileClean(string fileContent)
        {
            try
            {
                ValidateBalance(fileContent);
                ValidateName(fileContent);
            }
            catch (Exception ex){
                return false;
            }

            if (fileContent.Contains('_'))
            {
                return false;
            }
            return true;
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
