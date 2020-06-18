using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter.ReportsManagers
{
    public class ReportsManagerJson : ReportsManager
    {
        public override List<Transaction> ReadTransactionFile(string path)
        {
            ValidateFilePath(path);
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

        public override void WriteCityTransaction(string path, string toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            throw new System.NotImplementedException();
        }

        public override void WriteTimeTransaction(string path, string toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            throw new System.NotImplementedException();
        }
    }
}