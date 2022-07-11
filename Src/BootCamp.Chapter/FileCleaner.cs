using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            var dirty = File.ReadAllText(dirtyFile);
            if (dirty == "")
            {
                File.WriteAllText(cleanedFile, "");
                return;
            }

            if (cleanedFile == "" || cleanedFile == null) throw new ArgumentException();

            var clean = dirty.Replace("_", "");
            
            var split = clean.Split(",");
            if (!split[0].All(x => char.IsLetter(x) || x == ' ')) throw new InvalidBalancesException("This is not a name", new Exception());
            //if (!int.TryParse(split[1], out _)) throw new InvalidBalancesException("This is not a number", new Exception());
            if (split[1].Any(Char.IsLetter)) throw new InvalidBalancesException("This is not a number", new Exception());
            
            File.WriteAllText(cleanedFile, clean);
        }
    }
}
