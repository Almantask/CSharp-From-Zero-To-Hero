using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.ReportsManagers
{
    class ReportsManagerCSV : IReportsManager
    {
        public List<Transaction> ReadTransactionFile(string path)
        {
            IReportsManager.ValidateFilePath(path);
            List<Transaction> transactions = new List<Transaction>();

            string[] transactionsLines = File.ReadAllText(path).Split(Environment.NewLine);

            foreach (string line in transactionsLines)
            {
                if (Transaction.TryParse(line, out Transaction transaction))
                {
                    transactions.Add(transaction);
                }
            }
            if (transactions.Count == 0)
            {
                throw new NoTransactionsFoundException($"{path} contained no vaid transactions.");
            }

            return transactions;
        }

        public void WriteTimeTransaction(string path, IEnumerable<String> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }

            File.WriteAllLines(path, toBeWritten);
        }
        public void WriteCityTransaction(string path, IEnumerable<String> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }

            foreach (String line in toBeWritten)
            {
                File.WriteAllText(path, line);
            }
        }
    }
}
