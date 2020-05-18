using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ICommand
    {
        public IEnumerable<String> CreateReport(string[] command, List<Transaction> transactions);
        public void WriteToCSV(string path, IEnumerable<String> toBeWritten);
    }
}
