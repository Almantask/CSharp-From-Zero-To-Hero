using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Account
    {
        private string _name;
        private decimal[] _balance;

        public string getName()
        {
            return _name;
        }
        public void setName(string name)
        {
            _name = name;
        }
        public decimal[] getBalance()
        {
            return _balance;
        }
        public void setBalance(decimal[] balance)
        {
            _balance = balance;
        }

        public decimal CurrentBalance()
        {
            if (_balance == null)
            {
                return 0;
            }

            return _balance[_balance.Length];
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
