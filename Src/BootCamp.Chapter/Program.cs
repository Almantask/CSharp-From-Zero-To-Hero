using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
		const int PADDING = 3;
		static void Main(string[] args)
		{
			//Fix corrupted file
			string corruptedFilePath = $"Input/Balances.corrupted";
			string newCleanFilePath = $"Input/Balances.cleaned";

			Checks.Clean(corruptedFilePath, newCleanFilePath);

			//Read file
			string[] peopleAndBalances = ReadFile(newCleanFilePath).Split(Environment.NewLine);
			
			//Convert file to accounts
			//List<Account> accounts = Account.GetAccountsFromFile(newCleanFilePath);

			Console.WriteLine(Checks.Build(Checks.FindHighestBalanceEver(peopleAndBalances), PADDING));
			Console.WriteLine(Checks.Build(Checks.FindPersonWithBiggestLoss(peopleAndBalances), PADDING));
			Console.WriteLine(Checks.Build(Checks.FindRichestPerson(peopleAndBalances), PADDING));
			Console.WriteLine(Checks.Build(Checks.FindMostPoorPerson(peopleAndBalances), PADDING));

			Console.ReadLine();
		}

		public static string ReadFile(string filename)
		{
			//Throw exception if given bad argument
			if (filename == null || filename.Equals(""))
			{
				throw new ArgumentException();
			}

			//Read file
			string fileText;
			using (StreamReader sr = new StreamReader(filename))
			{
				fileText = sr.ReadToEnd();
			}

			return fileText;
		}
	}
}
