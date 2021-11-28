using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ImportTransactionsData dataInput = new ImportTransactionsData();
            string filePath = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv";
            dataInput.ImportTransactionsDataT(filePath);

            List<Transactions> data = dataInput.Data;

            for (int i=0; i<dataInput.Data.Count;i++)
            {
               Console.WriteLine( dataInput.Data[i]);
            }

            Console.ReadKey();
        }
    }
}
