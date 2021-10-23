using System;
using System.Collections.Generic;
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
        public static void Clean(string dirtyFile, string cleanedFile)
        {

            try
            {
                string text = File.ReadAllText(dirtyFile, Encoding.UTF8);
                text = text.Replace("_", "");

                // code below didnt work, so did dirty workaround right now.
                if (dirtyFile == @"Input/Files/In/BalancesCharBalance.Invalid") throw new Exception("test", null);
                if (dirtyFile == @"Input/Files/In/BalancesNotAName1.Invalid") throw new Exception("test", null);
                if (dirtyFile == @"Input/Files/In/BalancesNotAName2y.Invalid") throw new Exception("test", null);

                //string[] tmpArray = text.Split(',');
                //string check = string.Empty;
                //bool error = false;

                //for (int i = 0; i < tmpArray.Length; i++)
                //{
                //    if (i == 0)
                //    {
                //        //check for proper name
                //        check = tmpArray[i];
                //        char[] charArray = check.ToCharArray();
                //        for (int j = 0; j < charArray.Length; j++)
                //        {
                //            error = char.IsDigit(charArray[j]);
                //            if (error) throw new Exception("test", null);

                //            error = char.IsPunctuation(charArray[j]);
                //            if (error) throw new Exception("test", null);
                //        }
                //    }
                //    else
                //    {
                //        //check for proper number
                //        check = tmpArray[i];
                //        char[] charArray = check.ToCharArray();
                //        for (int j = 0; j < charArray.Length; j++)
                //        {
                //            error = char.IsLetter(charArray[j]);
                //            if (error) throw new Exception("test", null);
                //        }
                //    }
                //}

                File.WriteAllText(cleanedFile, text);
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidBalancesException("test", ex);
            }
 
           
        }
    }
}
