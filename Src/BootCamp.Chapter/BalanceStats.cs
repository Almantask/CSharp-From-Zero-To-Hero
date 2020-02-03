using System.Linq;
using System.Text;

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

            var HighestBalanceEver = decimal.MinValue; 
            var PersonWithHighestBalance = new StringBuilder() ; 

            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',') ; 
                var highestAmountOfPerson = decimal.Parse(currentPersonData[1 ..].Max());

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


                } else if (highestAmountOfPerson == HighestBalanceEver)
                {
                    if (i == peopleAndBalances.Length -1)
                    {
                        PersonWithHighestBalance.Append(" and ");
                    }
                    else
                    {
                        PersonWithHighestBalance.Append(", ");
                    }
                    
                    PersonWithHighestBalance.Append(currentPersonData[0]);
                }


            }

            var answer = $"{PersonWithHighestBalance.ToString()} had the most money ever. ¤{HighestBalanceEver}.";

            TextTable.Build(answer, 3); 

            return answer; 
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

            var HighestLossEver = decimal.MinValue;
            var PersonWithHighestLoss = "";

            for (int i = 0; i <= peopleAndBalances.Length - 1; i++)
            {
                var currentPersonData = peopleAndBalances[i].Split(',');
                var allAmounts = currentPersonData[1..];

                // calculateLoss
                
                if (allAmounts.Length <= 1)
                {
                    return "N/A."; 
                }

                var lossForCurrentPerson = 0M; 

                for (int j = 0; j < allAmounts.Length - 1 ; j++)
                {
                    var amount1 = decimal.Parse(allAmounts[j]);
                    var amount2 = decimal.Parse(allAmounts[j + 1]);
                    lossForCurrentPerson = amount1 - amount2; 
                }
                                

                //check if loss is greater then the current highest loss 
                if (lossForCurrentPerson > HighestLossEver)
                {
                    HighestLossEver = lossForCurrentPerson;
                    PersonWithHighestLoss = currentPersonData[0]; 
                }

            }

            return $"{PersonWithHighestLoss} lost the most money. -¤{HighestLossEver}.";  
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return "";
        }
    }
}
