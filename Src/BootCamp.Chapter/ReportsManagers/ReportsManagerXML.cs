using BootCamp.Chapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.ReportsManagers
{
    class ReportsManagerXML : ReportsManager
    {
        public override List<Transaction> ReadTransactionFile(string path)
        {
            throw new NotImplementedException();
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
