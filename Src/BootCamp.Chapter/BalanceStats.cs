using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        const string InValidOutput = "N/A."; 
        public static bool IsInValidValidInput(string[] input) => input == null || input.Length == 0;

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsInValidValidInput(peopleAndBalances))
            {
                return InValidOutput;
            }

            var HighestBalanceEver = decimal.MinValue;
            var PersonWithHighestBalance = new StringBuilder();

            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                HighestBalanceEver = FindHighestBalance(peopleAndBalances, HighestBalanceEver, PersonWithHighestBalance, i);

            }

            var answer = $"{PersonWithHighestBalance.ToString()} had the most money ever. ¤{HighestBalanceEver}.";

            return answer;
        }

        private static decimal FindHighestBalance(string[] peopleAndBalances, decimal HighestBalanceEver, StringBuilder PersonWithHighestBalance, int i)
        {
            var currentPersonData = peopleAndBalances[i].Split(',');
            var highestAmountOfPerson = FindHighestBalanceOfPerson(currentPersonData);

            if (highestAmountOfPerson > HighestBalanceEver)
            {
                HighestBalanceEver = highestAmountOfPerson;
                var currentOne = PersonWithHighestBalance.ToString();

                if (string.IsNullOrEmpty(currentOne))
                {
                    PersonWithHighestBalance.Append(currentPersonData[0]);
                }
                else
                {
                    PersonWithHighestBalance.Clear();
                    PersonWithHighestBalance.Append(currentPersonData[0]);
                }


            }
            else if (highestAmountOfPerson == HighestBalanceEver)
            {
                if (i == peopleAndBalances.Length - 1)
                {
                    PersonWithHighestBalance.Append(" and ");
                }
                else
                {
                    PersonWithHighestBalance.Append(", ");
                }

                PersonWithHighestBalance.Append(currentPersonData[0]);
            }

            return HighestBalanceEver; 
        }

        public static decimal FindHighestBalanceOfPerson(string[] currentPersonData)
        {
            var highest = decimal.MinValue; 
            var allAmounts = currentPersonData[1..]; 
            foreach (var amountString in allAmounts)
            {
                if (!decimal.TryParse(amountString, out decimal amount))
                {
                    break; 
                }; 
                if (amount > highest)
                    
                {
                    highest = amount; 
                }
            }

            return highest; 
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsInValidValidInput(peopleAndBalances))
            {
                return InValidOutput;
            }

            var HighestLossEver = decimal.MinValue;
            var PersonWithHighestLoss = "";

            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',');
                var allAmounts = currentPersonData[1..];

                if (allAmounts.Length <= 1)
                {
                    return "N/A.";
                }

                var lossForCurrentPerson  =  CalculateLossForPerson(allAmounts);

                if (lossForCurrentPerson > HighestLossEver)
                {
                    HighestLossEver = lossForCurrentPerson;
                    PersonWithHighestLoss = currentPersonData[0];
                }
            }

            var answer = $"{PersonWithHighestLoss} lost the most money. -¤{HighestLossEver}.";

            return answer;

        }

        public static decimal CalculateLossForPerson(string [] data) 
        {
            var lossForCurrentPerson = 0M;

            for (int j = 0; j < data.Length - 1; j++)
            {
                if(!decimal.TryParse(data[j], out decimal amount1))
                {
                    break; 
                }

                if (!decimal.TryParse(data[j + 1], out decimal amount2))
                {
                    break;
                }
                lossForCurrentPerson = amount1 - amount2;
            }

            return lossForCurrentPerson; 
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsInValidValidInput(peopleAndBalances))
            {
                return InValidOutput;
            }

            var HighestBalance = decimal.MinValue;
            var RichestPerson = new StringBuilder();

            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',');

                if (!decimal.TryParse(currentPersonData[currentPersonData.Length - 1], out decimal highestAmountOfPerson))
                {
                    return "N/A.";
                }

                if (highestAmountOfPerson == HighestBalance)
                {
                    if (i == peopleAndBalances.Length - 1)
                    {
                        RichestPerson.Append(" and ");
                    }
                    else
                    {
                        RichestPerson.Append(", ");
                    }

                    RichestPerson.Append(currentPersonData[0]);
                }

                HighestBalance = FindMorePeopleWithSameAmount(HighestBalance, RichestPerson, currentPersonData, highestAmountOfPerson);

            }

            var answer = $"{RichestPerson.ToString()} is the richest person. ¤{HighestBalance}.";

            return answer;


        }

        private static decimal FindMorePeopleWithSameAmount(decimal HighestBalance, StringBuilder RichestPerson, string[] currentPersonData, decimal highestAmountOfPerson)
        {
            if (highestAmountOfPerson > HighestBalance)
            {
                HighestBalance = highestAmountOfPerson;
                var currentOne = RichestPerson.ToString();

                if (string.IsNullOrEmpty(currentOne))
                {
                    RichestPerson.Append(currentPersonData[0]);
                }
                else
                {
                    RichestPerson.Replace(currentOne, currentPersonData[0]);
                }


            }

            return HighestBalance;
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsInValidValidInput(peopleAndBalances))
            {
                return InValidOutput;
            }

            var lowestBalance = int.MaxValue;
            var poorestPerson = new StringBuilder();


            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',');
                if (!int.TryParse(currentPersonData[currentPersonData.Length - 1], out int highestAmountOfPerson))
                {
                    return "N/A.";
                }

                if (highestAmountOfPerson == lowestBalance)
                {
                    if (i == peopleAndBalances.Length - 1)
                    {
                        poorestPerson.Append(" and ");
                    }
                    else
                    {
                        poorestPerson.Append(", ");
                    }

                    poorestPerson.Append(currentPersonData[0]);
                }

                lowestBalance = FindMorePoorPeople(lowestBalance, poorestPerson, currentPersonData, highestAmountOfPerson);

            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            NumberFormatInfo noParens = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            noParens.CurrencyNegativePattern = 1; 
            var lowestBalanceString = lowestBalance.ToString("C0", noParens);

            var answer = $"{poorestPerson} has the least money. {lowestBalanceString}.";

           return answer;


        }

        private static int FindMorePoorPeople(int lowestBalance, StringBuilder poorestPerson, string[] currentPersonData, int highestAmountOfPerson)
        {
            if (highestAmountOfPerson < lowestBalance)
            {
                lowestBalance = highestAmountOfPerson;
                var currentOne = poorestPerson.ToString();


                if (string.IsNullOrEmpty(currentOne))
                {
                    poorestPerson.Append(currentPersonData[0]);

                }
                else
                {
                    poorestPerson.Clear();
                    poorestPerson.Append(currentPersonData[0]);
                }


            }

            return lowestBalance;
        }

    }
}
