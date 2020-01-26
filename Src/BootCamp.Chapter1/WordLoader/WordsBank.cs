using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BootCamp1.Chapter.WordLoader;

namespace BootCamp1.Chapter
{
    public static class WordsBank
    {
        private static readonly Random Randomizer = new Random();

        /// <summary>
        /// Get a random word from a file with new word per each line
        /// </summary>
        /// <param name="wordsFile">File with one word per line</param>
        /// <returns>Random word within a file</returns>
        public static string PickRandomWord(string wordsFile, int difficulty)
        {
            var words = File.ReadAllLines(wordsFile)
                .Where(line => !string.IsNullOrWhiteSpace(line) && line.Length == difficulty)
                .ToArray();

            var isAnyInvalid = words.Any(w =>
                w.Any(c => !char.IsLetter(c)));
            if (isAnyInvalid)
            {
                throw new InvalidWordsFileException($"{wordsFile} contains lines with more than one word or don't have all letters.");
            }

            var count = words.Length;
            if (count == 0)
            {
                throw new InvalidWordsFileException($"No words in file {wordsFile} matching length {difficulty}.");
            }

            var index = Randomizer.Next(0, count);

            return words[index];
        }
    }
}
