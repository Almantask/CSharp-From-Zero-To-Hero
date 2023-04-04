using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class Person
    {
        string _name;
        public string GetName() { return _name; }
        float[] _balances;

        public Person(string name, float[] balances)
        {
            _name = name;
            _balances = balances;
        }

        public float? GetLastBalance()
        {
            if(_balances == null ||_balances.Length == 0)
            {
                return null;
            }
            return _balances[^1];
        }
        public float? GetBiggestLoss()
        {
            if(_balances == null ||_balances.Length < 2)
            {
                return null;
            }

            float BiggestPersonalLoss = 0;
            float difference;
            for (int i = 1; i < _balances.Length; i++)
            {
                difference = _balances[i] - _balances[i - 1];

                if (difference < BiggestPersonalLoss)
                {
                    BiggestPersonalLoss = difference;
                }
            }
            return BiggestPersonalLoss;
        }

        public float? GetHighestBalance()
        {
            if (_balances == null || _balances.Length == 0)
            {
                return null;
            }
            if (_balances.Length == 1)
            {
                return _balances[0];
            }

            float? highestPersonalBalance = _balances[0];
            for (int i = 1; i < _balances.Length; i++)
            {
                float number = _balances[i];
                if (number > highestPersonalBalance)
                {
                    highestPersonalBalance = number;
                }
            }
            return highestPersonalBalance;
        }


    }
}
