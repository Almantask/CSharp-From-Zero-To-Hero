using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
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
            var contents = File.ReadAllLines(dirtyFile);
            if (!CheckValidContents(contents))
                contents = RepairCorruptFile(contents);
            File.WriteAllText(cleanedFile, contents);
        }

        public static bool CheckValidContents(string[] Contents)
        {
            Regex validContent = new Regex($"^[a-z0-9, .'£-]*$", RegexOptions.IgnoreCase);
            bool isValid = true;
            foreach (var line in Contents)
            {
                if (!validContent.IsMatch(line))
                    isValid = false;
            }
            if (isValid)
                return true;
            else
                return false;
        }

        public static string[] RepairCorruptFile(string[] Contents)
        {
            List<string> newContents = new List<string>();
            foreach (var line in Contents)
            {
                var newline = Regex.Replace(line, @"(?![a-zA-Z0-9, .\r\n'£-]).", "");
                newContents.Add(newline);
            }
            return newContents.ToArray();
        }
    }
}
