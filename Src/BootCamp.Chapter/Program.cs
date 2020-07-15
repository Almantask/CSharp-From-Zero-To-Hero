using System;
using System.Dynamic;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main()
        {
            // "C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv" "12 12" "C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\"
            string userInput = Console.ReadLine();
            string[] args;
            Console.WriteLine(ArgumentsParser.TryParse(userInput, out args));
        }
    }
}
