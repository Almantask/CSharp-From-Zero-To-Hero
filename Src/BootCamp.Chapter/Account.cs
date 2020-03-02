using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Account
    {
        private string _name;
        private decimal[] _balance;

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public decimal[] GetBalance()
        {
            return _balance;
        }
        public void SetBalance(decimal[] balance)
        {
            _balance = balance;
        }

        public Account(string nameAndBalance)
        {
            string[] splitNameAndBalance = nameAndBalance.Split(',');
            SetName(splitNameAndBalance[0]);

            decimal[] balance = new decimal[splitNameAndBalance.Length - 1];

            for (int i = 1; i < splitNameAndBalance.Length; i++)
            {
                Decimal.TryParse(splitNameAndBalance[i], out balance[i-1]);
            }
            SetBalance(balance);
        }
        public decimal CurrentBalance()
        {
            if (_balance == null)
            {
                return 0;
            }

            return _balance[_balance.Length-1];
        }
        public decimal biggestLoss()
        {
            decimal biggestLoss = 0;

            for (int i = _balance.Length; i < 0; i--)
            {
                decimal change = _balance[i] - _balance[i-1];
                if (change < biggestLoss)
                {
                    biggestLoss = change;
                }
            }
            return biggestLoss;
        }
        public decimal highestBalanceEver()
        {
            decimal highestBalance = CurrentBalance();

            for (int i = _balance.Length-1; i <-1 ; i--)
            {
                if (_balance[i] > highestBalance)
                {
                    highestBalance = _balance[i];
                }
            }
            return highestBalance;
        }
    }
}
