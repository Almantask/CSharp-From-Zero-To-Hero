using BootCamp.Chapter.Tests;
using System;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileCleaner
    {
        /// <summary>
        /// Cleans up dirtyFileName
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public void Clean(string dirtyFile, string cleanedFile)
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

            for (int i = 0; i < contents.Length; i++)
            {
                var repairedText = contents[i].Replace("_", "");
                var personData = repairedText.Split(',');

                var name = personData[0].ToString();

                for (int j = 0; j < name.Length - 1; j++)
                {
                    var test = name[j];



                    if (name[j] == '1' || name[j] == '.')
                    {
                        throw new InvalidBalancesException($"Invalid character in the name: {name} on position {j}", new FormatException());
                    }
                }



                CheckAmounts(personData[1..]);


                if (i != contents.Length - 1)
                {
                    repairedText += Environment.NewLine;
                }

                if (i == 0)
                {
                    File.WriteAllText(cleanedFile, repairedText);
                }
                else
                {
                    File.AppendAllText(cleanedFile, repairedText);
                }




            }


        }

        public static void CheckAmounts(string[] amounts)
        {
            //amounts = amounts.Split(", ");
            foreach (var amount in amounts)
            {
                var culture = new CultureInfo("en-GB");
                var isValid = decimal.TryParse(amount, NumberStyles.Currency, culture, out decimal number);
                if (!isValid)
                {
                    throw new InvalidBalancesException("There is a invalid character in the balance", new FormatException());
                }
            }


        }
    }
}