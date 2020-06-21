using BootCamp.Chapter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BootCamp.Chapter.ReportsManagers
{
    class ReportsManagerXML : ReportsManager
    {
        public override List<Transaction> ReadTransactionFile(string path)
        {
            List<Transaction> transactions = new List<Transaction>();
            List<Models.XML.Transaction> xmlTransactions = XmlConvert.DeserializeFile<List<Models.XML.Transaction>>(path);
            foreach (Models.XML.Transaction tr in xmlTransactions)
            {
                if(Transaction.TryParse(tr.ToString(), out Transaction trans))
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
