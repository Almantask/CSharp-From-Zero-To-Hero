using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvBase
    {
        protected string FilePath { get; set; }
        protected CsvDelimiter Delimiter { get; set; }
        protected bool HasHeader { get; set; }
        protected CsvRow Header { get; set; } = new CsvRow();
        protected List<CsvRow> Rows { get; set; } = new List<CsvRow>();

        public CsvBase(string filePath)
        {
            FilePath = filePath ?? throw new ArgumentNullException($"filePath cannot be null");

            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException(filePath);
            }
        }

        public CsvBase(string filePath, CsvDelimiter delimiter, bool hasHeader)
        {
            FilePath = filePath ?? throw new ArgumentNullException($"filePath cannot be null");

            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException(filePath);
            }

            Delimiter = delimiter;
            HasHeader = hasHeader;
        }
    }
}