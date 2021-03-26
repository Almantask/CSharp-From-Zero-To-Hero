using System.Globalization;
using System;
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
            if (!(peopleAndBalances == null || peopleAndBalances.Length == 0))
            {
                StringBuilder namesOfTheHighestValues = new StringBuilder();
                string[] balances = new string[peopleAndBalances.Length];
                int balance=0;
                for (var i = 0; i < peopleAndBalances.Length; i++)
                {
                    balances[i] = FindMaximumByPerson(peopleAndBalances[i]);
                }

                namesOfTheHighestValues = FindMaximumValueAndPersons(balances, ref balance);
                //PrintNames(valueAndNamesHighestBalances);

                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                

                return $"{PrintNames(namesOfTheHighestValues)} had the most money ever. {(balance).ToString("C0").Replace(",", "")}.";
            }
            return "N/A.";
        }

        //Returns name and maximum balance
        public static string FindMaximumByPerson (string balancesByPerson)
        {
            string[] balances = balancesByPerson.Split(',');
            float.TryParse(balances[1], out float yearBalanceMax); 
            for (var i=1;i<balances.Length;i++)
            {
                float.TryParse(balances[i], out float yearBalance); 
                if (yearBalanceMax < yearBalance)
                {
                    yearBalanceMax = yearBalance;
                }
            }

            return $"{balances[0]}:{yearBalanceMax}";
        }

        public static StringBuilder FindMaximumValueAndPersons(string[] balances, ref int outputBalance)
        {
            StringBuilder namesOfHighestBalance = new StringBuilder();
            float valueOfHighestBalance = 0.0f;
           // string outputNames = "";
            for (var i=0;i<balances.Length;i++)
            {
                float.TryParse(balances[i].Substring(balances[i].IndexOf(':') + 1), out float balance);
                if (valueOfHighestBalance <= balance)
                {
                    valueOfHighestBalance = balance;
                }
            }

            
            for (var i=0;i<balances.Length;i++)
            {
                float.TryParse(balances[i].Substring(balances[i].IndexOf(':') + 1), out float balance);
                if (valueOfHighestBalance == balance)
                {
                    namesOfHighestBalance.Append($"{balances[i].Substring(0, balances[i].IndexOf(':'))},");
                    
                }
            }
            outputBalance = (int)valueOfHighestBalance;
            return namesOfHighestBalance;
            
        }


        public static string PrintNames(StringBuilder names)
        {
            if (names.ToString().CompareTo("N/A.") != 0 && names.ToString().Length>0)
            {
                string[] writeOutNames = names.ToString()[..^1].Split(',');
                StringBuilder outputNames = new StringBuilder();
                if (writeOutNames.Length == 1)
                {
                    outputNames.Append(writeOutNames[0]);
                }

                if (writeOutNames.Length == 2)
                {
                    outputNames.Append($"{writeOutNames[0]} and {writeOutNames[1]}");
                }

                if (writeOutNames.Length > 2)
                {
                    for (var i = 0; i < writeOutNames.Length - 2; i++)
                    {
                        outputNames.Append($"{writeOutNames[i]}, ");
                    }
                    outputNames.Append($"{writeOutNames[writeOutNames.Length - 2]} and {writeOutNames[writeOutNames.Length - 1]}");
                }
                return outputNames.ToString();
            }
            else
                return "N/A.";
            

            
        }


        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (!(peopleAndBalances == null || peopleAndBalances.Length == 0))
            {
                
                string[] balances = new string[peopleAndBalances.Length];
                StringBuilder namesOfTheBiggestLosers = new StringBuilder();
                float valueOfBiggestLoss = 0;
                for(var i=0;i<peopleAndBalances.Length;i++)
                {
                    balances[i] = PersonsBiggestLoss(peopleAndBalances[i]);
                }

                namesOfTheBiggestLosers = NamesOfTheBiggestLoss(balances, ref valueOfBiggestLoss);

                string outputNames = PrintNames(namesOfTheBiggestLosers);
                if (outputNames.CompareTo("N/A.") == 0)
                    return "N/A.";

                CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                culture.NumberFormat.CurrencyNegativePattern = 1;
                string s = string.Format(culture, "{0:c0}", valueOfBiggestLoss);

                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                return $"{outputNames} lost the most money. {s}.";
            }
            return "N/A.";

        }

        public static string PersonsBiggestLoss (string balances)
        {
            

            string[] eachPerson = balances.Split(',');
            float valueOfBiggestLoss = 0.0f;
            if (eachPerson.Length > 2)
            {
                for (var j = 1; j < eachPerson.Length - 1; j++)
                {
                    float.TryParse(eachPerson[j], out float lowerYearBalance);
                    float.TryParse(eachPerson[j + 1], out float higherYearBalance);
                    if (valueOfBiggestLoss > (higherYearBalance - lowerYearBalance))
                    {
                        valueOfBiggestLoss = (higherYearBalance - lowerYearBalance);

                    }
                }
            }
            else
                return "N/A.";

            return $"{eachPerson[0]}:{valueOfBiggestLoss}";
        }


        public static StringBuilder NamesOfTheBiggestLoss(string[] balances,ref float outputLoss)
        {
            StringBuilder namesOfTheBiggestLosers = new StringBuilder();
            float valueOfBiggestLoss = 0.0f;
           
            for (var i=0;i<balances.Length;i++)
            {
                if (balances[i].CompareTo("N/A.")!=0)
                {
                    float.TryParse(balances[i].Substring(balances[i].IndexOf(':') + 1), out float loss);
                    if (valueOfBiggestLoss > loss)
                    {
                        valueOfBiggestLoss = loss;
                    }
                }

            }

            for (var i = 0; i < balances.Length; i++)
            {
                if (balances[i].CompareTo("N/A.") != 0)
                {
                    float.TryParse(balances[i].Substring(balances[i].IndexOf(':') + 1), out float balance);
                    if (valueOfBiggestLoss == balance)
                    {
                        namesOfTheBiggestLosers.Append($"{balances[i].Substring(0, balances[i].IndexOf(':'))},");

                    }
                }
            }

            outputLoss = valueOfBiggestLoss;

            return namesOfTheBiggestLosers;

        }


        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (!(peopleAndBalances == null || peopleAndBalances.Length == 0))
            {
                string richestPerson = "";
                float richestValue = 0;

                for (var i = 0; i < peopleAndBalances.Length; i++)
                {
                    string[] eachPerson = peopleAndBalances[i].Split(',');
                    float.TryParse(eachPerson[eachPerson.Length - 1], out float balance);
                    if (richestValue < balance)
                    {
                        richestPerson = eachPerson[0];
                        richestValue = balance;
                    }
                }

                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                return $"{richestPerson}{Environment.NewLine}{richestValue:C0}";
            }
            return "N/A.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (!(peopleAndBalances == null || peopleAndBalances.Length == 0))
            {
                string poorestPerson = "";
                float poorestValue = 0;

                string[] eachPerson = peopleAndBalances[0].Split(',');
                float.TryParse(eachPerson[eachPerson.Length - 1], out float balance);
                poorestValue = balance;
                poorestPerson = eachPerson[0];

                for (var i = 1; i < peopleAndBalances.Length; i++)
                {
                    eachPerson = peopleAndBalances[i].Split(',');
                    float.TryParse(eachPerson[eachPerson.Length - 1], out balance);
                    if (poorestValue >= balance)
                    {
                        poorestPerson = eachPerson[0];
                        poorestValue = balance;
                    }
                }

                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                return $"{poorestPerson}{Environment.NewLine}{poorestValue:C0}";
            }
            return "N/A.";
        }
    }
}
