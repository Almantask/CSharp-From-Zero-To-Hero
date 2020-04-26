using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvBase
    {
        public CsvRow Header { get; protected set; } = new CsvRow();
        public string Footer { get; protected set; } = string.Empty;
        public CsvDelimiter Delimiter { get; protected set; } = CsvDelimiter.Comma;
        protected string FileName { get; set; }
        protected bool HasHeader { get; set; }
        protected bool HasFooter { get; set; }
        protected IList<CsvRow> Rows { get; set; } = new List<CsvRow>();

        public CsvBase(string fileName)
        {
            if (!fileName.IsValid())
            {
                throw new ArgumentException("fileName cannot be null or empty");
            }

            FileName = fileName;
        }

        public CsvBase(string fileName, CsvDelimiter delimiter, bool hasHeader)
        {
            if (!fileName.IsValid())
            {
                throw new ArgumentException("fileName cannot be null or empty");
            }

            FileName = fileName;
            Delimiter = delimiter;
            HasHeader = hasHeader;
        }

        public CsvBase(string fileName, CsvDelimiter delimiter, bool hasHeader, bool hasFooter)
        {
            if (!fileName.IsValid())
            {
                throw new ArgumentException("fileName cannot be null or empty");
            }

            FileName = fileName;
            Delimiter = delimiter;
            HasHeader = hasHeader;
            HasFooter = hasFooter;
        }
    }
}