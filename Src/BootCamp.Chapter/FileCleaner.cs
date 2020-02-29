using System;
using System.Globalization;
using System.IO;
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
        public static string[] Clean(string dirtyFile, string cleanedFile)
        {
            if (String.IsNullOrEmpty(dirtyFile) || String.IsNullOrEmpty(cleanedFile))
            {
                throw new ArgumentException("File path is null or empty.");
            }

            var contents = File.ReadAllLines(dirtyFile);

            if (contents.Length == 0)
            {
                File.WriteAllText(cleanedFile, "");
            }

            var repairedText = "";
            var sb = new StringBuilder(); 
            for (int i = 0; i < contents.Length; i++)
            {
                repairedText = contents[i].Replace("_", "");
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

                ;
                sb.Append(repairedText); 
                
            }

            File.WriteAllText(cleanedFile, sb.ToString()); 
            return sb.ToString().Split(Environment.NewLine); 
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