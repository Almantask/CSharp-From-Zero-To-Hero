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
        /// 
        
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            if (string.IsNullOrEmpty(dirtyFile) || string.IsNullOrEmpty(cleanedFile))
            {
                throw new ArgumentException("File can not be null or empty.");
            }
            var insideACorruptedFile = File.ReadAllText(dirtyFile);
            insideACorruptedFile = insideACorruptedFile.Replace("_", "");
            File.WriteAllText(cleanedFile, insideACorruptedFile);

            try
            {
                CheckForInvalidBalances(cleanedFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public static void CheckForInvalidBalances(string insideAFile)
        {
            String[] strlist = insideAFile.Split(Environment.NewLine);
            for (int i = 0; i < strlist.Length; i++)
            {
                Console.WriteLine(strlist[i]);
            }
        }
    }
}
