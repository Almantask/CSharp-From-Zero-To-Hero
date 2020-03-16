using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        private const string invalidMessage = "N/A.";
        private const string currencySymbol = "¤";

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return invalidMessage;
            }

            float highestBalanceEver = GetHighestBalanceEver(peopleAndBalances);
            string[] highestBalanceNames = FindBalanceNames(highestBalanceEver, peopleAndBalances, false);

            return $"{highestBalanceNames[0]} had the most money ever. {currencySymbol}{highestBalanceEver}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return invalidMessage;
            }
            string[][] workingPeopleAndBalances = ReturnJaggedArray(peopleAndBalances);
            for (int i = 0; i < workingPeopleAndBalances.Length; i++)
            {
                if (workingPeopleAndBalances[i].Length <= 2)
                {
                    return invalidMessage;
                }
            }
            float biggestLossEver = GetBiggestLoss(workingPeopleAndBalances[0]);
            string biggestLossNames = workingPeopleAndBalances[0][0];
            for (int i = 0; i < workingPeopleAndBalances.Length; i++)
            {
                float loss = GetBiggestLoss(workingPeopleAndBalances[i]);
                string name = workingPeopleAndBalances[i][0];
                if (loss < biggestLossEver)
                {
                    biggestLossEver = loss;
                    biggestLossNames = name;
                }
            }
            return $"{biggestLossNames} lost the most money. {ConcatMoney(biggestLossEver)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return invalidMessage;
            }

            float highestCurrentBalance = GetHighestCurrentBalance(peopleAndBalances);
            string[] richestPersons = FindBalanceNames(highestCurrentBalance, peopleAndBalances, true);
            return $"{richestPersons[0]} {richestPersons[1]} the richest {richestPersons[2]}. {currencySymbol}{highestCurrentBalance}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return invalidMessage;
            }

            float lowestCurrentBalance = GetLowestCurrentBalance(peopleAndBalances);
            string[] poorestPersons = FindBalanceNames(lowestCurrentBalance, peopleAndBalances, true);
            return $"{poorestPersons[0]} {poorestPersons[3]} the least money. {ConcatMoney(lowestCurrentBalance)}.";
        }

        /// <summary>
        /// Takes an array of strings and returns a jagged array with each string on ", ".
        /// </summary>
        public static string[][] ReturnJaggedArray(string[] peopleAndBalances)
        {
            string[][] parsedBalances = new string[peopleAndBalances.Length][];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArr = peopleAndBalances[i].Split(", ", System.StringSplitOptions.None);
                parsedBalances[i] = tempArr;
            }

            return parsedBalances;
        }

        /// <summary>
        /// Checks if an array is NULL or empty and returns true if any of those conditions are true.
        /// </summary>
        public static bool IsArrayNullOrEmpty(string[] peopleAndBalances)
        {
            return peopleAndBalances == null || peopleAndBalances.Length == 0;
        }

        /// <summary>
        /// Takes an array of strings and returns that array as floats.
        /// </summary>
        public static float[] ConvertStringArrToFloatArr(string[] balances)
        {
            int failLength = 0;
            float[] floatArr = new float[balances.Length];
            for (int i = 0; i < floatArr.Length; i++)
            {
                bool success = float.TryParse(balances[i], out float number);
                if (success)
                {
                    floatArr[i - failLength] = number;
                }
                else
                {
                    failLength++;
                }
            }
            if (failLength == 0)
            {
                return floatArr;
            }
            float[] failFloatArr = new float[floatArr.Length - failLength];
            for (int i = 0; i < failFloatArr.Length; i++)
            {
                failFloatArr[i] = floatArr[i];
            }
            return failFloatArr;
        }

        /// <summary>
        /// Takes an array of floats and returns a single float of the highest value.
        /// </summary>
        public static float GetHighestBalance(float[] balances)
        {
            float highestBalance = balances[0];
            if (balances.Length == 0)
            {
                return highestBalance;
            }
            for (int i = 1; i < balances.Length; i++)
            {
                if (balances[i] > highestBalance)
                {
                    highestBalance = balances[i];
                }
            }
            return highestBalance;
        }

        /// <summary>
        /// Takes an array of names and balances, then returns the highest value of all balances.
        /// </summary>
        /// <param name="peopleAndBalances"></param>
        /// <returns></returns>
        public static float GetHighestBalanceEver(string[] peopleAndBalances)
        {
            string[][] workingPeopleAndBalances = ReturnJaggedArray(peopleAndBalances);
            float highestBalanceEver = GetHighestBalance(ConvertStringArrToFloatArr(workingPeopleAndBalances[0][1..]));
            if (workingPeopleAndBalances.Length == 1)
            {
                return highestBalanceEver;
            }
            for (int i = 1 ; i < workingPeopleAndBalances.Length; i++)
            {
                float balanceToTest = GetHighestBalance(ConvertStringArrToFloatArr(workingPeopleAndBalances[i][1..]));
                if (balanceToTest > highestBalanceEver)
                {
                    highestBalanceEver = balanceToTest;
                }
            }
            return highestBalanceEver;
        }

        public static float GetHighestCurrentBalance(string[] peopleAndBalances)
        {
            string[][] workingPeopleAndBalances = ReturnJaggedArray(peopleAndBalances);
            float highestCurrentBalance = float.Parse(workingPeopleAndBalances[0][^1]);
            if (workingPeopleAndBalances.Length == 1)
            {
                return highestCurrentBalance;
            }
            for (int i = 1; i < workingPeopleAndBalances.Length; i++)
            {
                float balanceToTest = float.Parse(workingPeopleAndBalances[i][^1]);
                if (balanceToTest > highestCurrentBalance)
                {
                    highestCurrentBalance = balanceToTest;
                }
            }
            return highestCurrentBalance;
        }

        public static float GetLowestCurrentBalance(string[] peopleAndBalances)
        {
            string[][] workingPeopleAndBalances = ReturnJaggedArray(peopleAndBalances);
            float lowestCurrentBalance = float.Parse(workingPeopleAndBalances[0][^1]);
            if (workingPeopleAndBalances.Length == 1)
            {
                return lowestCurrentBalance;
            }
            for (int i = 1; i < workingPeopleAndBalances.Length; i++)
            {
                float balanceToTest = float.Parse(workingPeopleAndBalances[i][^1]);
                if (balanceToTest < lowestCurrentBalance)
                {
                    lowestCurrentBalance = balanceToTest;
                }
            }
            return lowestCurrentBalance;
        }

        /// <summary>
        /// Takes a balance then finds and returns all the names that share that balance
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="peopleAndBalances"></param>
        /// <returns></returns>
        public static string[] FindBalanceNames(float balance, string[]peopleAndBalances, bool isCurrent)
        {
            string[][] workingPeopleAndBalances = ReturnJaggedArray(peopleAndBalances);
            string totalNames = "";
            for (int i = 0; i < workingPeopleAndBalances.Length; i++)
            {
                float[] balances = ConvertStringArrToFloatArr(workingPeopleAndBalances[i][1..]);
                bool isBalance = false;
                int isCurrentIndexShift = 0;
                if (isCurrent)
                {
                    isCurrentIndexShift = balances.Length - 1;
                }
                for (int j = 0 + isCurrentIndexShift; j < balances.Length; j++)
                {
                    if(balances[j] == balance)
                    {
                        isBalance = true;
                    }
                }
                if (isBalance)
                {
                    totalNames += $"{workingPeopleAndBalances[i][0]}, ";
                }
            }
            string[] formatedNames = FormatBalanceNames(totalNames);
            return formatedNames;
        }

        /// <summary>
        /// Takes a string of names separated by ', ' and returns a grammatically correct string
        /// </summary>
        /// <param name="balanceNames"></param>
        /// <returns></returns>
        public static string[] FormatBalanceNames(string balanceNames)
        {
            int count = balanceNames.Split(',').Length - 1;
            balanceNames = balanceNames.Remove(balanceNames.Length - 2);
            string[] formatedBalanceNames = { "", "is", "person", "has" };
            if (count == 1)
            {
                formatedBalanceNames[0] = balanceNames;
                return formatedBalanceNames;
            }
            string[] names = balanceNames.Split(',');
            StringBuilder sbNames = new StringBuilder(names[0]);
            if (count == 2)
            {
                sbNames.Append($" and{names[1]}");
                formatedBalanceNames[0] = sbNames.ToString();
            }
            else
            {
                for (int i = 1; i < names.Length - 1; i++)
                {
                    sbNames.Append($",{names[i]}");
                }
            }
            
            sbNames.Append($" and{names[^1]}");
            formatedBalanceNames[0] = sbNames.ToString();
            formatedBalanceNames[1] = "are";
            formatedBalanceNames[2] = "people";
            formatedBalanceNames[3] = "have";
            return formatedBalanceNames;
        }

        /// <summary>
        /// Takes one individual with balances as an array and return their greatest loss in history.
        /// </summary>
        /// <param name="personAndBalance"></param>
        /// <returns></returns>
        public static float GetBiggestLoss(string[] personAndBalance)
        {
            float[] balance = ConvertStringArrToFloatArr(personAndBalance[1..]);
            float loss = 0f;
            for (int i = 0; i < balance.Length - 1; i++)
            {
                if (balance[i + 1] - balance[i] < loss)
                {
                    loss = balance[i + 1] - balance[i];
                }
            }
            return loss;
        }

        public static string ConcatMoney(float balance)
        {
            if (balance < 0)
            {
                return $"-{currencySymbol}{System.Math.Abs(balance)}";
            }
            else
            {
                return $"{currencySymbol}{balance}";
            }
        }
    }
}
