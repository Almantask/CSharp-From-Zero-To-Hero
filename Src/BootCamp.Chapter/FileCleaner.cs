using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        private const string CorruptedChar = "_"; // The corrupted characters that will be cleaned up in the file
        private const string ReplacementChar = ""; // What will replace corrupted characters in the cleaned file

        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            if (File.Exists(dirtyFile))
            {
                var corruptedLines = File.ReadAllLines(dirtyFile);
                var fixedLines = new string[corruptedLines.Length];

                for (int i = 0; i < corruptedLines.Length; i++)
                {
                    var fixedLine = corruptedLines[i].Replace(CorruptedChar, ReplacementChar);
                    fixedLines[i] = fixedLine;
                }

                if (fixedLines.Length == 0)
                {
                    File.WriteAllText(cleanedFile, "");
                    return;
                }

                using (var stream = File.OpenWrite(cleanedFile))
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    for (int i = 0; i < fixedLines.Length - 1; i++) // We write lines all the way until the last line to avoid adding a linebreak at the end of the file
                    {
                        writer.WriteLine(fixedLines[i]);
                    }
                    writer.Write(fixedLines[fixedLines.Length - 1]); // We add the last line without a linebreak at the end
                }

                FileUtilities.ValidateFile(cleanedFile, CultureInfo.GetCultureInfo("en-GB"));
            }
            else
            {
                throw new System.ArgumentException($"File: \"{Path.GetFullPath(dirtyFile)}\", does not exist.");
            }
        }
    }
}
