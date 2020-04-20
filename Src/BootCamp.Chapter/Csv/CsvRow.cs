using System.Collections.Generic;

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
    }
}