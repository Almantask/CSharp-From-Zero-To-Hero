using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class ArrayHandler
    {
        public static float[] ConvertToBalanceArray(string personAndBalance)
        {
            string[] personAndBalanceArray = ConvertToArray(personAndBalance);

            if (personAndBalanceArray.Length == 1)
            {
                float[] noBalance = new float[] { 0 };
                return noBalance;
            }

            float[] balance = new float[personAndBalanceArray.Length - 1];

            for (int i = 1; i < personAndBalanceArray.Length; i++)
            {
                // in this case not using try parse, becase it is known 
                // that array have only numbers 

                balance[i - 1] = float.Parse(personAndBalanceArray[i], NumberStyles.Currency);
            }
            return balance;
        }
        public static string[] ConvertToArray(string personAndBalance)
        {
            // this to remove white spaces in string array
            personAndBalance = personAndBalance.Replace(", ", ",");
            string[] personAndBalanceArray = personAndBalance.Split(',');
            return personAndBalanceArray;
        }
    }
}
