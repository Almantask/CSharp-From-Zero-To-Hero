using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public static class ReportsManager
    {
        public static List<Transaction> ReadTransactionFileJson(string path)
        {
            CheckFilePathForRead(path);
            List<DTOTransaction> dtoTransactions = JsonConvert.DeserializeObject<List<DTOTransaction>>(File.ReadAllText(path));
            List<Transaction> transactions = new List<Transaction>();

            foreach (DTOTransaction transaction in dtoTransactions)
            {
                if(Transaction.TryParse(transaction.ToString(), out Transaction tr))
                {
                    transactions.Add(tr);
                }
            }

            if (transactions.Count == 0)
            {
                throw new NoTransactionsFoundException($"{path} contained no vaid transactions.");
            }

            return transactions;
        }
        public static List<Transaction> ReadTransactionFileCsv(string path)
        {
            CheckFilePathForRead(path);
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

        public static void WriteTimeTransaction(string path, IEnumerable<String> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }

            File.WriteAllLines(path, toBeWritten);
        }
        public static void WriteCityTransaction(string path, IEnumerable<String> toBeWritten)
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

        private static void CheckFilePathForRead(string path)
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
