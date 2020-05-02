using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
   
    public class TransactionCVSParser
    {
        public readonly List<Transaction> Transactions;

        public TransactionCVSParser(string transctionFile)
        {
            if (!File.Exists(transctionFile))
            {
                throw new NoTransactionsFoundException(); 
            }
            var contents = File.ReadAllLines(transctionFile); 

            Transactions = new List<Transaction>() ;

            for (int i = 1; i < contents.Length; i++)
            {
                var isValid = Transaction.TryParse(contents[i], out Transaction transaction);

                if (isValid)
                {
                    Transactions.Add(transaction);
                }
            }

        }
    }
}
