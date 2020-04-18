using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    internal class TransactionStream : IDisposable
    {
        private StreamReader _reader;
        private Transaction _current;

        public TransactionStream(Stream stream)
        {
            _reader = new StreamReader(stream);
            IgnoreHeaderRow();
        }

        private void IgnoreHeaderRow() => _ = _reader.ReadLine();

        public Transaction ReadTransaction()
        {
            var line = _reader.ReadLine(); 
            if (line is null)
            {
                return null;
            }

            _current = ParseLine(line);
            return _current;
        }

        public IEnumerable<Transaction> ReadTransactionUntilEnd()
        {
            var result = ReadTransaction(); 

            while (result != null)
            {
                yield return result;
                result = ReadTransaction(); 
            }

            yield break;
        }

        private Transaction ParseLine(string line)
        {
            var parser = new CsvLineParser(line);
            var transaction = new Transaction();
            transaction.ShopName = parser.ParseNextField();
            transaction.City = parser.ParseNextField();
            transaction.Street = parser.ParseNextField();
            transaction.Item = parser.ParseNextField();
            transaction.Time = DateTimeOffset.Parse(parser.ParseNextField());
            transaction.Price = decimal.Parse(parser.ParseNextField(), NumberStyles.Currency);
            return transaction;
        }

        public void Dispose() => _reader.Dispose();
    }
}
