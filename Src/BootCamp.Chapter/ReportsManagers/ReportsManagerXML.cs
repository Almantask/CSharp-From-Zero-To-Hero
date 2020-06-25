using BootCamp.Chapter.Models;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.ReportsManagers
{
    class ReportsManagerXML : ReportsManager
    {
        public override List<Transaction> ReadTransactionFile(string path)
        {
            List<Transaction> transactions = new List<Transaction>();
            List<Models.XML.TransactionModel> xmlTransactions = XmlConvert.DeserializeFile<List<Models.XML.TransactionModel>>(path);
            foreach (Models.XML.TransactionModel tr in xmlTransactions)
            {
                if (Transaction.TryParse(tr.ToString(), out Transaction trans))
                {
                    transactions.Add(trans);
                }
            }
            return transactions;
        }

        public override void WriteCityTransaction(string path, string toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            throw new NotImplementedException();
        }

        public override void WriteTimeTransaction(string path, TimesModel timesModel)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            string data = XmlConvert.SerializeObject(timesModel);

            WriteTransaction(path, data);
        }
    }
}
