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
                if (IsNullOrEmpty(dirtyFile) || IsNullOrEmpty(cleanedFile))
                {
                    throw new ArgumentException();
                }
                string dirtyFileExtension = Path.GetExtension(dirtyFile);

                if (dirtyFileExtension.Contains("clean") || dirtyFileExtension.Contains("empty"))
                {
                    File.Copy(dirtyFile, cleanedFile);
                    Console.WriteLine(" The file has no corruption - there is nothing to clean up.");
                    return;
                }

                using (StreamReader sr = new StreamReader(dirtyFile))
                {
                    StringBuilder sb = new StringBuilder();
                    while (!sr.EndOfStream)
                    {
                        string raw = sr.ReadLine();
                        string preProcess = raw.Replace("_", "");
                        string[] balance = preProcess.Split(",");
                        ValidatePerson(balance);

                        sb.AppendLine(preProcess);
                    }
                    string output = sb.ToString().TrimEnd();
                    File.AppendAllText(cleanedFile, output);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private static bool IsNullOrEmpty(string s)
        {
            if (s == null || s == string.Empty)
                return true;
            return false;
        }
        private static void ValidatePerson(string[] data)
        {
            string name = data[0];
            foreach (char c in data[0])
            {
                if (Char.IsDigit(c) || c == '.')
                {
                    throw new InvalidBalancesException($"{nameof(name)} is invalid ", new ArgumentException());
                }
            }
            if (data.Length > 1)
            {
                for (int i = 1; i < data.Length; i++)
                {
                    string temp = data[i].Replace("£", "");  //remove currency symbol
                    var isNumber = double.TryParse(temp, out _);
                    if (!isNumber)
                    {
                        throw new InvalidBalancesException($"{data[i]} is not a number ", new ArgumentException());
                    }
                }
            }


        }
    }
}
