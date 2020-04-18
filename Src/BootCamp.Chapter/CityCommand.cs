using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class CityCommand
    {
        enum Property
        {
            Money,
            ItemCount
        }

        private readonly FileInfo _outputFile;
        private readonly Property _toFilterBy;
        private readonly Func<IEnumerable<Transaction>, string> _extrema;

        public CityCommand(FileInfo outputFile, string arg1, string arg2)
        {
            if (string.IsNullOrEmpty(arg1))
            {
                throw new ArgumentException("Unexpected argument for city command.", nameof(arg1));
            }

            if (string.IsNullOrEmpty(arg2))
            {
                throw new ArgumentException("Unexpected argument for city command.", nameof(arg2));
            }

            _outputFile = outputFile ?? throw new ArgumentNullException(nameof(outputFile));

            _toFilterBy = HandleFilterProperty(arg1, arg2);
            _extrema = HandleExtrema(arg1, arg2);
        }

        private Property HandleFilterProperty(string arg1, string arg2)
        {
            if (arg1 == "-MONEY" || arg2 == "-MONEY")
            {
                return Property.Money;
            }

            if (arg1 == "-ITEMS" || arg2 == "-ITEMS")
            {
                return Property.ItemCount;
            }

            throw new InvalidCommandException();
        }

        private Func<IEnumerable<Transaction>, string> HandleExtrema(string arg1, string arg2)
        {
            if(arg1 == "-MIN" || arg2 == "-MIN")
            {
                return t => _toFilterBy == Property.ItemCount ?
                    t.GroupBy(x => x.City).OrderBy(x => x.Count()).First().Key :
                    t.GroupBy(x => x.City).OrderBy(x => x.Sum(x => x.Price)).First().Key;
            }

            if (arg1 == "-MAX" || arg2 == "-MAX")
            {
                return t => _toFilterBy == Property.ItemCount ?
                    t.GroupBy(x => x.City).OrderByDescending(x => x.Count()).First().Key :
                    t.GroupBy(x => x.City).OrderByDescending(x => x.Sum(x => x.Price)).First().Key;
            }

            throw new InvalidCommandException();
        }

        internal void ExecuteCommand(Stream stream)
        {
            var transactionStream = new TransactionStream(stream);
            var transactions = transactionStream.ReadTransactionUntilEnd().ToArray();

            var result = _extrema(transactions);

            using var outputText = _outputFile.CreateText();
            outputText.Write(result);
        }
    }
}
