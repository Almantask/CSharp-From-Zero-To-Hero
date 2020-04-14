using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
   
    class TransactionCVSParser
    {
        private readonly List<Transaction> _transactions;

        TransactionCVSParser(string transctionFile)
        {
            if (!File.Exists(transctionFile))
            {
                throw new NoTransactionsFoundException(); 
            }
            var contents = File.ReadAllLines(transctionFile); 

            _transactions = default;

            for (int i = 1; i < contents.Length; i++)
            {
                var isValid = Transaction.TryParse(contents[i], out Transaction transaction);

                if (isValid)
                {
                    _transactions.Add(transaction);
                }
            }

        }
    }
}
