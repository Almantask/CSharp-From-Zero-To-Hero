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

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FileName);

                foreach (var row in csvRows)
                {
                    writer.WriteLine(BuildCsvRow(row));
                }
            }
            finally
            {
                writer?.Close();
            }
        }

        public void WriteAllRows(IEnumerable<CsvRow> csvRows, CsvRow header)
        {
            if (csvRows?.Count() == 0 || header?.Count == 0)
            {
                throw new ArgumentException("csvRows or header cannot be null or empty");
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FileName);

                if (HasHeader && header?.Count != 0)
                {
                    writer.WriteLine(BuildCsvRow(header));
                }

                foreach (var row in csvRows)
                {
                    writer.WriteLine(BuildCsvRow(row));
                }
            }
            finally
            {
                writer?.Close();
            }
        }

        public void WriteAllRows(IEnumerable<CsvRow> csvRows, CsvRow header, string footer)
        {
            if (csvRows?.Count() == 0 || header?.Count == 0 || footer?.Count() == 0)
            {
                throw new ArgumentException("csvRows, header and footer cannot be null or empty");
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FileName);

                if (HasHeader && header?.Count != 0)
                {
                    writer?.WriteLine(BuildCsvRow(header));
                }

                foreach (var row in csvRows)
                {
                    writer?.WriteLine(BuildCsvRow(row));
                }

                if (HasFooter && footer.Length != 0)
                {
                    writer?.WriteLine(footer);
                }
            }
            finally
            {
                writer?.Close();
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
            finally
            {
                writer?.Close();
            }
        }
    }
}