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
            File.WriteAllText(cleanedFile, "a");
        }

        public static string[] TestClean(string fileToClean)
        {
            var corruptedLines = File.ReadAllLines(fileToClean);
            var fixedLines = new string[corruptedLines.Length];

            for (int i = 0; i < corruptedLines.Length; i++)
            {
                var fixedLine = corruptedLines[i].Replace("_", "");
                fixedLines[i] = fixedLine;
            }

            return fixedLines;
        }
    }
}
