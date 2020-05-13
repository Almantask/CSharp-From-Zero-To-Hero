using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Objects;

namespace BootCamp.Chapter
{
    // TODO: Old one, use as reference.
    public static class ReadCsv
    {
        private static CultureInfo CurrentCultureInfo => CultureInfo.GetCultureInfo("lt-LT");

        public static IEnumerable<Transaction> Read(string file)
        {
            if (string.IsNullOrEmpty(file)) throw new ArgumentNullException(nameof(file));
            if(!File.Exists(file)) throw new FileNotFoundException();
            
            var readFile = File.ReadAllLines(file)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(SplitRow);

            return readFile;
        }

        private static Transaction SplitRow(string row)
        {
            var rowSplit = row.Split(',');
            if (row.Contains('\"')) rowSplit = SplitQuotaCase(rowSplit);
            
            var shop = rowSplit[0];
            var city = rowSplit[1];
            var street = rowSplit[2];
            var item = rowSplit[3];
            // var dateTime = rowSplit[4];
            // var price = rowSplit[5];
            
            // TODO: better exception.
            if (!DateTime.TryParse(rowSplit[4], CurrentCultureInfo, DateTimeStyles.None, 
                out var dateTime)) throw new ArgumentException();
            if (!decimal.TryParse(rowSplit[5],NumberStyles.Any, CurrentCultureInfo,
                out var price)) throw new ArgumentException();

            return new Transaction(shop, city, street, item, dateTime, price);
        }
        
        // TODO: Find a better way or linq mode.
        private static string[] SplitQuotaCase(IEnumerable<string> personInfo)
        {
            var updatedTransaction = new List<string>();
            
            var hasFoundQuota = false;
            var quotaLine = new StringBuilder();
            
            foreach (var info in personInfo)
            {
                if (info.Contains('\"'))
                {
                    if (!hasFoundQuota)
                    {
                        quotaLine.Append($"{info[1..]},");
                        hasFoundQuota = true;
                    }
                    else
                    {
                        quotaLine.Append(info[..^1]);
                        updatedTransaction.Add(quotaLine.ToString());
                        quotaLine = new StringBuilder();
                        hasFoundQuota = false;
                    }
                }
                else if (hasFoundQuota)
                {
                    quotaLine.Append($"{info},");
                }
                else
                {
                    updatedTransaction.Add(info);
                } 
            }

            return updatedTransaction.ToArray();
        }
    }
}