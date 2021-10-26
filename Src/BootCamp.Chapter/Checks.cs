using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
      
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            // test doesnt want current balance, he wants highest history balance

            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            Person[] peopleToArray = new Person[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                peopleToArray[i] = CreatePerson(peopleAndBalances[i]);
            }

            decimal highestHisBal = decimal.MinValue;
            decimal tmpHighestHisBal;
            string nameOfPersonWithHighestHistoryBalance = string.Empty;
            List<string> addPeopleNamesWithHighestHistoryBalance = new List<string>();

            for (int i = 0; i < peopleToArray.Length; i++)
            {
                tmpHighestHisBal = FindHighHisBal(peopleToArray[i].PersonBalance);
                if (highestHisBal < tmpHighestHisBal)
                {
                    highestHisBal = tmpHighestHisBal;
                    nameOfPersonWithHighestHistoryBalance = peopleToArray[i].PersonName;
                }
            }

            for (int i = 0; i < peopleToArray.Length; i++)
            {
                tmpHighestHisBal = FindHighHisBal(peopleToArray[i].PersonBalance);
                if (highestHisBal == tmpHighestHisBal)
                {
                    addPeopleNamesWithHighestHistoryBalance.Add(peopleToArray[i].PersonName);
                }
            }

            int count = 0;

            for (int i = 0; i < addPeopleNamesWithHighestHistoryBalance.Count; i++)
            {
                if (count == 0)
                {
                    nameOfPersonWithHighestHistoryBalance = addPeopleNamesWithHighestHistoryBalance[i];
                }
                else if (count > 0 && count < addPeopleNamesWithHighestHistoryBalance.Count - 1)
                {
                    nameOfPersonWithHighestHistoryBalance = nameOfPersonWithHighestHistoryBalance + ", " + addPeopleNamesWithHighestHistoryBalance[i];
                }
                else if (count < addPeopleNamesWithHighestHistoryBalance.Count)
                {
                    nameOfPersonWithHighestHistoryBalance = nameOfPersonWithHighestHistoryBalance + " and " + addPeopleNamesWithHighestHistoryBalance[i];
                }
                count++;

            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            string currentBalanceDecimal = $"{highestHisBal:C0}";
            currentBalanceDecimal = currentBalanceDecimal.Replace(",", "");

            return $"{nameOfPersonWithHighestHistoryBalance} had the most money ever. {currentBalanceDecimal}.";
        }

        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            Person[] peopleToArray = new Person[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                peopleToArray[i] = CreatePerson(peopleAndBalances[i]);
            }

            decimal lowestValue = decimal.MaxValue;
            decimal tmpLowestValue;
            string nameOfPersonWithLowestBalance = string.Empty;
            List<string> addPeopleNamesWithLowestBalance = new List<string>();

            for (int i = 0; i < peopleToArray.Length; i++)
            {
                tmpLowestValue = FindLowestBal(peopleToArray[i].PersonBalance);
                if (tmpLowestValue < lowestValue)
                {
                    lowestValue = tmpLowestValue;
                    nameOfPersonWithLowestBalance = peopleToArray[i].PersonName;
                }
            }

            for (int i = 0; i < peopleToArray.Length; i++)
            {
                tmpLowestValue = FindLowestBal(peopleToArray[i].PersonBalance);
                if (lowestValue == tmpLowestValue)
                {
                    addPeopleNamesWithLowestBalance.Add(peopleToArray[i].PersonName);
                }
            }

            int count = 0;

            for (int i = 0; i < addPeopleNamesWithLowestBalance.Count; i++)
            {
                if (count == 0)
                {
                    nameOfPersonWithLowestBalance = addPeopleNamesWithLowestBalance[i];
                }
                else if (count > 0 && count < addPeopleNamesWithLowestBalance.Count - 1)
                {
                    nameOfPersonWithLowestBalance = nameOfPersonWithLowestBalance + ", " + addPeopleNamesWithLowestBalance[i];
                }
                else if (count < addPeopleNamesWithLowestBalance.Count)
                {
                    nameOfPersonWithLowestBalance = nameOfPersonWithLowestBalance + " and " + addPeopleNamesWithLowestBalance[i];
                }
                count++;

            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            string currentBalanceDecimal = $"{lowestValue:C0}";
            string hasOrHad = string.Empty;
            if (addPeopleNamesWithLowestBalance.Count == 1)
            {
                hasOrHad = " has";
            }
            else
            {
                hasOrHad = " have";
            }

            if (lowestValue < 0)
            {
                currentBalanceDecimal = currentBalanceDecimal.Replace("(", "-");
                currentBalanceDecimal = currentBalanceDecimal.Replace(")", "");
            }

            currentBalanceDecimal = currentBalanceDecimal.Replace(",", "");

            return $"{nameOfPersonWithLowestBalance}{hasOrHad} the least money. {currentBalanceDecimal}.";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            Person[] peopleToArray = new Person[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                peopleToArray[i] = CreatePerson(peopleAndBalances[i]);
            }

            double[] currentPersonBalance = new double[peopleAndBalances.Length];

            for (int i = 0; i < peopleToArray.Length; i++)
            {
                /// <summary>
                /// save highest history balance of every person
                /// </summary>
                int index = peopleToArray[i].PersonBalance.Count;
                currentPersonBalance[i] = Convert.ToDouble(peopleToArray[i].PersonBalance[index - 1]);
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
                    string name = peopleToArray[i].PersonName;

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

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            Person[] peopleToArray = new Person[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                peopleToArray[i] = CreatePerson(peopleAndBalances[i]);
            }

            double higestLossValue = 0;
            double currentValue;

            List<double> highestLossPerPerson = new List<double>();

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                highestLossPerPerson.Add(HighestLossPerPerson(peopleToArray[i].PersonBalance));
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

            //var currPersonData = peopleAndBalances[highestLossIndex].Split(',');
            var currPersonData = peopleToArray[highestLossIndex].PersonName;
            highestBalanceName = currPersonData;

            if (highestLossPerPerson[0] < 0)
            {
                highestLossPerPersonString = highestLossPerPersonString.Replace("(", "-");
                highestLossPerPersonString = highestLossPerPersonString.Replace(")", "");
            }

            highestLossPerPersonString = highestLossPerPersonString.Replace(",", "");

            return $"{highestBalanceName} lost the most money. {highestLossPerPersonString}.";
        }

        public static string Build(string message, in int padding)
        {
            return TextTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner.Clean(file, outputFile);
        }

        public static Person CreatePerson(string personData)
        {
            string[] tmpPersonData = personData.Split(',');

            Person person = new Person();

            for (int i = 0; i < tmpPersonData.Length; i++)
            {
                if (i == 0)
                {
                    person.PersonName = tmpPersonData[i];
                }
                else
                {
                    person.UpdatePersonBalance(tmpPersonData[i]);
                }
            }

            return person;
        }

        public static double HighestLossPerPerson(List<string> curPersonData)
        {
            double highestDifference = double.MinValue;
            double[] accValues = new double[curPersonData.Count];
            double tmpValue = 0;
            bool success = false;
            double result;

            for (int i = 0; i < accValues.Length; i++)
            {
                success = double.TryParse(curPersonData[i], NumberStyles.Number, CultureInfo.InvariantCulture, out result);
                if (success)
                {
                    if (i < accValues.Length - 1)
                    {
                        accValues[i] = result;
                    }
                    else
                    {
                        accValues[i] = double.Parse(curPersonData[^1], CultureInfo.InvariantCulture);
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
                    tmpValue = SubtractNumbers(accValues[i], accValues[i + 1]);
                    if (tmpValue > highestDifference) highestDifference = tmpValue * -1;
                }
            }

            return highestDifference;
        }

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

            highestBalance = tmpHighestBalance;

            return personWithHighestBalance;
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

            return diff;
        }

        public static decimal FindLowestBal(List<string> currPeronBalanceHistory)
        {
            decimal tmpValue = decimal.MaxValue;
            decimal value;

            for (int i = 0; i < currPeronBalanceHistory.Count; i++)
            {
                value = Convert.ToDecimal(currPeronBalanceHistory[i], CultureInfo.InvariantCulture);
                if (value < tmpValue) tmpValue = value;
            }

            return tmpValue;
        }

        public static decimal FindHighHisBal(List<string> currPeronBalanceHistory)
        {
            decimal tmpValue = decimal.MinValue;
            decimal value;

            for (int i = 0; i < currPeronBalanceHistory.Count; i++)
            {
                value = Convert.ToDecimal(currPeronBalanceHistory[i], CultureInfo.InvariantCulture);
                if (tmpValue < value) tmpValue = value;
            }

            return tmpValue;
        }
    }
}
