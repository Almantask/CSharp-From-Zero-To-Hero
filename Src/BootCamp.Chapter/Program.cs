using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
			//Args should have 3 variables
			if (args.Length != 3) throw new InvalidCommandException();
			//0: ValidTransactionsFile
			string transactionFile = args[0];
			//1: cmd
			string cmdAndArgs = args[1];
			//2: OutputFile
			string outputFile = args[2];
			
			//Grab Transaction objects from given file
			List<Transaction> transactions = Transaction.ToTransaction(transactionFile).ToList();

			//Run command
			TransactionCommand transactionCmd = new TransactionCommand();
			string resultText = transactionCmd.RunCmd(transactions, cmdAndArgs);

			//Save to output file
			File.WriteAllText(outputFile, resultText);
		}
	}
}
