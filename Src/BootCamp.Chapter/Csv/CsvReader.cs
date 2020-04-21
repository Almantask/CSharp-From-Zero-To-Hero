using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter.Csv
{
    public class CsvReader : CsvBase
    {
        public CsvReader(string fileName) : base(fileName)
        {
        }

        public CsvReader(string fileName, CsvDelimiter delimiter, bool hasHeader) : base(fileName, delimiter, hasHeader)
        {
        }

        public IEnumerable<CsvRow> ReadAllRows()
        {
            var line = string.Empty;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(FileName);
                if (reader.EndOfStream)
                {
                    throw new NoTransactionsFoundException();
                }

                if (HasHeader)
                {
                    if (TryParseRow(reader?.ReadLine(), out CsvRow header))
                    {
                        Header = header;
                    }
                }

                while ((line = reader.ReadLine()).IsValid())
                {
                    if (TryParseRow(line, out CsvRow csvRow))
                    {
                        Rows.Add(csvRow);
                    }
                }
            }
            finally
            {
                reader?.Close();
            }

            return Rows;
        }
    }
}