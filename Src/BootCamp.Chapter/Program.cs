using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"Input/Balances.clean";
            ArrayList array = new ArrayList();
            using (StreamReader sr = new StreamReader(input))
            {
                if (!sr.EndOfStream)
                {
                    array.Add(sr.ReadLine().ToString());
                }
                string[] balance = new string[array.Count];
                for(int i = 0; i < array.Count; i++)
                {
                    balance[i] = (string)array[i];
                }
                Console.WriteLine(BalanceStats.FindHighestBalanceEver(balance));
            }
        }
       
    }
}
