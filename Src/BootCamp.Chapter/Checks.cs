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

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            // test doesnt want current balance, he wants highest history balance

            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            Person[] peopleToArray = new Person[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                peopleToArray[i] = CreatePerson(peopleAndBalances[i]);
            }


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

        public static string Build(string message, in int padding)
        {
            return "";
        }

        public static void Clean(string file, string outputFile)
        {
        }
    }
}
