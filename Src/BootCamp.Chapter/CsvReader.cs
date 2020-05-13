using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using BootCamp.Chapter.Objects;

namespace BootCamp.Chapter
{
    public static class CsvReader
    {
        private static CultureInfo CurrentCultureInfo => CultureInfo.GetCultureInfo("lt-LT");

        public static IEnumerable<Transaction> Read(string file)
        {
            if (string.IsNullOrEmpty(file)) throw new ArgumentNullException(nameof(file));
            if(!File.Exists(file)) throw new NoTransactionsFoundException();

            var readFile = File.ReadAllLines(file);
            if (readFile.Length == 0) throw new NoTransactionsFoundException();
            
            var transaction = readFile
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(SplitRow);

            return transaction;
        }

        private static Transaction SplitRow(string row)
        {
            var rowSplit = Regex
                .Split(row, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))")
                .Select(n => n.Replace("\"", string.Empty).Trim())
                .ToList();
            
            var shop = rowSplit[0];
            var city = rowSplit[1];
            var street = rowSplit[2];
            var item = rowSplit[3];
            
            var isDateTimeValid = DateTimeOffset.TryParse(rowSplit[4], CurrentCultureInfo, DateTimeStyles.None, out var dateTime);
            var isPriceValid = decimal.TryParse(rowSplit[5],NumberStyles.Any, CurrentCultureInfo, out var price);
            // TODO: better exception.
            if (!isDateTimeValid && !isPriceValid) throw new ArgumentException();
            
            return new Transaction(shop, city, street, item, dateTime, price);
        }
    }
}