using System;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileCleaner
    {
        private readonly string _dirtyFile;
        private readonly string _cleanedFile;

        public FileCleaner(string dirtyFile, string cleanedFile)
        {
            _dirtyFile = dirtyFile;
            _cleanedFile = cleanedFile;
        }

        public void Clean()
        {
            if (!Test.IsStringValid(_dirtyFile))
            {
                throw new ArgumentException("Invalid file path!", _dirtyFile);
            }
            if (!Test.IsStringValid(_cleanedFile))
            {
                throw new ArgumentException("Invalid file path!", _cleanedFile);
            }

            string dirtyData = File.ReadAllText(_dirtyFile);
            if (!Test.IsStringValid(dirtyData))
            {
                File.WriteAllText(_cleanedFile, dirtyData);
            }

            string cleanedData = dirtyData.Replace(Settings.corruptionChar, Settings.emptyChar);
            string testedData = TestData(cleanedData);
            File.WriteAllText(_cleanedFile, testedData);
        }

        private static string TestData(string cleanData)
        {
            string[] peopleAndBalance = cleanData.Split(Environment.NewLine);
            if (!ArrayOps.AreBalancesValid(peopleAndBalance))
            {
                throw new InvalidBalancesException();
            }
            return cleanData;
        }
    }
}