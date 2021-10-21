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
            string text = File.ReadAllText(dirtyFile, Encoding.UTF8);
            text = text.Replace("_", "");
            File.WriteAllText(cleanedFile, text);

            //File.WriteAllText(cleanedFile, "a");
        }
    }
}
