using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvBase
    {
        public CsvRow Header { get; protected set; } = new CsvRow();
        public CsvDelimiter Delimiter { get; protected set; } = CsvDelimiter.Comma;

        protected string FilePath { get; set; }
        protected bool HasHeader { get; set; }
        protected IList<CsvRow> Rows { get; set; } = new List<CsvRow>();

        public CsvBase(string filePath)
        {
            FilePath = filePath;
        }

        public CsvBase(string filePath, CsvDelimiter delimiter, bool hasHeader)
        {
            if (!filePath.IsValid())
            {
                throw new ArgumentException("filePath cannot be null or empty");
            }

            FilePath = filePath;
            Delimiter = delimiter;
            HasHeader = hasHeader;
        }

        protected bool TryParseRow(string input, out CsvRow csvRow)
        {
            csvRow = new CsvRow();

            if (!input.IsValid())
            {
                return false;
            }

            var builder = new StringBuilder();
            var isQuote = false;

            foreach (var letter in input)
            {
                if (letter == '\"')
                {
                    isQuote = !isQuote;
                }
                else if (letter == (char)Delimiter)
                {
                    if (!isQuote)
                    {
                        csvRow.Add(builder.ToString());
                        builder.Clear();
                    }
                    else
                    {
                        builder.Append(letter);
                    }
                }
                else
                {
                    builder.Append(letter);
                }
            }
            csvRow.Add(builder.ToString().Trim());
            return true;
        }

        protected string BuildCsvRow(CsvRow csvRow)
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
                if (field != null)
                {
                    if (!firstColumn)
                    {
                        builder.Append((char)Delimiter).Append(spaceChar);
                    }

                    builder.Append(field);
                    firstColumn = false;
                }
            }
            return builder.ToString();
        }
    }
}