using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
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
                success = double.TryParse(curPersonData[i], NumberStyles.Number, CultureInfo.InvariantCulture, out accValue);
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
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return "";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return "";
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

        public static string Build(string message, in int padding)
        {
            return TextTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner.Clean(file, outputFile);
        }
    }
}
