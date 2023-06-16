using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
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
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            //Throw exception if given bad arguments
            //Check for blanks and nulls
            if (dirtyFile == null || dirtyFile.Equals("") || cleanedFile == null || cleanedFile.Equals(""))
            {
                throw new ArgumentException();
            }

            string dirtyFileText;

			//Read the dirty file
			using (StreamReader sr = new StreamReader(dirtyFile))
            {
                dirtyFileText = sr.ReadToEnd();
            }

            //Delete all '_' in text
            string cleanedFileText = dirtyFileText.Replace("_", "");

            //Verify data is valid
            IFormatProvider balanceStyle = CultureInfo.InvariantCulture;
            using (StringReader sr = new StringReader(cleanedFileText))
            {
                while (sr.Peek() > 0)//Check not at end of string
                {
                    string[] peopleBalances = sr.ReadLine().Split(',');

                    //First index should just be a name (Only letters and spaces)
                    if (!peopleBalances[0].All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '\'' || c == '-'))
                    {
                        throw new InvalidBalancesException();
                    }
                    //Remaining indexes should all be numbers
                    for (int i = 1; i < peopleBalances.Length; i++)
                    {
                        bool isNumber = Single.TryParse(peopleBalances[i], NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out float UnneedeFloat);
                        if (!isNumber)
                        {
							throw new InvalidBalancesException();
						}
                    }
                }
            }

            //Save the clean file
            File.WriteAllText(cleanedFile, cleanedFileText);
		}
    }
}
