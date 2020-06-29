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
            Models.XML.TransactionModelxml.Transactions xmlTransactions = XmlConvert.DeserializeFile<Models.XML.TransactionModelxml.Transactions>(path);
            foreach (Models.XML.TransactionModelxml.TransactionsTransaction tr in xmlTransactions.Transaction)
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

        public override void WriteModel<T>(string path, T model)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            string data = XmlConvert.SerializeObject(model);

            WriteTransaction(path, data);
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
