using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    public class TransactionJsonParser
    {
        public List<Transaction> Transactions { get; }

        public TransactionJsonParser(string transactionFile)
        {
            if (!File.Exists(transactionFile))
            {
                throw new NoTransactionsFoundException();
            }

            var contents = File.ReadAllText(transactionFile);
           
            contents = contents.Replace("€", "");
            JsonSerializerSettings settings = new JsonSerializerSettings() { Culture = new CultureInfo("nl-NL") };
            Transactions = JsonConvert.DeserializeObject<List<Transaction>>(contents, settings);
        }
    }
}