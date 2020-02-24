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
        private readonly CultureInfo _cultureInfo;

        public FileCleaner(string dirtyFile, string cleanedFile, CultureInfo cultureInfo)
        {
            _dirtyFile = dirtyFile;
            _cleanedFile = cleanedFile;
            _cultureInfo = cultureInfo;
        }

        public void Clean()
        {
            if (!Test.IsStringValid(_dirtyFile) || !Test.IsStringValid(_cleanedFile))
            {
                throw new ArgumentException("Invalid file path!", _dirtyFile);
            }

            string dirtyData = File.ReadAllText(_dirtyFile);
            if (!Test.IsStringValid(dirtyData))
            {
                File.WriteAllText(_cleanedFile, dirtyData);
            }

            string filtheredData = CleanData(dirtyData);

            File.WriteAllText(_cleanedFile, filtheredData);
        }

        private string CleanData(string dirtyData)
        {
            string cleanData = dirtyData.Replace(_corruptionChar, _emptyChar);
            string[] peopleAndBalance = cleanData.Split(Environment.NewLine);
            for (int i = 0; i < peopleAndBalance.Length; i++)
            {
                string[] account = peopleAndBalance[i].Split(',');
                if (!Test.IsName(account[0]) || !Test.IsBalance(account[1..], _cultureInfo))
                {
                    throw new InvalidBalancesException();
                }
            }

            return cleanData;
        }
    }
}