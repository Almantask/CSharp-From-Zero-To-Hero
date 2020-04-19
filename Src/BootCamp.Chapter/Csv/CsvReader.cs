using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvReader : CsvModel
    {
        public CsvReader(string filePath) : base(filePath)
        {
        }

        public CsvReader(string filePath, CsvDelimiter delimiter, bool hasHeader) : base(filePath, delimiter, hasHeader)
        {
        }

        public List<CsvRow> ReadFile()
        {
            var rows = new List<CsvRow>();

            var line = string.Empty;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(FilePath);
                if (reader.EndOfStream)
                {
                    throw new NoTransactionsFoundException();
                }

                if (HasHeader)
                {
                    Header = new CsvRow(reader.ReadLine().Split((char)Delimiter));
                }

                while ((line = reader.ReadLine()) != null)
                {
                    var row = new CsvRow(line.Split((char)Delimiter));
                    rows.Add(row);
                }
            }
            finally
            {
                reader?.Close();
            }

            return rows;
        }
    }
}