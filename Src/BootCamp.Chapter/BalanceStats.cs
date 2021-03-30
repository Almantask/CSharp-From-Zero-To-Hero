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
                float highBalance=0;

                for (var i = 0; i < peopleAndBalances.Length; i++)
                {
                    if (peopleAndBalances[i].Split(',').Length > 1)
                        namesOfTheHighestValues.Append(FindMaximumByPerson(peopleAndBalances[i]));
                }

                namesOfTheHighestValues = findMaxOrMin(namesOfTheHighestValues, true, ref highBalance);
                
                return $"{PrintNames(namesOfTheHighestValues)} had the most money ever. {PrintValue(highBalance)}.";
            }
            return "N/A.";
        }

        //Returns name and maximum balance of person
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

            return $"{balances[0]}:{yearBalanceMax},";
        }
        

        
        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (!(peopleAndBalances == null || peopleAndBalances.Length == 0))
            {
                
                StringBuilder namesOfTheBiggestLosers = new StringBuilder();
                float valueOfBiggestLoss = 0;
                
                for (var i = 0; i < peopleAndBalances.Length; i++)
                {
                    if(peopleAndBalances[i].Split(',').Length>2)
                    {
                        namesOfTheBiggestLosers.Append(PersonsBiggestLoss(peopleAndBalances[i]));
                    }
                    
                }

                if (namesOfTheBiggestLosers.ToString().Length > 1)
                {
                    namesOfTheBiggestLosers = findMaxOrMin(namesOfTheBiggestLosers, false, ref valueOfBiggestLoss);
                    
                }
                else
                    return "N/A.";                              

                return $"{PrintNames(namesOfTheBiggestLosers)} lost the most money. {PrintValue(valueOfBiggestLoss)}.";
            }

            return "N/A.";
        }

        public static string PersonsBiggestLoss (string balances)
        {         
            string[] eachPerson = balances.Split(',');
            float valueOfBiggestLoss = 0.0f;

            for (var j = 1; j < eachPerson.Length - 1; j++)
            {
                float.TryParse(eachPerson[j], out float lowerYearBalance);
                float.TryParse(eachPerson[j + 1], out float higherYearBalance);
                if (valueOfBiggestLoss > (higherYearBalance - lowerYearBalance))
                {
                    valueOfBiggestLoss = (higherYearBalance - lowerYearBalance);
                }
            }


            return $"{eachPerson[0]}:{valueOfBiggestLoss},";
        }
        

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (!(peopleAndBalances == null || peopleAndBalances.Length == 0))
            {
                StringBuilder richestPerson = new StringBuilder();
                float richestValue = 0;

                for (var i = 0; i < peopleAndBalances.Length; i++)
                {
                    string[] eachPerson = peopleAndBalances[i].Split(',');
                    float.TryParse(eachPerson[eachPerson.Length - 1], out float balance);
                    richestPerson.Append($"{eachPerson[0]}:{balance},");
                }

                StringBuilder names = new StringBuilder();

                names = findMaxOrMin(richestPerson, true, ref richestValue);


                string multiple = "is the richest person.";

                if (names.ToString().Split(',').Length > 2)
                {
                    multiple = "are the richest people.";
                }

                return $"{PrintNames(names)} {multiple} {PrintValue(richestValue)}.";
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
                StringBuilder poorestPerson = new StringBuilder();
                
                string[] eachPerson;// = peopleAndBalances[0].Split(',');
                float balance=0;
                int counter=0;
                for (var i = 0; i < peopleAndBalances.Length; i++)
                {
                    eachPerson = peopleAndBalances[i].Split(',');
                    if (eachPerson.Length > 1)
                    {
                        float.TryParse(eachPerson[eachPerson.Length - 1], out balance);
                        poorestPerson.Append($"{eachPerson[0]}:{balance},");
                        counter++;
                    }
                }

                StringBuilder names = new StringBuilder();

                if (counter > 0)
                {
                    names = findMaxOrMin(poorestPerson, false, ref balance);
                }
                else
                {
                    return "N/A.";
                }

                string multiple = "has";

                if(names.ToString().Split(',').Length>2)
                {
                    multiple = "have";
                }

                return $"{PrintNames(names)} {multiple} the least money. {PrintValue(balance)}.";
            }
            return "N/A.";
        }

        //Returns the list of people with max or min value
        public static StringBuilder findMaxOrMin(StringBuilder listOfPeople, bool isMax, ref float balance)
        {
            string[] namesAndBalances = listOfPeople.ToString()[..^1].Split(',');
            StringBuilder names = new StringBuilder();
            //float value=0;
            if (isMax)
            {
                float.TryParse(namesAndBalances[0].Substring(namesAndBalances[0].IndexOf(':') + 1), out balance);
                for (var i = 1; i < namesAndBalances.Length; i++)
                {
                    float.TryParse(namesAndBalances[i].Substring(namesAndBalances[i].IndexOf(':') + 1), out float highBalance);
                    if (balance <= highBalance)
                    {
                        balance = highBalance;
                    }
                }
            }
            else
            {
                float.TryParse(namesAndBalances[0].Substring(namesAndBalances[0].IndexOf(':') + 1), out balance);
                for (var i = 0; i < namesAndBalances.Length; i++)
                {
                    float.TryParse(namesAndBalances[i].Substring(namesAndBalances[i].IndexOf(':') + 1), out float highBalance);
                    if (balance >= highBalance)
                    {
                        balance = highBalance;
                    }
                }
            }

            for (var i = 0; i < namesAndBalances.Length; i++)
            {
                float.TryParse(namesAndBalances[i].Substring(namesAndBalances[i].IndexOf(':') + 1), out float highBalance);
                if (balance == highBalance)
                {
                    names.Append($"{namesAndBalances[i].Substring(0, namesAndBalances[i].IndexOf(':'))},");

                }
            }

            return names;
        }

        //Print Name(s)
        public static string PrintNames(StringBuilder names)
        {
            if (names.ToString().CompareTo("N/A.") != 0 && names.ToString().Length > 0)
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
        //Print value (formatted)
        public static string PrintValue(float value)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var numberFormat = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            numberFormat.CurrencyNegativePattern = 1;

            return value.ToString("C0", numberFormat).Replace(",", "");
        }

    }
}
