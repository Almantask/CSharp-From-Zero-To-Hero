using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Account
    {
        private readonly string _name;
        private readonly decimal[] _balance;

        public Account(string balance)
        {
            _name = AccountOps.GetNameForPerson(balance);
            _balance = AccountOps.GetBalanceForPerson(balance);
        }

        public string GetName()
        {
            return _name;
        }

        public decimal GetHighestBalance()
        {
            var highestBalance = ArrayOps.FindArrayMax(_balance);
            return highestBalance;
        }

        public decimal GetLoss()
        {
            try
            {
                decimal previousBallance = _balance[^2];
                decimal currentBalance = _balance[^1];
                var loss = currentBalance - previousBallance;

                return loss;
            }
            catch (IndexOutOfRangeException)
            {
                // commented it out to keep clean screen
            }
            return default;
        }

        public decimal GetCurrentBalance()
        {
            try
            {
                decimal currentBalance = _balance[^1];

                return currentBalance;
            }
            catch (IndexOutOfRangeException)
            {
                // commented it out to keep clean screen
            }
            return default;
        }

        public decimal GetTotalBalance()
        {
            decimal totalBalance = decimal.Zero;

            for (int i = 0; i < _balance.Length; i++)
            {
                totalBalance += _balance[i];
            }

            return totalBalance;
        }


    }
}
