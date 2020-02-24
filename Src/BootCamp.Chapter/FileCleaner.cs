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
            if (!Test.IsStringValid(_dirtyFile) || !Test.IsStringValid(_cleanedFile))
            {
                throw new ArgumentException("Invalid file path!", _dirtyFile);
            }

            string dirtyData = File.ReadAllText(_dirtyFile);
            if (!Test.IsStringValid(dirtyData))
            {
                File.WriteAllText(_cleanedFile, dirtyData);
            }

            string cleandData = FiltherData(dirtyData);
            File.WriteAllText(_cleanedFile, cleandData);
        }

        private string FiltherData(string dirtyData)
        {
            string cleanData = dirtyData.Replace(_corruptionChar, _emptyChar);
            string[] peopleAndBalance = cleanData.Split(Environment.NewLine);
            if (!AreBalancesValid(peopleAndBalance))
            {
                throw new InvalidBalancesException();
            }
            return cleanData;
        }

        private bool AreBalancesValid(string[] peopleAndBalance)
        {
            foreach (string field in peopleAndBalance)
            {
                string[] account = ArrayOps.ConvertToAccountArray(field, _divider);
                if (!Test.IsName(account[0]) || !Test.IsBalance(account[1..], _cultureInfo))
                {
                    return false;
                }
            }
            return true;
        }
    }
}