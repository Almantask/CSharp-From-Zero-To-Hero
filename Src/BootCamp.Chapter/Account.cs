using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
	public class Account
	{
		private string _name;
		private List<float> _balances;
		Account(string name, List<float> balances)
		{
			if (!SetName(name))
			{
				throw new InvalidBalancesException($"Invalid name: {name}");
			}
			_balances = balances;
		}
		//Account(string personBalances)
		//{
		//	string name;
		//	List<float> balances;
		//	ExceptionSplitPersonBalancesString(personBalances, out name, out balances);

			
		//}

		public float? GetCurrentBalance()
		{
			//Return null if no balances
			if (_balances == null || _balances.Count == 0)
			{
				return null;
			}

			return _balances[^1];
		}

		public string GetName()
		{
			return _name;
		}

		public bool SetName(string name)
		{
			if (!IsValidName(name))
			{
				return false;
			}

			_name = name;
			return true;
		}

		public float? GetBiggestLoss()
		{
			//Return null if there's not enough balance entries to get a loss
			if (_balances.Count < 2)
			{
				return null;
			}

			float biggestLoss = float.MaxValue;

			//Check losses
			for (int balanceIndexStart = 0;  balanceIndexStart < _balances.Count - 1; balanceIndexStart++)//-1 since we're grabbing pairs
			{
				float loss = _balances[balanceIndexStart + 1] - _balances[balanceIndexStart];

				if (loss < biggestLoss)
				{
					biggestLoss = loss;
				}
			}

			return biggestLoss;
		}

		public float GetHighestBalance()
		{
			float highestBalance = float.MinValue;

			foreach (float balance in _balances)
			{
				if (balance > highestBalance)
				{
					highestBalance = balance;
				}
			}

			return highestBalance;
		}

		public static bool IsValidName(string name)
		{
			//Verify if valid name ('.' is only valid at the end of the name)
			if (!(name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '\'' || c == '-') || (name.IndexOf('.') == (name.Length - 1))))
			{
				return false;
			}

			return true;
		}
		public static bool SplitPersonBalancesString(string personBalances, out string person, out List<float> balances, string delimiter = ", ")
		{
			person = null;
			balances = null;

			//Return false if input string is null or empty
			if (personBalances == null || personBalances.Length == 0)
			{
				return false;
			}

			//Split the input
			string[] personBalancesArray = personBalances.Split(delimiter);

			//Check that name is valid (index 0 is the name)
			if (!IsValidName(personBalancesArray[0]))
			{
				return false;
			}

			person = personBalancesArray[0];

			//Remaining indexes are balances
			balances = new List<float>(personBalancesArray.Length - 1);
			for (int balanceIndex = 1; balanceIndex < personBalancesArray.Length; balanceIndex++)
			{
				float balance;
				bool isConverted = Single.TryParse(personBalancesArray[balanceIndex], NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out balance);

				if (!isConverted)
				{
					return false;
				}

				balances.Add(balance);
			}

			return true;
		}

		public static void ExceptionSplitPersonBalancesString(string personBalances, out string person, out List<float> balances, string delimiter = ",")
		{
			//Throw an exception if failed
			if (!SplitPersonBalancesString(personBalances, out person, out balances, delimiter))
			{
				throw new InvalidBalancesException("Invalid name or balance");
			}
		}

		public static List<Account> PeopleBalancesStringsToAccounts(string[] peopleBalances)
		{
			List<Account> accounts = new List<Account>();
			foreach (string personBalances in peopleBalances)
			{
				string name;
				List<float> balances;
				Account.ExceptionSplitPersonBalancesString(personBalances, out name, out balances);
				accounts.Add(new Account(name, balances));
			}

			return accounts;
		}

		//Convert array of strings into the format of "v1, v2 and vn"
		public static string AccountsToFormattedString(List<Account> accounts)
		{
			//Return if no accounts were passed
			if (accounts == null || accounts.Count == 0)
			{
				return "";
			}

			//Convert to array of just the names
			string[] names = new string[accounts.Count];
			for (int i = 0; i < names.Length; i++)
			{
				names[i] = accounts[i].GetName();
			}

			//Return as is if there's only 1 element
			if (accounts.Count == 1)
			{
				return accounts[0].GetName();
			}

			StringBuilder sb = new StringBuilder();
			sb.AppendJoin(", ", names[..^1]);//Ignore the last value since it uses a different separator
			sb.Append($" and {names[^1]}");

			return sb.ToString();
		}

		public static List<Account> GetAccountsFromFile(string filename)
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
			List<Account> accounts = new List<Account>();
			string personName;
			List<float> balances;
			using (StringReader sr = new StringReader(fileText))
			{
				while (sr.Peek() > 0)//Check not at the end of text string
				{
					//Split string and verify (with throw exception if not valid)
					Account.ExceptionSplitPersonBalancesString(sr.ReadLine(), out personName, out balances, delimiter: ",");
					//Create a new account and add to list
					accounts.Add(new Account(personName, balances));
				}
			}

			return accounts;
		}
	}
}
