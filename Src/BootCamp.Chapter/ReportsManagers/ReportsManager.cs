using BootCamp.Chapter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.ReportsManagers
{
    public abstract class ReportsManager
    {
        public abstract List<Transaction> ReadTransactionFile(string path);
        public void WriteTransaction(string path, string toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }

            File.WriteAllText(path, toBeWritten);
        }

        public abstract void WriteTimeTransaction(string path, TimesModel timesModel);
        public abstract void WriteCityTransaction(string path, string toBeWritten);

        public void ValidateFilePath(string path)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            if (!File.Exists(path))
            {
                throw new NoTransactionsFoundException($"{path} does not exist.");
            }
            if (new FileInfo(path).Length == 0)
            {
                throw new NoTransactionsFoundException($"{path} is empty");
            }
        }
    }
}
