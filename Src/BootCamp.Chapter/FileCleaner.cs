using System;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileCleaner
    {
        private const string _corruptionChar = "_";
        private const string _emptyChar = "";
        private readonly string _dirtyFile;
        private readonly string _cleanedFile;
        private readonly char _divider;
        private readonly CultureInfo _cultureInfo;

        public FileCleaner(string dirtyFile, string cleanedFile, CultureInfo cultureInfo, char divider)
        {
            _dirtyFile = dirtyFile;
            _cleanedFile = cleanedFile;
            _cultureInfo = cultureInfo;
            _divider = divider;
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

            string cleanedData = dirtyData.Replace(_corruptionChar, _emptyChar);
            string testedData = TestData(cleanedData);
            File.WriteAllText(_cleanedFile, testedData);
        }

        private string TestData(string cleanData)
        {
            string[] peopleAndBalance = cleanData.Split(Environment.NewLine);
            if (!ArrayOps.AreBalancesValid(peopleAndBalance, _divider, _cultureInfo))
            {
                throw new InvalidBalancesException();
            }
            return cleanData;
        }
    }
}