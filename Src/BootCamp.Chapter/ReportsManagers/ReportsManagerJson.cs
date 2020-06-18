using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter.ReportsManagers
{
    public class ReportsManagerJson : IReportsManager
    {
        public List<Transaction> ReadTransactionFile(string path)
        {
            IReportsManager.ValidateFilePath(path);
            List<DTOTransaction> dtoTransactions = JsonConvert.DeserializeObject<List<DTOTransaction>>(File.ReadAllText(path));
            List<Transaction> transactions = new List<Transaction>();

            foreach (DTOTransaction transaction in dtoTransactions)
            {
                if (Transaction.TryParse(transaction.ToString(), out Transaction tr))
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

        public void WriteCityTransaction(string path, IEnumerable<string> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            throw new System.NotImplementedException();
        }

        public void WriteTimeTransaction(string path, IEnumerable<string> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            throw new System.NotImplementedException();
        }
    }
}