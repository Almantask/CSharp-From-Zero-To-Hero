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

        public CsvWriter(string fileName, CsvDelimiter delimiter, bool hasHeader) : base(fileName, delimiter, hasHeader)
        {
        }

        public CsvWriter(string fileName, CsvDelimiter delimiter, bool hasHeader, bool hasFooter) : base(fileName, delimiter, hasHeader, hasFooter)
        {
        }

        public void WriteAllRows(IEnumerable<CsvRow> csvRows)
        {
            if (csvRows?.Count() == 0)
            {
                throw new ArgumentException("csvRows cannot be null or empty");
            }

            var lines = PopulateRows(csvRows);

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

        public void WriteAllRows(IEnumerable<CsvRow> csvRows, CsvRow header)
        {
            if (csvRows?.Count() == 0 || header?.Count == 0)
            {
                throw new ArgumentException("csvRows or header cannot be null or empty");
            }

            var lines = PopulateRows(csvRows);

            if (HasHeader && header?.Count != 0)
            {
                lines.Insert(0, BuildCsvRow(header));
            }

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

        public void WriteAllRows(IEnumerable<CsvRow> csvRows, CsvRow header, string footer)
        {
            if (csvRows?.Count() == 0 || header?.Count == 0 || footer?.Length == 0)
            {
                throw new ArgumentException("csvRows, header and footer cannot be null or empty");
            }

            var lines = PopulateRows(csvRows);

            if (HasHeader && header?.Count != 0)
            {
                lines.Insert(0, BuildCsvRow(header));
            }
            if (HasFooter && footer.IsValid())
            {
                lines.Add(footer);
            }

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

        public void AppendRow(CsvRow row)
        {
            if (row?.Count == 0)
            {
                throw new ArgumentException("row cannot be null or empty");
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FileName, true);
                writer.WriteLine(BuildCsvRow(row));
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.FileName} was not found");
                throw;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IOException source {ex.Source}");
                throw;
            }
            finally
            {
                writer?.Close();
            }
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
                lines.Add(BuildCsvRow(row));
            }

            return lines;
        }
    }
}