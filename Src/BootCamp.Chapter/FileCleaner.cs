using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class FileCleaner
    {
        public string[] AccountArray { get; private set; }
        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public void Clean(string dirtyFile, string cleanedFile)
        {
            string inputText = "";

            try
            {
                inputText = File.ReadAllText(dirtyFile);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }

            File.WriteAllText(cleanedFile, inputText.Replace("_", string.Empty));
            AccountArray = File.ReadAllText(cleanedFile).Replace("£", string.Empty).Split(Environment.NewLine);

            BalanceStats balanceStats = new BalanceStats();
            balanceStats.ParsePeopleAndBalance(AccountArray);
        }
    }
}
