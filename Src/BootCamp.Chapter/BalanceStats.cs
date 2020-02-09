using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        private const string InValidOutput = "N/A.";

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

            var personWithHighestBalance = new StringBuilder();
            var highestBalanceEver = FindHighestBalance(peopleAndBalances, personWithHighestBalance);

            return $"{personWithHighestBalance.ToString()} had the most money ever. ¤{highestBalanceEver}.";
        }

        private static decimal FindHighestBalance(string[] peopleAndBalances, StringBuilder PersonWithHighestBalance)
        {
            var HighestBalanceEver = decimal.MinValue;

            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',');
                try
                {
                    var highestAmountOfPerson = decimal.Parse(currentPersonData[1..].Max());
                    if (highestAmountOfPerson == HighestBalanceEver)
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
                            PersonWithHighestBalance.Replace(currentOne, currentPersonData[0]);
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine($"There was a person with no balance in the file, namely : {currentPersonData[0]}");
                    break;
                }
            }

            return HighestBalanceEver;
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

                // calculateLoss

                if (allAmounts.Length <= 1)
                {
                    return InValidOutput;
                }

                for (int j = 0; j < allAmounts.Length - 1; j++)
                {
                    try
                    {
                        var amount1 = decimal.Parse(allAmounts[j], NumberStyles.Currency | NumberStyles.Number);
                        try
                        {
                            var amount2 = decimal.Parse(allAmounts[j + 1], NumberStyles.Currency | NumberStyles.Number);
                            var lossForCurrentPerson = amount1 - amount2;

                            //check if loss is greater then the current highest loss
                            if (lossForCurrentPerson > HighestLossEver)
                            {
                                HighestLossEver = lossForCurrentPerson;
                                PersonWithHighestLoss = currentPersonData[0];
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"{allAmounts[j + 1]} is not a  valid number");
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"{allAmounts[j]} is not a valid number");
                        break;
                    }
                }
            }
            return $"{PersonWithHighestLoss} lost the most money. -¤{HighestLossEver}.";
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

            var richestPerson = new StringBuilder();
            var highestBalance = FindRichest(peopleAndBalances, richestPerson);

            var persons = richestPerson.ToString();

            if (persons.Contains(','))
            {
                return $"{persons} are the richest people. ¤{highestBalance}.";
            }
            else
            {
                return $"{persons} is the richest person. ¤{highestBalance}.";
            }
        }

        private static decimal FindRichest(string[] peopleAndBalances, StringBuilder RichestPerson)
        {
            var HighestBalance = decimal.MinValue;
            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',');
                try
                {
                    var highestAmountOfPerson = decimal.Parse(currentPersonData[^1]);

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
                            RichestPerson.Clear();
                            RichestPerson.Append(currentPersonData[0]);
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("There was a person with no balance in the file");
                    break;
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

            var poorestPerson = new StringBuilder();
            var lowestBalance = FindPoorest(peopleAndBalances, poorestPerson);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            NumberFormatInfo noParens = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            noParens.CurrencyNegativePattern = 1;
            var lowestBalanceString = lowestBalance.ToString("C0", noParens);

            var persons = poorestPerson.ToString();

            if (persons.Contains(','))
            {
                return $"{poorestPerson.ToString()} have the least money. {lowestBalanceString}.";
            }
            else
            {
                return $"{poorestPerson.ToString()} has the least money. {lowestBalanceString}.";
            }
        }

        private static decimal FindPoorest(string[] peopleAndBalances, StringBuilder poorestPerson)
        {
            var lowestBalance = decimal.MaxValue;

            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',');
               

                try
                {
                    var lowestAmountOfPerson = decimal.Parse(currentPersonData[^1]);

                    if (lowestAmountOfPerson == lowestBalance)
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

                    if (lowestAmountOfPerson < lowestBalance)
                    {
                        lowestBalance = lowestAmountOfPerson;
                        var currentOne = poorestPerson.ToString();

                        if (string.IsNullOrEmpty(currentOne))
                        {
                            poorestPerson.Append(currentPersonData[0]);
                        }
                        else
                        {
                            poorestPerson.Replace(currentOne, currentPersonData[0]);
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("There was a person with no balance in the file");
                }

                
            }
            return lowestBalance;
        }
    }
}