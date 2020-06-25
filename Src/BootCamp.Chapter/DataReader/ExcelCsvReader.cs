using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.DataReader
{
    public class ExcelCsvReader : IExcelDataReader
    {
        private readonly string _fileToRead;

        public ExcelCsvReader(string file)
        {
            if (!File.Exists(file)) throw new FileNotFoundException();

            _fileToRead = file;
        }

        public string[] GetData()
        {
            if (File.Exists(_fileToRead)) return File.ReadAllLines(_fileToRead);

            return new string[0];
        }
    }
}
