using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.ReportsManagers
{
    class ReportsManagerXML : IReportsManager
    {
        public List<Transaction> ReadTransactionFile(string path)
        {
            throw new NotImplementedException();
        }

        public void WriteCityTransaction(string path, IEnumerable<string> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            throw new NotImplementedException();
        }

        public void WriteTimeTransaction(string path, IEnumerable<string> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            throw new NotImplementedException();
        }
    }
}
