using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
	// This class is used to have a freedom of design, but with tests applied.
	public static class Checks
	{
		const string ERROR_MESSAGE = "N/A.";

		public static string FindMostPoorPerson(string[] peopleAndBalances)
		{
			if (peopleAndBalances is null || peopleAndBalances.Length == 0)
			{
				return ERROR_MESSAGE;
			}

			//Convert strings to accounts
			List<Account> accounts = Account.PeopleBalancesStringsToAccounts(peopleAndBalances);

			//Find poorest person
			float lowestBalance = float.MaxValue;
			List<Account> lowestBalanceAccounts = new List<Account>();

			foreach (Account account in accounts)
			{
				float? balance = account.GetCurrentBalance();
				//Skip if no balance
				if (balance == null)
				{
					continue;
				}

				if (balance < lowestBalance)
				{
					//Clear the old list of accounts
					lowestBalanceAccounts.Clear();
					//Set the new balance
					lowestBalance = (float)balance;
					//Add name to list
					lowestBalanceAccounts.Add(account);
				}
				else if (balance ==  lowestBalance)
				{
					//Add name to list
					lowestBalanceAccounts.Add(account);
				}
			}

			string peopleList = Account.AccountsToFormattedString(lowestBalanceAccounts);

			bool isMultiPeople = lowestBalanceAccounts.Count > 1;
			bool isNegative = lowestBalance < 0;
			float absBiggestLoss = Math.Abs(lowestBalance);

			return $"{peopleList} {(isMultiPeople ? "have" : "has")} the least money. {(isNegative ? "-" : "")}¤{absBiggestLoss}.";
		}

		public static string FindRichestPerson(string[] peopleAndBalances)
		{
			if (peopleAndBalances is null || peopleAndBalances.Length == 0)
			{
				return ERROR_MESSAGE;
			}

			//Convert strings to accounts
			List<Account> accounts = Account.PeopleBalancesStringsToAccounts(peopleAndBalances);

			//Find richest person
			float highestBalance = float.MinValue;
			List<Account> highestBalanceAccounts = new List<Account>();

			foreach (Account account in accounts)
			{
				float? balance = account.GetCurrentBalance();
				//Skip if no balance
				if (balance == null)
				{
					continue;
				}
				if (balance > highestBalance)
				{
					//Clear the old list of accounts
					highestBalanceAccounts.Clear();
					//Set the new balance
					highestBalance = (float)balance;
					//Add name to list
					highestBalanceAccounts.Add(account);
				}
				else if (balance == highestBalance)
				{
					//Add name to list
					highestBalanceAccounts.Add(account);
				}
			}

			string peopleList = Account.AccountsToFormattedString(highestBalanceAccounts);

			bool isMultiPeople = highestBalanceAccounts.Count > 1;
			bool isNegative = highestBalance < 0;
			float absBiggestLoss = Math.Abs(highestBalance);

			return $"{peopleList} {(isMultiPeople ? "are" : "is")} the richest {(isMultiPeople ? "people" : "person")}. {(isNegative ? "-" : "")}¤{absBiggestLoss}.";
		}

		public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
		{
			if (peopleAndBalances is null || peopleAndBalances.Length == 0)
			{
				return ERROR_MESSAGE;
			}

			//Convert strings to accounts
			List<Account> accounts = Account.PeopleBalancesStringsToAccounts(peopleAndBalances);

			//Find richest person
			float biggestLoss = float.MaxValue;
			List<Account> biggestLossAccounts = new List<Account>();

			foreach (Account account in accounts)
			{
				float? loss = account.GetBiggestLoss();

				//Return if couldn't get a loss
				if (loss == null)
				{
					return ERROR_MESSAGE;
				}

				if (loss < biggestLoss)
				{
					//Clear the old list of accounts
					biggestLossAccounts.Clear();
					//Set the new loss
					biggestLoss = (float)loss;
					//Add name to list
					biggestLossAccounts.Add(account);
				}
				else if (loss == biggestLoss)
				{
					//Add name to list
					biggestLossAccounts.Add(account);
				}
			}

			string peopleList = Account.AccountsToFormattedString(biggestLossAccounts);

			//bool isMultiPeople = biggestLossAccounts.Count > 1;
			bool isNegative = biggestLoss < 0;
			float absBiggestLoss = Math.Abs(biggestLoss);

			return $"{peopleList} lost the most money. {(isNegative ? "-" : "")}¤{absBiggestLoss}.";
		}

		public static string FindHighestBalanceEver(string[] peopleAndBalances)
		{
			if (peopleAndBalances is null || peopleAndBalances.Length == 0)
			{
				return ERROR_MESSAGE;
			}

			//Convert strings to accounts
			List<Account> accounts = Account.PeopleBalancesStringsToAccounts(peopleAndBalances);

			//Find person with the highest balance ever
			float highestBalance = float.MinValue;
			List<Account> highestBalanceAccounts = new List<Account>();

			foreach (Account account in accounts)
			{
				float balance = account.GetHighestBalance();

				if (balance > highestBalance)
				{
					//Clear the old list of accounts
					highestBalanceAccounts.Clear();
					//Set the new loss
					highestBalance = balance;
					//Add name to list
					highestBalanceAccounts.Add(account);
				}
				else if (balance == highestBalance)
				{
					//Add name to list
					highestBalanceAccounts.Add(account);
				}
			}

			string peopleList = Account.AccountsToFormattedString(highestBalanceAccounts);

			//bool isMultiPeople = biggestLossAccounts.Count > 1;
			bool isNegative = highestBalance < 0;
			float absBiggestLoss = Math.Abs(highestBalance);

			return $"{peopleList} had the most money ever. {(isNegative ? "-" : "")}¤{absBiggestLoss}.";
		}

		public static string Build(string message, in int padding)
		{
			//Return if blank
			if (message.Equals(""))
			{
				return "";
			}

			//Find length of longest line
			int longestLength = 0;
			//Split message by newlines
			string[] lines = message.Split(Environment.NewLine);
			//Loop and grab longest length
			foreach (string line in lines)
			{
				if (line.Length > longestLength)
				{
					longestLength = line.Length;
				}
			}

			//Build ceiling/floor string
			StringBuilder sbCeiling = new StringBuilder("+");
			sbCeiling.Append(new string('-', (longestLength + (padding * 2))));//Add - for length plus padding on both sides
			sbCeiling.Append("+");
			string ceiling = sbCeiling.ToString();

			//Build other strings needed for the table
			//Padding
			string paddingSpace = new string(' ', padding);
			//Extra lines if there's padding
			string paddingLine = "";
			string paddingLines = "";
			if (padding > 0)
			{
				//Create single line
				StringBuilder sbPaddingLine = new StringBuilder("|");
				sbPaddingLine.Append(new string(' ', (longestLength + (padding * 2))));//length plus padding on both sides
				sbPaddingLine.Append('|');
				paddingLine = sbPaddingLine.ToString();

				//Combine lines
				StringBuilder sbPaddingLines = new StringBuilder();
				for (int i = 0; i < padding; i++)
				{
					sbPaddingLines.AppendLine(paddingLine);
				}
				paddingLines = sbPaddingLines.ToString();
			}

			//Build table
			StringBuilder sbTable = new StringBuilder();
			//Ceiling
			sbTable.AppendLine(ceiling);
			//Top padding
			if (padding > 0)
			{
				sbTable.Append(paddingLines);//Append not AppendLine as padding lines already has trailing newline
			}
			//Text lines with padding
			foreach (string text in lines)
			{
				sbTable.Append("|");
				sbTable.Append(paddingSpace);
				sbTable.Append(text);
				//Add extra padding on the right if the word isn't the longest
				if (text.Length < longestLength)
				{
					sbTable.Append(new string(' ', longestLength - text.Length));
				}
				sbTable.Append(paddingSpace);
				sbTable.AppendLine("|");
			}
			//Bottom padding
			if (padding > 0)
			{
				sbTable.Append(paddingLines);//Append not AppendLine as padding lines already has trailing newline
			}
			//Floor
			sbTable.AppendLine(ceiling);

			return sbTable.ToString();
		}

	public static void Clean(string dirtyFile, string cleanedFile)
		{
			//Throw exception if given bad arguments
			//Check for blanks and nulls
			if (dirtyFile == null || dirtyFile.Equals("") || cleanedFile == null || cleanedFile.Equals(""))
			{
				throw new ArgumentException();
			}

			bool isCleanFromStart = true;
			string dirtyFileText;

			//Read the dirty file
			using (StreamReader sr = new StreamReader(dirtyFile))
			{
				dirtyFileText = sr.ReadToEnd();
			}

			//Delete all '_' in text
			string cleanedFileText = dirtyFileText.Replace("_", "");
			//if the lengths are different then something was fixed and we were given a dirty file
			if (cleanedFileText.Length != dirtyFileText.Length)
			{
				isCleanFromStart = false;
			}

			//Verify data is valid
			IFormatProvider balanceStyle = CultureInfo.InvariantCulture;
			string personName;
			List<float> balances;
			using (StringReader sr = new StringReader(cleanedFileText))
			{
				while (sr.Peek() > 0)//Check not at end of string
				{
					//Split string and verify (with throw exception if not valid)
					Account.ExceptionSplitPersonBalancesString(sr.ReadLine(), out personName, out balances, delimiter: ",");
				}
			}

			if (isCleanFromStart)
			{
				Console.WriteLine("The file has no corruption- there is nothing to clean up.");
			}

			//Save the clean file
			File.WriteAllText(cleanedFile, cleanedFileText);
		}
	}
}
