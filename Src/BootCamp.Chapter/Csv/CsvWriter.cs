using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvWriter : CsvBase
    {
        public CsvWriter(string filePath) : base(filePath)
        {
        }

        public CsvWriter(string filePath, CsvDelimiter delimiter, bool hasHeader) : base(filePath, delimiter, hasHeader)
        {
        }

        public void WriteRows(IEnumerable<CsvRow> csvRows)
        {
            if (csvRows?.Count() == 0)
            {
                throw new ArgumentException("csvRows cannot be null or empty");
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FilePath);

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

        public void WriteRows(IEnumerable<CsvRow> csvRows, CsvRow header)
        {
            if (csvRows?.Count() == 0 || header?.Count == 0)
            {
                throw new ArgumentException("csvRows or header cannot be null or empty");
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FilePath);

                if (HasHeader && header.Count != 0)
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

        public void AppendRow(CsvRow row)
        {
            if (row?.Count == 0)
            {
                throw new ArgumentException("row cannot be null or empty");
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(FilePath, true);
                writer.WriteLine(BuildCsvRow(row));
            }
            finally
            {
                writer?.Close();
            }
        }
    }
}