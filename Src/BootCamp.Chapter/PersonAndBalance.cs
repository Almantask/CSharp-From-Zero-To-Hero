using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class PersonAndBalance
    {
        private string _personAndBalance;
        private string[] _personAndBalanceArray;
        private float[] _balance;

        public PersonAndBalance(string personAndBalance)
        {
            _personAndBalance = personAndBalance;
            _personAndBalanceArray = ConvertToArray();
            _balance = CreateBalanceArray();
        }

        public string GetName()
        {
            return _personAndBalanceArray[0];
        }

        public float[] GetBalanceHistory()
        {
            return _balance;
        }

        public float GetCurrentBalance()
        {
            return _balance[^1];
        }
        public float GetHighestBalance()
        {
            var highestBalance = _balance[0];
            for (int i = 0; i < _balance.Length; i++)
            {
                if (highestBalance < _balance[i])
                {
                    highestBalance = _balance[i];
                }
            }
            return highestBalance;
        }

        public float GetLoss()
        {
            var loss = 0f;
            for (int i = 0; i < _balance.Length - 1; i++)
            {
                if (_balance[i + 1] - _balance[i] < loss)
                {
                    loss = _balance[i + 1] - _balance[i];
                }
            }
            return loss;
        }

        private float[] CreateBalanceArray()
        {
            if (_personAndBalanceArray.Length == 1)
            {
                float[] noBalance = new float[] { 0 };
                return noBalance;
            }

            float[] balance = new float[_personAndBalanceArray.Length - 1];

            for (int i = 1; i < _personAndBalanceArray.Length; i++)
            {
                // in this case not using try parse, becase it is known 
                // that array have only numbers 
                balance[i - 1] = float.Parse(_personAndBalanceArray[i], NumberStyles.Currency);
            }
            return balance;
        }

        private string[] ConvertToArray()
        {
            // this to remove white spaces in string array
            _personAndBalance = _personAndBalance.Replace(", ", ",");
            string[] personAndBalanceArray = _personAndBalance.Split(',');
            return personAndBalanceArray;
        }

    }
}
