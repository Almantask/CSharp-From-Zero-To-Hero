using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvRow : List<string>
    {
        public CsvRow()
        {
        }

        public CsvRow(IEnumerable<string> collection) : base(collection)
        {
        }

        public static bool TryParse(string inputString, CsvDelimiter delimiter, out CsvRow csvRow)
        {
            csvRow = new CsvRow();

            if (!inputString.IsValid())
            {
                return false;
            }

            var builder = new StringBuilder();
            var isQuote = false;

            foreach (var inputChar in inputString)
            {
                if (inputChar == '\"')
                {
                    isQuote = !isQuote;
                }
                else if (inputChar == (char)delimiter)
                {
                    if (!isQuote)
                    {
                        csvRow.Add(builder.ToString());
                        builder.Clear();
                    }
                    else
                    {
                        builder.Append(inputChar);
                    }
                }
                else
                {
                    builder.Append(inputChar);
                }
            }
            csvRow.Add(builder.ToString().Trim());
            return true;
        }

        public static string ToString(CsvRow csvRow, CsvDelimiter delimiter)
        {
            if (csvRow is null || csvRow.Count == 0)
            {
                throw new ArgumentException("csvRow cannot be null or empty");
            }
            const char spaceChar = ' ';
            var firstColumn = true;
            var builder = new StringBuilder();

            foreach (var field in csvRow)
            {
                if (!firstColumn)
                {
                    builder
                        .Append((char)delimiter)
                        .Append(spaceChar);
                }

                builder.Append(field);
                firstColumn = false;
            }
            return builder.ToString();
        }
    }
}