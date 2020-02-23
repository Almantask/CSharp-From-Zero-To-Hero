using System;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileCleaner
    {
        private string _dirtyFile;
        private string _cleanedFile;

        public FileCleaner(string dirtyFile, string cleanedFile)
        {
            _dirtyFile = dirtyFile;
            _cleanedFile = cleanedFile; 
        }

        /// <summary>
        /// Cleans up dirtyFileName
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public void Clean()
        {
            if (String.IsNullOrEmpty(_dirtyFile) || String.IsNullOrEmpty(_cleanedFile))
            {
                throw new ArgumentException("File path is null or empty.");
            }

            var contents = File.ReadAllLines(_dirtyFile);

            if (contents.Length == 0)
            {
                File.WriteAllText(_cleanedFile, "");
            }

            for (int i = 0; i < contents.Length; i++)
            {
                var repairedText = contents[i].Replace("_", "");
                var personData = repairedText.Split(',');

                var name = personData[0];

                for (int j = 0; j < name.Length - 1; j++)
                {
                    if (name[j] == '1' || name[j] == '.')
                    {
                        throw new InvalidBalancesException();
                    }
                }

                CheckAmounts(personData[1..]);

                if (i != contents.Length - 1)
                {
                    repairedText += Environment.NewLine;
                }

                if (i == 0)
                {
                    File.WriteAllText(_cleanedFile, repairedText);
                }
                else
                {
                    File.AppendAllText(_cleanedFile, repairedText);
                }
            }
        }

        public static void CheckAmounts(string[] amounts)
        {
            foreach (var amount in amounts)
            {
                var culture = new CultureInfo("en-GB");
                var isValid = decimal.TryParse(amount, NumberStyles.Currency, culture, out decimal number);
                if (!isValid)
                {
                    throw new InvalidBalancesException();
                }
            }
        }
    }
}