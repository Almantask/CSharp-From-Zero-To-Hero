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

        protected bool TryParseRow(string inputLine, out CsvRow csvRow)
        {
            csvRow = new CsvRow();

            if (!inputLine.IsValid())
            {
                return false;
            }

            var builder = new StringBuilder();
            var hasQuotes = false;

            foreach (var field in inputLine)
            {
                if (field == '\"')
                {
                    hasQuotes = !hasQuotes;
                }
                else if (field == (char)Delimiter)
                {
                    if (!hasQuotes)
                    {
                        csvRow.Add(builder.ToString());
                        builder.Clear();
                    }
                    else
                    {
                        builder.Append(field);
                    }
                }
                else
                {
                    builder.Append(field);
                }
            }
            csvRow.Add(builder.ToString());
            return true;
        }

        protected string BuildCsvRow(CsvRow csvRow)
        {
            if (csvRow is null || csvRow.Count == 0)
            {
                throw new ArgumentNullException($"csvRow cannot be null or empty");
            }

            var firstColumn = true;
            var builder = new StringBuilder();

            foreach (var field in csvRow)
            {
                if (field != null)
                {
                    if (!firstColumn)
                    {
                        builder.Append((char)Delimiter);
                    }

                    builder.Append(field);
                    firstColumn = false;
                }
            }
            return builder.ToString();
        }
    }
}