using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvReader : CsvBase
    {
        public CsvReader(string filePath) : base(filePath)
        {
        }

        public CsvReader(string filePath, CsvDelimiter delimiter, bool hasHeader) : base(filePath, delimiter, hasHeader)
        {
        }

        public IEnumerable<CsvRow> ReadAllRows()
        {
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
                    Rows.Add(row);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.FileName} was not found");
                throw;
            }
            finally
            {
                reader?.Close();
            }

            return Rows;
        }
    }
}