using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
		const string ERROR_MESSAGE = "N/A.";

		/// <summary>
		/// Return name and balance(current) of person who had the biggest historic balance.
		/// </summary>
		public static string FindHighestBalanceEver(string[] peopleAndBalances)
		{
			//Convert string array to name and balance arrays
			string[] people;
			float[][] balances;
			bool isConverted = PeoplesBalanceStringToArrays(peopleAndBalances, out people, out balances);
			if (!isConverted)
			{
				return ERROR_MESSAGE;//Error
			}

			//Find the person with the highest balance
			List<int> highestPersonIndex = new List<int>();
			//List<float> highestPersonBalanceIndex = new List<float>();

			//int highestPersonIndex = -1;
			float highestBalance = -1;
			//Loop through each person
			for (int i = 0; i < people.Length; i++)
			{
				foreach (float balance in balances[i])
				{
					if (balance > highestBalance)
					{
						//Clear the old list of names
						highestPersonIndex.Clear();
						//Set the new balance
						highestBalance = balance;
						//Add name to list
						highestPersonIndex.Add(i);
					}
					else if (balance == highestBalance)
					{
						//Add name to list
						highestPersonIndex.Add(i);
					}
				}
			}

			//Create string of highest balance person and their current balance
			//StringBuilder sbResult = new StringBuilder();
			//sbResult.AppendLine(people[highestPersonIndex]);
			//sbResult.Append(balances[highestPersonIndex][^1]);//Last balance is the current balance

			//return TextTable.Build(sbResult.ToString(), PADDING);

			//Make list of people
			string[] peopleListArray = new string[highestPersonIndex.Count];
			for (int i = 0; i < peopleListArray.Length; i++)
			{
				peopleListArray[i] = people[highestPersonIndex[i]];
			}
			string peopleList = ArrayToStringList(peopleListArray);

			return $"{peopleList} had the most money ever. ¤{highestBalance}.";
		}

		/// <summary>
		/// Return name and loss of a person with a biggest loss (balance change negative).
		/// </summary>
		public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
		{
			//Convert string array to name and balance arrays
			string[] people;
			float[][] balances;
			bool isConverted = PeoplesBalanceStringToArrays(peopleAndBalances, out people, out balances);
			if (!isConverted)
			{
				return ERROR_MESSAGE;//Error
			}

			int biggestLossPersonIndex = -1;
			float biggestLoss = 0;

			//Search by pairs to get local losses
			for (int personIndex = 0; personIndex < people.Length; personIndex++)
			{
				//Return if not enough entries to get a loss
				if (balances[personIndex].Length < 2)
				{
					return ERROR_MESSAGE;
				}

				//Check losses
				for (int balanceIndexStart = 0; balanceIndexStart < balances[personIndex].Length - 1; balanceIndexStart++)//-1 since we're grabbing pairs
				{
					float loss = balances[personIndex][balanceIndexStart + 1] - balances[personIndex][balanceIndexStart];

					if (loss < biggestLoss)
					{
						biggestLossPersonIndex = personIndex;
						biggestLoss = loss;
					}
				}
			}

			bool isNegative = biggestLoss < 0;
			float absBiggestLoss = Math.Abs(biggestLoss);

			return $"{people[biggestLossPersonIndex]} lost the most money. {(isNegative ? "-" : "")}¤{absBiggestLoss}.";
		}

		/// <summary>
		/// Return name and current money of the richest person.
		/// </summary>
		public static string FindRichestPerson(string[] peopleAndBalances)
		{
			//Convert string array to name and balance arrays
			string[] people;
			float[][] balances;
			bool isConverted = PeoplesBalanceStringToArrays(peopleAndBalances, out people, out balances);
			if (!isConverted)
			{
				return ERROR_MESSAGE;//Error
			}

			List<int> highestPersonIndex = new List<int>();
			float highestBalance = -1;

			//Find richest people
			for (int personIndex = 0; personIndex < people.Length; personIndex++)
			{
				float balance = balances[personIndex][^1];
				if (balance > highestBalance)
				{
					//Clear the old list of names
					highestPersonIndex.Clear();
					//Set the new balance
					highestBalance = balance;
					//Add name to list
					highestPersonIndex.Add(personIndex);
				}
				else if (balance == highestBalance)
				{
					//Add name to list
					highestPersonIndex.Add(personIndex);
				}
			}

			//Make list of people
			string[] peopleListArray = new string[highestPersonIndex.Count];
			for (int i = 0; i < peopleListArray.Length; i++)
			{
				peopleListArray[i] = people[highestPersonIndex[i]];
			}
			string peopleList = ArrayToStringList(peopleListArray);

			bool isMultiPeople = highestPersonIndex.Count > 1;

			return $"{peopleList} {(isMultiPeople ? "are" : "is")} the richest {(isMultiPeople ? "people" : "person")}. ¤{highestBalance}.";
		}

		/// <summary>
		/// Return name and current money of the most poor person.
		/// </summary>
		public static string FindMostPoorPerson(string[] peopleAndBalances)
		{
			//Convert string array to name and balance arrays
			string[] people;
			float[][] balances;
			bool isConverted = PeoplesBalanceStringToArrays(peopleAndBalances, out people, out balances);
			if (!isConverted)
			{
				return ERROR_MESSAGE;//Error
			}

			List<int> lowestPersonIndex = new List<int>();
			float lowestBalance = float.MaxValue;

			//Find richest people
			for (int personIndex = 0; personIndex < people.Length; personIndex++)
			{
				float balance = balances[personIndex][^1];
				if (balance < lowestBalance)
				{
					//Clear the old list of names
					lowestPersonIndex.Clear();
					//Set the new balance
					lowestBalance = balance;
					//Add name to list
					lowestPersonIndex.Add(personIndex);
				}
				else if (balance == lowestBalance)
				{
					//Add name to list
					lowestPersonIndex.Add(personIndex);
				}
			}

			//Make list of people
			string[] peopleListArray = new string[lowestPersonIndex.Count];
			for (int i = 0; i < peopleListArray.Length; i++)
			{
				peopleListArray[i] = people[lowestPersonIndex[i]];
			}
			string peopleList = ArrayToStringList(peopleListArray);

			bool isMultiPeople = lowestPersonIndex.Count > 1;
			bool isNegative = lowestBalance < 0;
			float absBiggestLoss = Math.Abs(lowestBalance);

			return $"{peopleList} {(isMultiPeople ? "have" : "has")} the least money. {(isNegative ? "-" : "")}¤{absBiggestLoss}.";
		}

		//Return bool if method completed or not
		//Input string "name, balance1, balance2, ... balanceN"
		//Output an array of users
		//Output a 2d array of balances with matching indexes as the user array [userIndex, balanceIndex]
		private static bool PeoplesBalanceStringToArrays(string[] peoplesBalances, out string[] people, out float[][] balances)
		{
			int personCount = peoplesBalances != null ? peoplesBalances.Length : 0;
			people = new string[personCount];
			balances = new float[personCount][];

			//Return if array is empty
			if (peoplesBalances == null || peoplesBalances.Length == 0)
			{
				return false;
			}

			//Convert strings to an array
			for (int personBalanceIndex = 0; personBalanceIndex < personCount; personBalanceIndex++)
			{
				string[] peoplesBalance = peoplesBalances[personBalanceIndex].Split(", ");
				//Index 0 is the name
				people[personBalanceIndex] = peoplesBalance[0];
				//Remaining indexes are the balances
				balances[personBalanceIndex] = new float[peoplesBalance.Length - 1];
				for (int balanceIndex = 0; balanceIndex < balances[personBalanceIndex].Length; balanceIndex++)
				{
					float balance;
					bool isConverted = Single.TryParse(peoplesBalance[balanceIndex + 1], out balance);//Pulling from index + 1 since we're skipping [0] (name)
																									  //Return if balance wasn't a number
					if (!isConverted)
					{
						return false;
					}
					//Set the balance
					balances[personBalanceIndex][balanceIndex] = balance;
				}
			}

			return true;
		}

		//Convert array of strings into the format of "v1, v2 and vn"
		private static string ArrayToStringList(string[] array)
		{
			//Return as is if there's only 1 element
			if (array.Length == 1)
			{
				return array[0];
			}

			StringBuilder sb = new StringBuilder();
			sb.AppendJoin(", ", array[..^1]);//Ignore the last value since it uses a different separator
			sb.Append($" and {array[^1]}");

			return sb.ToString();
		}
	}
}
