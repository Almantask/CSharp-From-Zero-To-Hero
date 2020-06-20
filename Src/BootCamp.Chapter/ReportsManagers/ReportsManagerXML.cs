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
            foreach(Models.XML.Transaction tr in Deserializer(path).Transactions)
            {
                if(Transaction.TryParse(tr.ToString(), out Transaction trans))
                {
                    transactions.Add(trans);
                }
            }
            return transactions;
        }

        private Models.XML.DTOTransactions Deserializer(string path)
        {
            var serializer = new XmlSerializer(typeof(Models.XML.DTOTransactions));
            using (var reader = new StringReader(path))
            {
                return serializer.Deserialize(reader) as Models.XML.DTOTransactions;
            }
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
            throw new NotImplementedException();
        }
    }
}
