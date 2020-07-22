using System;
using BootCamp.Chapter.Commands;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            Console.WriteLine("Please input the commands");
            // "C:\Users\Matthew\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv" "city -max -money" "C:\Users\Matthew\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\"
            string userInput = Console.ReadLine();
            Console.WriteLine(ArgumentsParser.TryParse(userInput, out string [] args));
            TransactionDataParser transactionDataParser = new TransactionDataParser(args[0]);

            foreach(var transaction in transactionDataParser.Transactions)
            {
                Console.WriteLine(transaction.TimePurchased);
            }

            TimeCommand timeCommand = new TimeCommand("time", args[2]);
            timeCommand.ExecuteCommand(transactionDataParser);

            CityCommand cityCommand = new CityCommand("city -min -items", args[2]);
            cityCommand.ExecuteCommand(transactionDataParser);

            DailyCommand dailyCommand = new DailyCommand("daily Ebay -asc", args[2], transactionDataParser);
            dailyCommand.ExecuteCommand(transactionDataParser);

            FullCommand fullCommand = new FullCommand("full -asc", args[2], transactionDataParser);
            fullCommand.ExecuteCommand(transactionDataParser);
        }
    }
}