using BootCamp.Chapter.Csv;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Extensions
{
    public static class CsvRowExtensions
    {
        public static string ToString(this CsvRow csvRow, CsvDelimiter delimiter)
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