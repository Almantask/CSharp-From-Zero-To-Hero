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

            var names = new [] {firstAccount[0]};
            var highestBalance = Lesson7.Max(firstBalance);

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(", ");
                var currentBalance = Lesson7.StringArrayToFloatArray(currentAccount[1..]);

                var currentName = currentAccount[0];
                var currentHighest = Lesson7.Max(currentBalance);

                // if same as others add it to the list
                if (Lesson7.EqualFloats(currentHighest, highestBalance))
                {
                    names = Lesson7.AppendString(names, currentName);
                }

                if (currentHighest > highestBalance)
                {
                    names = new [] {currentName};
                    highestBalance = currentHighest;
                }
            }

            var formatedName = Lesson7.FormatArrayToString(names);

            return $"{formatedName} had the most money ever. ¤{highestBalance}.";
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
            bool accountIsInvalid;
            do
            {
                firstAccount = peopleAndBalances[firstIndex].Split(", ");
                firstBalance = Lesson7.StringArrayToFloatArray(firstAccount[1..]);
                firstIndex++;

                // it can't check for a loss if it doesn't have at least two transactions.
                // And it should stop if went trough all the accounts given
                accountIsInvalid = (firstBalance.Length < 2 && firstIndex < peopleAndBalances.Length);
            } while (accountIsInvalid);

            // If it went trough all of the accounds and the last one doesn't have two 
            // transactions, it can't check for biggest loss and returns "N/A"
            if (firstIndex == peopleAndBalances.Length && firstBalance.Length < 2)
            {
                return "N/A.";
            }

            var names = new [] { firstAccount[0] };
            float biggestLoss = Lesson7.Max(firstBalance) - Lesson7.Min(firstBalance);

            for (int i = firstIndex; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(", ");
                var currentBalance = Lesson7.StringArrayToFloatArray(currentAccount[1..]);
                var currentLoss = Lesson7.Max(currentBalance) - Lesson7.Min(currentBalance);
                var currentName = currentAccount[0];

                if (currentLoss > biggestLoss)
                {
                    names = new [] { currentName };
                    biggestLoss = currentLoss;
                }
                if (Lesson7.EqualFloats(currentLoss, biggestLoss))
                {
                    names = Lesson7.AppendString(names, currentName);
                }
            }

            var formatedNames = Lesson7.FormatArrayToString(names);
            
             return $"{formatedNames} lost the most money. -¤{biggestLoss}.";
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

            var names = new [] { firstAccount[0] };
            var highestBalance = firstBalance[^1];

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(", ");
                var currentBalance = Lesson7.StringArrayToFloatArray(currentAccount[1..]);

                var currentName = currentAccount[0];
                var currentHighest = currentBalance[^1];

                // if same as others add it to the list
                if (Lesson7.EqualFloats(currentHighest, highestBalance))
                {
                    names = Lesson7.AppendString(names, currentName);
                }

                if (currentHighest > highestBalance)
                {
                    names = new [] { currentName };
                    highestBalance = currentHighest;
                }
            }

            string formatedNames = Lesson7.FormatArrayToString(names);
            
            if (names.Length == 1)
            {
                return $"{formatedNames} is the richest person. ¤{highestBalance}.";
            }
            return $"{formatedNames} are the richest people. ¤{highestBalance}.";
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
                if (Lesson7.EqualFloats(currentLowest, lowestBalance))
                {
                    names = Lesson7.AppendString(names, currentName);
                }

                if (currentLowest < lowestBalance)
                {
                    names = new string[] { currentName };
                    lowestBalance = currentLowest;
                }
            }

            var formatedNames = Lesson7.FormatArrayToString(names);

            var returnBalance = $"¤{ lowestBalance }";
            if (lowestBalance < 0)
            {
                returnBalance = $"-¤{-lowestBalance }";
            }

            if (names.Length == 1)
            {
                return $"{formatedNames} has the least money. {returnBalance}.";
            }
            
            return $"{formatedNames} have the least money. {returnBalance}.";
        }
    }
}
