namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            

            var firstAccount = peopleAndBalances[0].Split(", ");
            var firstBalance = Lesson7.StringArrayToFloatArray(firstAccount[1..]);

            var names = new string[] {firstAccount[0]};
            var highestBalance = Lesson7.MaxFloat(firstBalance);

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(", ");
                var currentBalance = Lesson7.StringArrayToFloatArray(currentAccount[1..]);

                var currentName = currentAccount[0];
                var currentHighest = Lesson7.MaxFloat(currentBalance);

                // if same as others add it to the list
                if (currentHighest == highestBalance)
                {
                    names = Lesson7.AppendString(names, currentName);
                }

                if (currentHighest > highestBalance)
                {
                    names = new string[] {currentName};
                    highestBalance = currentHighest;
                }
            }

            string returnNames;
            if (names.Length == 1)
            {
                returnNames = names[0];
            }
            else
            {
                returnNames = string.Join(", ", names[..^1]);
                returnNames += $" and {names[^1]}";
            }

            return $"{returnNames} had the most money ever. ¤{highestBalance}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            string[] firstAccount;
            float[] firstBalance;
            int firstIndex = 0;
            do
            {
                firstAccount = peopleAndBalances[firstIndex].Split(", ");
                firstBalance = Lesson7.StringArrayToFloatArray(firstAccount[1..]);
                firstIndex++;
            } while (firstBalance.Length < 2 && firstIndex < peopleAndBalances.Length);


            if (firstIndex == peopleAndBalances.Length && firstBalance.Length < 2)
            {
                return "N/A.";
            }


            string[] names = new string[] { firstAccount[0] };
            float biggestLoss = Lesson7.MaxFloat(firstBalance) - Lesson7.MinFloat(firstBalance);

            for (int i = firstIndex; i < peopleAndBalances.Length; i++)
            {
                string[] currentAccount = peopleAndBalances[i].Split(", ");
                float[] currentBalance = Lesson7.StringArrayToFloatArray(currentAccount[1..]);
                float currentLoss = Lesson7.MaxFloat(currentBalance) - Lesson7.MinFloat(currentBalance);
                string currentName = currentAccount[0];

                if (currentLoss > biggestLoss)
                {
                    names = new string[] { currentName };
                    biggestLoss = currentLoss;
                }
                if (currentLoss == biggestLoss)
                {
                    names = Lesson7.AppendString(names, currentName);
                }
            }

            if (names.Length == 1)
            {
                return $"{names[0]} lost the most money. -¤{biggestLoss}.";
            }
            string returnNames = string.Join(", ", names[..^1]);
            returnNames += $" and {names[^1]}";

            return $"{returnNames} have lost the most money. -¤{biggestLoss}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            var firstAccount = peopleAndBalances[0].Split(", ");
            var firstBalance = Lesson7.StringArrayToFloatArray(firstAccount[1..]);

            var names = new string[] { firstAccount[0] };
            var highestBalance = firstBalance[^1];

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(", ");
                var currentBalance = Lesson7.StringArrayToFloatArray(currentAccount[1..]);

                var currentName = currentAccount[0];
                var currentHighest = currentBalance[^1];

                // if same as others add it to the list
                if (currentHighest == highestBalance)
                {
                    names = Lesson7.AppendString(names, currentName);
                }

                if (currentHighest > highestBalance)
                {
                    names = new string[] { currentName };
                    highestBalance = currentHighest;
                }
            }

            string returnNames;
            
            if (names.Length == 1)
            {
                returnNames = names[0];
                return $"{returnNames} is the richest person. ¤{highestBalance}.";
            }
            
            returnNames = string.Join(", ", names[..^1]);
            returnNames += $" and {names[^1]}";
            
            return $"{returnNames} are the richest people. ¤{highestBalance}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            var firstAccount = peopleAndBalances[0].Split(", ");
            var firstBalance = Lesson7.StringArrayToFloatArray(firstAccount[1..]);

            var names = new string[] { firstAccount[0] };
            var lowestBalance = firstBalance[^1];

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(", ");
                var currentBalance = Lesson7.StringArrayToFloatArray(currentAccount[1..]);

                var currentName = currentAccount[0];
                var currentLowest = currentBalance[^1];

                // if same as others add it to the list
                if (currentLowest == lowestBalance)
                {
                    names = Lesson7.AppendString(names, currentName);
                }

                if (currentLowest < lowestBalance)
                {
                    names = new string[] { currentName };
                    lowestBalance = currentLowest;
                }
            }

            string returnNames;

            var returnBalance = $"¤{ lowestBalance }";
            if (lowestBalance < 0)
            {
                returnBalance = $"-¤{-lowestBalance }";
            }

            if (names.Length == 1)
            {
                returnNames = names[0];
                return $"{returnNames} has the least money. {returnBalance}.";
            }

            returnNames = string.Join(", ", names[..^1]);
            returnNames += $" and {names[^1]}";
            
            return $"{returnNames} have the least money. {returnBalance}.";
        }
    }
}
