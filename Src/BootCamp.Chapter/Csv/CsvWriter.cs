using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter.Csv
{
    public class CsvWriter : CsvBase
    {
        public CsvWriter(string fileName) : base(fileName)
        {
        }

        public CsvWriter(string fileName, CsvDelimiter delimiter, bool hasHeader, bool hasFooter = default) : base(fileName, delimiter, hasHeader, hasFooter)
        {
        }

        public void WriteAllRows(IEnumerable<CsvRow> csvRows)
        {
            if (csvRows?.Count() == 0)
            {
                throw new ArgumentException("csvRows cannot be null or empty");
            }

            var lines = PopulateRows(csvRows);

            WriteToFile(lines);
        }

        public void WriteAllRows(IEnumerable<CsvRow> csvRows, CsvRow header)
        {
            if (csvRows?.Count() == 0 || header?.Count == 0)
            {
                throw new ArgumentException("csvRows or header cannot be null or empty");
            }

            var lines = PopulateRows(csvRows);

            if (HasHeader && header?.Count != 0)
            {
                lines.Insert(0, CsvRow.ToString(header, Delimiter));
            }

            WriteToFile(lines);
        }

        public void WriteAllRows(IEnumerable<CsvRow> csvRows, CsvRow header, string footer)
        {
            if (csvRows?.Count() == 0 || header?.Count == 0 || footer?.Length == 0)
            {
                throw new ArgumentException("csvRows, header and footer cannot be null or empty");
            }

            var lines = PopulateRows(csvRows);

            if (HasHeader && header?.Count != 0)
            {
                lines.Insert(0, CsvRow.ToString(header, Delimiter));
            }
            if (HasFooter && footer.IsValid())
            {
                lines.Add(footer);
            }

            WriteToFile(lines);
        }

        private IList<string> PopulateRows(IEnumerable<CsvRow> csvRows)
        {
            if (csvRows?.Count() == 0)
            {
                throw new ArgumentException("csvRows cannot be null or empty");
            }

            var lines = new List<string>();

            foreach (var row in csvRows)
            {
                lines.Add(CsvRow.ToString(row, Delimiter));
            }

            return lines;
        }

        private void WriteToFile(IList<string> lines)
        {
            try
            {
                File.WriteAllLines(FileName, lines);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IOException source {ex.Source}");
                throw;
            }
        }
    }
}