using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        public static double[] FindPersonWithBiggestBalance(double[] pplHighestBalanceArray, out double highestBalance)
        {
            int personIndex = 0;
            double[] personWithHighestBalance = new double[pplHighestBalanceArray.Length];
            double tmpHighestBalance = double.MinValue;

            for (int i = 0; i < pplHighestBalanceArray.Length; i++)
            {
                if (pplHighestBalanceArray[i] > tmpHighestBalance)
                {
                    tmpHighestBalance = pplHighestBalanceArray[i];
                    personIndex = i;
                }
            }

            for (int i = 0; i < pplHighestBalanceArray.Length; i++)
            {
                if (pplHighestBalanceArray[i] == tmpHighestBalance)
                {
                    personWithHighestBalance[i] = pplHighestBalanceArray[i];
                }
            }

            //personWithHighestBalance[0] = personIndex;
            //personWithHighestBalance[1] = tmpHighestBalance;
            highestBalance = tmpHighestBalance;

            return personWithHighestBalance;
        }

        public static double[] FindPersonWithBiggestBalance(double[] pplHighestBalanceArray)
        {
            int personIndex = 0;
            double[] personWithHighestBalance = new double[pplHighestBalanceArray.Length];
            double tmpHighestBalance = double.MinValue;

            for (int i = 0; i < pplHighestBalanceArray.Length; i++)
            {
                if (pplHighestBalanceArray[i] > tmpHighestBalance)
                {
                    tmpHighestBalance = pplHighestBalanceArray[i];
                    personIndex = i;
                }
            }

            for (int i = 0; i < pplHighestBalanceArray.Length; i++)
            {
                if (pplHighestBalanceArray[i] == tmpHighestBalance)
                {
                    personWithHighestBalance[i] = pplHighestBalanceArray[i];
                }
            }

            //personWithHighestBalance[0] = personIndex;
            //personWithHighestBalance[1] = tmpHighestBalance;

            return personWithHighestBalance;
        }

        public static double FindHighestValuePerPerson(double accValue, double actualHigestValue)
        {
            if (actualHigestValue < accValue)
            {
                actualHigestValue = accValue;
            }
            return actualHigestValue;
        }

        public static double HighestHistoryBalancePerPerson(string[] curPersonData)
        {
            double actualHighestVal = 0;
            bool success = false;
            double accValue = 0;

            for (int i = 0; i < curPersonData.Length; i++)
            {
                success = double.TryParse(curPersonData[i], out accValue);
                if (success)
                {
                    actualHighestVal = FindHighestValuePerPerson(accValue, actualHighestVal);
                }
            }

            return actualHighestVal;
        }

        public static double CurrentBalance(string[] personData)
        {
            double tmpValue = 0;
            bool success = false;

            success = double.TryParse(personData[personData.Length - 1], out tmpValue);
            if (success)
            {
                tmpValue = double.Parse(personData[personData.Length - 1]);
            }

            //return tmpValue = 1
            return tmpValue;
        }

        public static string FindPersonNameBasedOnIndex(string[] peopleAndBalances, int index)
        {
            string[] tmpArray = peopleAndBalances[index].Split(',');
            string personName = tmpArray[0];

            return personName;
        }

        public static bool IsNullOrEmpty(this Array array)
        {
            return (array == null || array.Length == 0);
        }

        public static double SubtractNumbers(double a, double b)
        {
            double diff = 0;

            if (a > b)
            {
                diff = a - b;
            }
            //else
            //{ 
            //    diff = b - a;
            //}

            return diff;
        }

        public static double HighestLossPerPerson(string[] curPersonData)
        {
            double highestDifference = double.MinValue;
            //double[] accValues = new double[curPersonData.Length - 1];
            double[] accValues = new double[curPersonData.Length];
            double tmpValue = 0;
            bool success = false;
            double result;

            for (int i = 0; i < accValues.Length; i++)
            {
                success = double.TryParse(curPersonData[i], out result);
                if (success)
                {
                    if (i < accValues.Length - 1)
                    {
                        //accValues[i] = double.Parse(curPersonData[i + 1]);
                        accValues[i] = result;
                    }
                    else
                    {
                        accValues[i] = double.Parse(curPersonData[^1]);
                    }
                }
                else
                {
                    accValues[i] = 0;
                }
             
            }

            for (int i = 0; i < accValues.Length; i++)
            {
                if (i < accValues.Length - 1)
                {
                    tmpValue = SubtractNumbers(accValues[i], accValues[i+1]);
                    if (tmpValue > highestDifference) highestDifference = tmpValue * -1;
                }
                //else
                //{
                //    if (accValues.Length > 2)
                //    {
                //        tmpValue = SubtractNumbers(accValues[i], accValues[^1]);
                //        if (tmpValue > highestDifference) highestDifference = tmpValue * -1;
                //    }
                //}
            }

            return highestDifference;
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            {
                /*
                string highestBalanceName = string.Empty;
                string currentBalanceS = string.Empty;
                double higestBalanceValue = default;
                double currentValue;
                bool isHighestBalance = false;

                for (int i = 0; i < peopleAndBalances.Length; i++)
                {
                    var currPersonData = peopleAndBalances[i].Split(',');
                    for (int j = 0; j < currPersonData.Length; j++)
                    {
                        bool success = double.TryParse(currPersonData[j], out currentValue);
                        if (success)
                        {
                            var tmpValue = currentValue;
                            if (tmpValue > higestBalanceValue)
                            {
                                higestBalanceValue = tmpValue;
                                highestBalanceName = currPersonData[0];
                                isHighestBalance = true;
                            }
                        }
                    }
                    if (isHighestBalance) currentBalanceS = currPersonData[^1].Substring(0);
                    isHighestBalance = false;
                }

                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                decimal currentBalanceStoDecimal = Convert.ToDecimal(currentBalanceS);
                string currentBalanceDecimal = $"{currentBalanceStoDecimal:C0}";

                return $"{highestBalanceName} had the most money ever. {currentBalanceDecimal}.";
                */
            }
            // test doesnt want current balance, he wants highest history balance

            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            double[] highestHistoryBalancePerPerson = new double[peopleAndBalances.Length];
            double[] personWithHighestHistoryBalance = new double[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] currentPerson = new string[peopleAndBalances[i].Length];
                currentPerson = peopleAndBalances[i].Split(',');

                /// <summary>
                /// save highest history balance of every person
                /// </summary>
                highestHistoryBalancePerPerson[i] = HighestHistoryBalancePerPerson(currentPerson);
            }

            ///<summary>
            /// find person with biggest balance ever
            ///</summary>
            ///
            personWithHighestHistoryBalance = FindPersonWithBiggestBalance(highestHistoryBalancePerPerson);

            int nameCount = 0;
            for (int i = 0; i < personWithHighestHistoryBalance.Length; i++)
            {
                if (personWithHighestHistoryBalance[i] != 0)
                {
                    nameCount++;
                }
            }

            double currentBalanceStoDecimal = double.MinValue;
            string nameToParse = string.Empty;
            int count = 0;

            for (int i = 0; i < personWithHighestHistoryBalance.Length; i++)
            {
                if (personWithHighestHistoryBalance[i] != 0)
                {
                    string name = FindPersonNameBasedOnIndex(peopleAndBalances, i);

                    if (count == 0)
                    {
                        nameToParse = nameToParse + name;
                    }
                    else if (count > 0 && count < nameCount - 1)
                    {
                        nameToParse = nameToParse + ", " + name;
                    }
                    else if (count < nameCount)
                    {
                        nameToParse = nameToParse + " and " + name;
                    }
                    count++;
                    currentBalanceStoDecimal = personWithHighestHistoryBalance[i];
                }
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            string currentBalanceDecimal = $"{currentBalanceStoDecimal:C0}";
            currentBalanceDecimal = currentBalanceDecimal.Replace(",", "");

            return $"{nameToParse} had the most money ever. {currentBalanceDecimal}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {

            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            double higestLossValue = 0;
            double currentValue;

            List<double> highestLossPerPerson = new List<double>();

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {   
                highestLossPerPerson.Add(HighestLossPerPerson(peopleAndBalances[i].Split(',')));
            }

            int highestLossIndex = 0;

            for (int i = 0; i < highestLossPerPerson.Count; i++)
            {
                if (highestLossPerPerson[i] < higestLossValue)
                {
                    higestLossValue = highestLossPerPerson[i];
                    highestLossIndex = i;
                }
            }

            // if a person has only 1 value in history, function will pass minimum double value
            if (higestLossValue == double.MinValue || higestLossValue == 0) return "N/A.";

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            string highestLossPerPersonString = $"{highestLossPerPerson[highestLossIndex]:C0}";
            string highestBalanceName = string.Empty;

            var currPersonData = peopleAndBalances[highestLossIndex].Split(',');
            highestBalanceName = currPersonData[0];

            if (highestLossPerPerson[0] < 0)
            {
                highestLossPerPersonString = highestLossPerPersonString.Replace("(", "-");
                highestLossPerPersonString = highestLossPerPersonString.Replace(")", "");
            }

            highestLossPerPersonString = highestLossPerPersonString.Replace(",", "");

            return $"{highestBalanceName} lost the most money. {highestLossPerPersonString}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            {
                //string highestBalanceName = string.Empty;
                //string currentBalanceS = string.Empty;
                //double higestBalanceValue = default;
                //double currentValue;
                //bool isHighestBalance = false;

                //for (int i = 0; i < peopleAndBalances.Length; i++)
                //{
                //    var currPersonData = peopleAndBalances[i].Split(',');
                //    for (int j = currPersonData.Length - 1; j < currPersonData.Length; j++)
                //    {
                //        bool success = double.TryParse(currPersonData[j], out currentValue);
                //        if (success)
                //        {
                //            var tmpValue = currentValue;
                //            if (tmpValue > higestBalanceValue)
                //            {
                //                higestBalanceValue = tmpValue;
                //                highestBalanceName = currPersonData[0];
                //                isHighestBalance = true;
                //            }
                //        }
                //    }
                //    if (isHighestBalance) currentBalanceS = currPersonData[^1].Substring(0);
                //    isHighestBalance = false;
                //}
            }
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            double[] currentPersonBalance = new double[peopleAndBalances.Length];
            //double[] personWithHighestHistoryBalance = new double[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] currentPerson = new string[peopleAndBalances[i].Length];
                currentPerson = peopleAndBalances[i].Split(',');

                /// <summary>
                /// save highest history balance of every person
                /// </summary>
                currentPersonBalance[i] = CurrentBalance(currentPerson);
            }
            double highestBalance = double.MinValue;
            double[] findRichest = FindPersonWithBiggestBalance(currentPersonBalance, out highestBalance);

            int nameCount = 0;
            for (int i = 0; i < findRichest.Length; i++)
            {
                if (findRichest[i] == highestBalance)
                {
                    nameCount++;
                }
            }

            double currentBalanceStoDecimal = double.MinValue;
            string nameToParse = string.Empty;
            int count = 0;

            for (int i = 0; i < findRichest.Length; i++)
            {
                if (findRichest[i] == highestBalance)
                {
                    string name = FindPersonNameBasedOnIndex(peopleAndBalances, i);

                    if (count == 0)
                    {
                        nameToParse = nameToParse + name;
                    }
                    else if (count > 0 && count < nameCount - 1)
                    {
                        nameToParse = nameToParse + ", " + name;
                    }
                    else if (count < nameCount)
                    {
                        nameToParse = nameToParse + " and " + name;
                    }
                    count++;
                    currentBalanceStoDecimal = findRichest[i];
                }
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            string isOrAre = string.Empty;
            string personOrPeople = string.Empty;

            if (nameCount == 1)
            {
                personOrPeople = "person.";
                isOrAre = " is";
            }
            else
            {
                personOrPeople = "people.";
                isOrAre = " are";
            }

            
            string currentBalanceDecimal = $"{currentBalanceStoDecimal:C0}";
            currentBalanceDecimal = currentBalanceDecimal.Replace(",", "");

            return $"{nameToParse}{isOrAre} the richest {personOrPeople} {currentBalanceDecimal}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {

            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            string lowestBalanceName = string.Empty;
            string currentBalanceS = string.Empty;
            double currentValue;
            bool isLowestBalance = false;
            var tmpValue = double.MaxValue;
            List<string> nameList = new List<string>();

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var currPersonData = peopleAndBalances[i].Split(',');
                for (int j = currPersonData.Length - 1; j < currPersonData.Length; j++)
                {
                    bool success = double.TryParse(currPersonData[j], out currentValue);
                    if (success)
                    {
                        if (currentValue < tmpValue)
                        {
                            tmpValue = currentValue;
                            isLowestBalance = true;
                        }
                    }
                }
                isLowestBalance = false;
            }

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var currPersonData = peopleAndBalances[i].Split(',');
                for (int j = currPersonData.Length - 1; j < currPersonData.Length; j++)
                {
                    bool success = double.TryParse(currPersonData[j], out currentValue);
                    if (success)
                    {
                        if (currentValue == tmpValue)
                        {
                            nameList.Add(currPersonData[0]);
                            isLowestBalance = true;
                        }
                        if (isLowestBalance) currentBalanceS = currPersonData[^1].Substring(0);
                        isLowestBalance = false;
                    }
                }
                
            }

            for (int i=0; i < nameList.Count; i++)
            {
                if (i == 0)
                {
                    lowestBalanceName = lowestBalanceName + nameList[i];
                }
                else if (i < nameList.Count - 1)
                {
                    lowestBalanceName = lowestBalanceName + ", " + nameList[i];
                }
                else if (i < nameList.Count)
                {
                    lowestBalanceName = lowestBalanceName + " and " + nameList[i];
                }
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            
            decimal currentBalanceStoDecimal = Convert.ToDecimal(currentBalanceS);
            string currentBalanceDecimal = $"{currentBalanceStoDecimal:C0}";

            if (currentBalanceStoDecimal < 0)
            {
                currentBalanceDecimal = currentBalanceDecimal.Replace("(", "-");
                currentBalanceDecimal = currentBalanceDecimal.Replace(")", "");
            }

            string hasOrHave = string.Empty;
            if (nameList.Count > 1)
            {
                hasOrHave = " have";
            }
            else
            {
                hasOrHave = " has";
            }

            return $"{lowestBalanceName}{hasOrHave} the least money. {currentBalanceDecimal:C0}.";
        }
    }
}
