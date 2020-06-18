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
            throw new NotImplementedException();
        }

        public void WriteTimeTransaction(string path, IEnumerable<string> toBeWritten)
        {
            throw new NotImplementedException();
        }
    }
}
