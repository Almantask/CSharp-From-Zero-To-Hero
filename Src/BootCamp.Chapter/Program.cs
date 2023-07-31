using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using AutoMapper;

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

			//Create serializer obj
			TransactionSerializer serializer = new TransactionSerializer();

			//Grab Transaction objects from given file
			List<Transaction> transactions = serializer.DeserializeFile(transactionFile).ToList();

			//Run command
			TransactionCommand transactionCmd = new TransactionCommand();
			object resultDTO = transactionCmd.RunCmd(transactions, cmdAndArgs);

			//Save to output file
			serializer.SerializeFile(outputFile, resultDTO);
		}
	}
}