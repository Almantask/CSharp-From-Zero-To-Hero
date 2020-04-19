using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvBase
    {
        public CsvRow Header { get; protected set; } = new CsvRow();

        protected string FilePath { get; set; }
        protected CsvDelimiter Delimiter { get; set; }
        protected bool HasHeader { get; set; }

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

        protected string BuildCsvRow(CsvRow csvRow)
        {
            var builder = new StringBuilder();

            var firstColumn = true;

            foreach (var value in csvRow)
            {
                if (value != null)
                {
                    if (!firstColumn)
                    {
                        builder.Append(Delimiter);
                    }

                    builder.Append(value);

                    firstColumn = false;
                }
            }

            return builder.ToString();
        }
    }
}