using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Csv
{
    public class CsvRow : List<string>
    {
        public CsvRow()
        {
        }

        public CsvRow(IEnumerable<string> collection) : base(collection)
        {
        }

        public CsvRow(params string[] collection) : base(collection)
        {
        }
    }
}