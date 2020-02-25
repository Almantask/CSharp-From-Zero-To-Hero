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
            _personAndBalanceArray = ArrayHandler.ConvertToArray(personAndBalance);
            _balance = ArrayHandler.ConvertToBalanceArray(personAndBalance);
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
    }
}
