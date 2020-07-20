using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            Console.WriteLine("Please input the commands");
            // "C:\Users\Matthew\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv" "time" "C:\Users\Matthew\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\"
            string userInput = Console.ReadLine();
            Console.WriteLine(ArgumentsParser.TryParse(userInput, out string [] args));
            TransactionDataParser transactionDataParser = new TransactionDataParser(args[0]);

            foreach(var transaction in transactionDataParser.Transactions)
            {
                Console.WriteLine(transaction.TimePurchased);
            }

            TimeCommand timeCommand = new TimeCommand("time", args[2]);
            timeCommand.ExecuteCommand(transactionDataParser);


            CityCommand cityCommand = new CityCommand("city -max -money", args[2]);
            cityCommand.ExecuteCommand(transactionDataParser);
            
            /*
            // Testing
            foreach (KeyValuePair<int, IEnumerable<decimal>> operatingHour in timeCommand.ResultsOfCommand)
            {
                Console.WriteLine(operatingHour.Key);

                foreach (var value in operatingHour.Value)
                {
                    Console.WriteLine(value);
                }
            }
            */
        }
    }
}