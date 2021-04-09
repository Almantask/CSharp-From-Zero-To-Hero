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
            if (IsNullOrEmpty(dirtyFile)) throw new ArgumentException();

            if (!File.Exists(dirtyFile)) throw new InvalidBalancesException("No path!", new ArgumentException());
            string text = File.ReadAllText(dirtyFile);
            text = text.Replace("_", "");
            File.WriteAllText(cleanedFile, text);
        }

        private static bool IsNullOrEmpty(string dirtyFile)
        {
            if(dirtyFile == null || dirtyFile.Length == 0)
            {
                return true;
            }
            return false;
        }
    }
}
