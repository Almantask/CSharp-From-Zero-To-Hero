using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.ReportsManagers
{
    public interface IReportsManager
    {
        public List<Transaction> ReadTransactionFile(string path);
        public void WriteTimeTransaction(string path, IEnumerable<String> toBeWritten);
        public void WriteCityTransaction(string path, IEnumerable<String> toBeWritten);
        public static void ValidateFilePath(string path)
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
