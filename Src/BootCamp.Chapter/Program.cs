using BootCamp.Chapter.DataReader;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //IExcelDataReader excelDataReader = new ExcelCsvReader("Input/MOCK_DATA.csv");
            ContactsCenter contactsCenter = new ContactsCenter("Input/MOCK_DATA.csv");
        }
    }
}
