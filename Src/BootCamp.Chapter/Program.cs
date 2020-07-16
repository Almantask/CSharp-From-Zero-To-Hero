using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please input the commands");
            // "C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv" "12 12" "C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\"
            string userInput = Console.ReadLine();
            Console.WriteLine(ArgumentsParser.TryParse(userInput, out string [] args));
            TransactionDataParser transactionDataParser = new TransactionDataParser(args[0]);

            foreach(var transaction in transactionDataParser.Transactions)
            {
                Console.WriteLine(transaction.ItemName);
            }

        }
    }
}