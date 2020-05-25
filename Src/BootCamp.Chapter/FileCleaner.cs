using System;
using System.Globalization;
using System.IO;

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
            var contents = File.ReadAllLines(dirtyFile);
            if (contents.Length == 0)
            {
                File.WriteAllText(cleanedFile, "");
                return;
            }

            if (!CheckValidContents(contents))
                contents = RepairCorruptFile(contents);

            CheckValidName(contents);

            CheckValidBalance(contents);

            using (StreamWriter writer = new StreamWriter(File.OpenWrite(cleanedFile)))
            {
                for (int i = 0; i < contents.Length - 1; i++)
                {
                    writer.WriteLine(contents[i]);
                }
                // add last line without newline
                writer.Write(contents[contents.Length - 1]);
            }
        }

        /// <summary>
        /// Check if name is valid
        /// </summary>
        /// <param name="Contents">Array of people and balances</param>
        /// <returns>True if valid, else throws InvalidBalancesException</returns>
        public static bool CheckValidName(string[] Contents)
        {
            var isNameValid = true;
            var allowedSpecialChars = new[] { " ", "-", "'" };
            for (int i = 0; i < Contents.Length; i++)
            {
                string name = Contents[i].Split(',')[0];
                for (int j = 0; j < name.Length; j++)
                {
                    if (!(Char.IsLetter(name[j]) || IsAllowedCharacter(name[j], allowedSpecialChars)))
                        throw new InvalidBalancesException($"{name} is not a valid name.");
                }
            }

            return isNameValid;
        }

        /// <summary>
        /// Check if character is in allowed charaters array
        /// </summary>
        /// <param name="Character"></param>
        /// <param name="AllowedSpecialChars">Array of allowed characters</param>
        /// <returns>Is character allowed</returns>
        private static bool IsAllowedCharacter(char Character, string[] AllowedSpecialChars)
        {
            for (int i = 0; i < AllowedSpecialChars.Length; i++)
            {
                if (AllowedSpecialChars[i] == Character.ToString())
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Check if contents of file is valid
        /// </summary>
        /// <param name="Contents">Array of people and balances</param>
        /// <returns>Is contents valid</returns>
        private static bool CheckValidContents(string[] Contents)
        {
            bool isValid = true;
            for (int i = 0; i < Contents.Length; i++)
            {
                if (Contents[i].Contains('_'))
                    isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Check if balance is valid
        /// </summary>
        /// <param name="Contents">Array of people and balances</param>
        /// <returns>Is balance valid</returns>
        private static bool CheckValidBalance(string[] Contents)
        {
            for (int i = 0; i < Contents.Length; i++)
            {
                string[] lineArray = Contents[i].Split(',');
                for (int j = 0; j < lineArray.Length; j++)
                {
                    if (j > 0)
                    {
                        try
                        {
                            if (lineArray[j].Contains('£'))
                                Single.Parse(lineArray[j], NumberStyles.Currency, CultureInfo.GetCultureInfoByIetfLanguageTag("en-GB"));
                            else
                                Single.Parse(lineArray[j], NumberStyles.Currency, CultureInfo.InvariantCulture);
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidBalancesException($"Invalid value {lineArray[j]}", ex);
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Replace "_" with "" in corrupt file
        /// </summary>
        /// <param name="Contents">Array of people and balances</param>
        /// <returns>Clean file without "_"</returns>
        private static string[] RepairCorruptFile(string[] Contents)
        {
            const string corruptedChar = "_";
            const string replaceChar = "";
            var newContents = new string[Contents.Length];
            for (int i = 0; i < Contents.Length; i++)
            {
                var newline = Contents[i].Replace(corruptedChar, replaceChar);
                newContents[i] = newline;
            }

            return newContents;
        }
    }
}
