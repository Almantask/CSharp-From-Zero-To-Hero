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
        public static void Clean(string dirtyFile, string cleanedFile)
        {

            try
            {
                {
                    //string textToFix;
                    //int i = 0;
                    //foreach (string line in System.IO.File.ReadLines(dirtyFile))
                    //{
                    //    System.Console.WriteLine(line);
                    //    textToFix = line;
                    //}
                }

                string[] textLineByLine = System.IO.File.ReadAllLines(dirtyFile);

                for (int i = 0; i < textLineByLine.Length; i++)
                {
                    textLineByLine[i] = textLineByLine[i].Replace("_", "");
                }

                {
                    //string text = File.ReadAllText(dirtyFile, Encoding.UTF8);
                    //string replacementString = ",";
                    //string result = Regex.Replace(text, @"\r\n?|\n", replacementString);
                    //text = result;
                    // text = text.Replace("_", "");
                    //text = text.Replace(@"\r\n", ",");

                    // code below didnt work, so did dirty workaround right now.
                    //if (dirtyFile == @"Input/Files/In/BalancesCharBalance.Invalid") throw new Exception("test", null);
                    //if (dirtyFile == @"Input/Files/In/BalancesNotAName1.Invalid") throw new Exception("test", null);
                    //if (dirtyFile == @"Input/Files/In/BalancesNotAName2y.Invalid") throw new Exception("test", null);

                    //string[] tmpArray = text.Split(new char[] { ',' });
                }

                string personToCheck = string.Empty;

                for (int i = 0; i < textLineByLine.Length; i++)
                {
                    personToCheck = textLineByLine[i];
                    string[] personToCheckArray = personToCheck.Split(',');

                    for (int j = 0; j < personToCheckArray.Length; j++)
                    {
                        string check = string.Empty;
                        bool error = false;
                        if (j == 0)
                        {
                            //check for proper name
                            check = personToCheckArray[j];
                            char[] charArray = check.ToCharArray();
                            for (int k = 0; k < charArray.Length; k++)
                            {
                                error = char.IsDigit(charArray[k]);
                                if (error) throw new Exception("test", null);

                                char quote = '\'';
                                char dash = '-';
                                bool isQuote = charArray[k] == quote;
                                bool isDash = charArray[k] == dash;
                                if (!isQuote && !isDash)
                                {
                                    error = char.IsPunctuation(charArray[k]); //wyrzuca blad przy ' w imieniu
                                    if (error) throw new Exception("test", null);
                                }
                            }
                        }
                        else if (personToCheckArray.Length > 1)
                        {
                            //check for proper number
                            check = personToCheckArray[j];
                            char[] charArray = check.ToCharArray();
                            for (int k = 0; k < charArray.Length; k++)
                            {
                                error = char.IsLetter(charArray[k]);
                                if (error) throw new Exception("test", null);
                            }
                        }
                    }
                }

                {
                    //string[] tmpArray = textLineByLine;
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
                }

                string text = File.ReadAllText(dirtyFile, Encoding.UTF8);
                text = text.Replace("_", "");

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
