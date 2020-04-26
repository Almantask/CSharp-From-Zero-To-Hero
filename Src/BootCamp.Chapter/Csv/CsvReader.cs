using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public CsvReader(string fileName, CsvDelimiter delimiter, bool hasHeader, bool hasFooter) : base(fileName, delimiter, hasHeader, hasFooter)
        {
        }

        public IEnumerable<CsvRow> ReadAllRows()
        {
            try
            {
                var reader = File.ReadLines(FileName);

                if (reader?.Any() == false)
                {
                    throw new NoTransactionsFoundException();
                }

                foreach (var line in PopulateLines(reader))
                {
                    if (TryParse(line, out CsvRow csvRow))
                    {
                        Rows.Add(csvRow);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.FileName} was not found");
                throw;
            }

            return Rows;
        }

        private IEnumerable<string> PopulateLines(IEnumerable<string> lines)
        {
            if (lines?.Any() != true)
            {
                throw new ArgumentException("lines cannot be null or empty");
            }

            if (HasHeader && HasFooter)
            {
                TryParse(lines?.First(), out CsvRow header);
                Header = header;
                Footer = lines?.Last().Trim();
                return lines.Skip(1).SkipLast(1);
            }
            else if (HasHeader)
            {
                TryParse(lines?.First(), out CsvRow header);
                Header = header;
                return lines.Skip(1);
            }
            else if (HasFooter)
            {
                Footer = lines?.Last().Trim();
                return lines.SkipLast(1);
            }
            else
            {
                return lines;
            }
        }
    }
}