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

            float highestBalanceEver = HighestBalanceEver(peopleAndBalances);
            string highestBalanceNames = BalanceNames(highestBalanceEver, peopleAndBalances);

            return $"{highestBalanceNames} had the most money ever. {currencySymbol}{highestBalanceEver}.";
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

            string[][] workingPeopleAndBalances = ArrayifyBalances(peopleAndBalances);
            float biggestLossEver = GetLoss(workingPeopleAndBalances[0]);
            string biggestLossNames = workingPeopleAndBalances[0][0];
            for (int i = 0; i < workingPeopleAndBalances.Length; i++)
            {
                float loss = GetLoss(workingPeopleAndBalances[i]);
                string name = workingPeopleAndBalances[i][0];
                if (loss < biggestLossEver)
                {
                    biggestLossEver = loss;
                    biggestLossNames = name;
                }
            }

            return $"{biggestLossNames} lost the most money. {currencySymbol}{biggestLossEver}";
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

            string[][] workingBalances = ArrayifyBalances(peopleAndBalances);
            int richestPerson = 0;
            string message = $"{workingBalances[richestPerson][0]} is the richest person. ${workingBalances[richestPerson][^1]}";
            if (workingBalances.Length == 1)
            {
                return message;
            }
            for (int i = 1; i < workingBalances.Length; i++)
            {
                if(float.Parse(workingBalances[i][^1]) > float.Parse(workingBalances[richestPerson][^1]))
                {
                    richestPerson = i;
                }
            }
            return message = $"{workingBalances[richestPerson][0]} is the richest person. ${workingBalances[richestPerson][^1]}";
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

            string[][] workingBalances = ArrayifyBalances(peopleAndBalances);
            int poorestPerson = 0;
            string message = $"{workingBalances[poorestPerson][0]} is the poorest person. ${workingBalances[poorestPerson][^1]}";
            if (workingBalances.Length == 1)
            {
                return message;
            }
            for (int i = 1; i < workingBalances.Length; i++)
            {
                if (float.Parse(workingBalances[i][^1]) < float.Parse(workingBalances[poorestPerson][^1]))
                {
                    poorestPerson = i;
                }
            }
            return message = $"{workingBalances[poorestPerson][0]} is the poorest person. ${workingBalances[poorestPerson][^1]}";
        }

        /// <summary>
        /// Takes an array of strings and returns a jagged array with each string on ", ".
        /// </summary>
        public static string[][] ArrayifyBalances(string[] peopleAndBalances)
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
        public static float[] StringArrToFloatArr(string[] balances)
        {
            int failLength = 0;
            float[] floatArr = new float[balances.Length];
            for (int i = 0; i < floatArr.Length; i++)
            {
                bool success = float.TryParse(balances[i], out float number);
                if (success) floatArr[i - failLength] = number;
                else failLength++;
            }
            if(failLength == 0) return floatArr;
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
        public static float HighestBalance(float[] balances)
        {
            float highestBalance = balances[0];
            if (balances.Length == 0) return highestBalance;
            for (int i = 1; i < balances.Length; i++)
            {
                if (balances[i] > highestBalance) highestBalance = balances[i];
            }
            return highestBalance;
        }

        /// <summary>
        /// Takes an array of names and balances, then returns the highest value of all balances.
        /// </summary>
        /// <param name="peopleAndBalances"></param>
        /// <returns></returns>
        public static float HighestBalanceEver(string[] peopleAndBalances)
        {
            string[][] workingPeopleAndBalances = ArrayifyBalances(peopleAndBalances);
            float highestBalanceEver = HighestBalance(StringArrToFloatArr(workingPeopleAndBalances[0][1..]));
            if (workingPeopleAndBalances.Length == 1) return highestBalanceEver;
            for (int i = 1 ; i < workingPeopleAndBalances.Length; i++)
            {
                float balanceToTest = HighestBalance(StringArrToFloatArr(workingPeopleAndBalances[i][1..]));
                if (balanceToTest > highestBalanceEver)
                {
                    highestBalanceEver = balanceToTest;
                }
            }
            return highestBalanceEver;
        }

        /// <summary>
        /// Takes a balance then finds and returns all the names that share that balance
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="peopleAndBalances"></param>
        /// <returns></returns>
        public static string BalanceNames(float balance, string[]peopleAndBalances)
        {
            string[][] workingPeopleAndBalances = ArrayifyBalances(peopleAndBalances);
            string totalNames = "";
            for (int i = 0; i < workingPeopleAndBalances.Length; i++)
            {
                float[] balances = StringArrToFloatArr(workingPeopleAndBalances[i][1..]);
                bool isBalance = false;
                foreach (var item in balances)
                {
                    if (item == balance) isBalance = true;
                }
                if (isBalance) totalNames += $"{workingPeopleAndBalances[i][0]}, ";
            }
            totalNames = FormatBalanceNames(totalNames);
            return totalNames;
        }

        /// <summary>
        /// Takes a string of names separated by ', ' and returns a grammatically correct string
        /// </summary>
        /// <param name="balanceNames"></param>
        /// <returns></returns>
        public static string FormatBalanceNames(string balanceNames)
        {
            int count = balanceNames.Split(',').Length - 1;
            balanceNames = balanceNames.Remove(balanceNames.Length - 2);
            if (count == 1) return balanceNames;
            string[] names = balanceNames.Split(',');
            StringBuilder sbNames = new StringBuilder(names[0]);
            switch (count)
            {
                case 2:
                    sbNames.Append($" and{names[1]}");
                    balanceNames = sbNames.ToString();
                    return balanceNames;
                default:
                    for (int i = 1; i < names.Length - 1; i++)
                    {
                        sbNames.Append($",{names[i]}");
                    }
                    break;
            }
            sbNames.Append($", and{names[^1]}");
            balanceNames = sbNames.ToString();
            return balanceNames;
        }

        /// <summary>
        /// Takes one individual with balances as an array and return their greatest loss in history.
        /// </summary>
        /// <param name="personAndBalance"></param>
        /// <returns></returns>
        public static float GetLoss(string[] personAndBalance)
        {
            float[] balance = StringArrToFloatArr(personAndBalance[1..]);
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
    }
}
