using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class AccountDetails
    {
        private readonly string _accountName;
        private List<decimal> _accountBalanceHistory;
        private decimal highestBalance;
        private decimal biggestLoss;


        public AccountDetails(string name)
        {
            _accountName = name;
            _accountBalanceHistory = new List<decimal>();
            highestBalance = 0;
            biggestLoss = 0;
        }

        public string GetName()
        {
            return _accountName;
        }

        public void AddBalance(decimal balance)
        {
            _accountBalanceHistory.Add(balance);
            highestBalance = Math.Max(balance, highestBalance);
            biggestLoss = Math.Min(balance, biggestLoss);
        }

        public decimal CurrentBalance()
        {
            if(_accountBalanceHistory.Count != 0)
            {
                return _accountBalanceHistory[^1];
            }
            else
            {
                return 0;
            }
            
        }

        public decimal HighestBalance()
        {
            return highestBalance;
        }

        public decimal BiggestLoss()
        {
            return biggestLoss;
        }

        public void DisplayBalanceHistory()
        {
            for(int i = 0; i < _accountBalanceHistory.Count; i++)
            {
                Console.WriteLine(_accountBalanceHistory[i]); 
            }
            
        }

    }
}
