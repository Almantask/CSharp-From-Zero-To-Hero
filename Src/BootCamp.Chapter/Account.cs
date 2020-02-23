using System;

namespace BootCamp.Chapter
{
    public class Account
    {
        private readonly string _name;
        private readonly decimal[] _balance;

        public Account(string balance)
        {
            _name = ArrayOps.GetNameForPerson(balance);
            _balance = ArrayOps.GetBalanceForPerson(balance);
        }

        public string GetName()
        {
            return _name;
        }

        public decimal[] GetBalance()
        {
            return _balance;
        }

        public decimal GetHighestBalance()
        {
            var highestBalance = ArrayOps.FindArrayMax(_balance);

            return highestBalance;
        }

        public decimal GetLoss()
        {
            decimal previousBallance = _balance[^2];
            decimal currentBalance = _balance[^1];
            decimal loss = currentBalance - previousBallance;

            return loss;
        }

        public decimal GetCurrentBalance()
        {
            decimal currentBalance = _balance[^1];

            return currentBalance;
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