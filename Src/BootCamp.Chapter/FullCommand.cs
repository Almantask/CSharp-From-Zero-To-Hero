using System;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class FullCommand
    {
        public FullCommand()
        {
        }

        public EventHandler<FilterCompletedEventArgs> FilterCompleted;

        internal void ExecuteCommand(Stream stream)
        {
            using var transactionStream = new TransactionStream(stream);
            var transactions = transactionStream.ReadTransactionUntilEnd().GroupBy(x => x.ShopName).ToArray(); 

            foreach (var shop in transactions)
            {
                OnFilterCompleted(shop);
            }
        }

        private void OnFilterCompleted(IGrouping<string, Transaction> shop)
        {
            var local = FilterCompleted;
            local?.Invoke(this, new FilterCompletedEventArgs(shop));
        }
    }
}
