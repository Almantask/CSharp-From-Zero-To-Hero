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

            if (personWithHighestBalance.ToString().Contains(", "))
            {
                personWithHighestBalance = ReplaceCommaWithAnd(personWithHighestBalance); 
            }

            return $"{personWithHighestBalance.ToString()} had the most money ever. ¤{highestBalanceEver}.";
        }

        private static StringBuilder ReplaceCommaWithAnd(StringBuilder message)
        {
            var index = message.ToString().LastIndexOf(", ");
            return message.Remove(index, 2).Insert(index, " and "); 
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
                        PersonWithHighestBalance.Append(", ");
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
                            PersonWithHighestBalance.Clear(); 
                            PersonWithHighestBalance.Append(currentPersonData[0]);
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
            var PersonWithHighestLoss = new StringBuilder();

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
                                PersonWithHighestLoss.Clear(); 
                                PersonWithHighestLoss.Append(currentPersonData[0]);
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

            if (PersonWithHighestLoss.ToString().Contains(','))
            {
                PersonWithHighestLoss = ReplaceCommaWithAnd(PersonWithHighestLoss);
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

            if (richestPerson.ToString().Contains(", "))
            {
                ReplaceCommaWithAnd(richestPerson); 
                return $"{richestPerson.ToString()} are the richest people. ¤{highestBalance}.";
            }
            else
            {
                return $"{richestPerson.ToString()} is the richest person. ¤{highestBalance}.";
            }
        }

        private static decimal FindRichest(string[] peopleAndBalances, StringBuilder richestPerson)
        {
            var highestBalance = decimal.MinValue;
            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',');
                try
                {
                    var highestAmountOfPerson = decimal.Parse(currentPersonData[^1]);

                    if (highestAmountOfPerson > highestBalance)
                    {
                        highestBalance = highestAmountOfPerson;
                        richestPerson.Clear(); 
                        
                    }

                    if (highestAmountOfPerson >= highestBalance)
                    {
                        AddPerson(currentPersonData[0], richestPerson);
                    }
                    
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("There was a person with no balance in the file");
                    break;
                }
            }

            return highestBalance;
        }

        private static StringBuilder AddPerson(string person, StringBuilder sb)
        {
            if (sb.Length == 0)
            {
                sb.Append(person);
            }
            else
            {
                sb.Append(", " + person);
            }

            return sb; 
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

            if (poorestPerson.ToString().Contains(','))
            {
                ReplaceCommaWithAnd(poorestPerson);
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

                    if (lowestAmountOfPerson < lowestBalance)
                    {
                        lowestBalance = lowestAmountOfPerson;
                        poorestPerson.Clear(); 

                        
                    }

                    if (lowestAmountOfPerson <= lowestBalance)
                    {
                        AddPerson(currentPersonData[0], poorestPerson);  
                    }

                       

                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("There was a person with no balance in the file ");
                    break; 
                }

                
            }
            return lowestBalance;
        }
    }
}