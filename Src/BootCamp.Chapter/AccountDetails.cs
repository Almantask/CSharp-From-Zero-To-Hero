using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class AccountDetails
    {
        private string _accountName;
        private List<double> _accountBalanceHistory;
        private double highestBalance;
        private double biggestLoss;


        public AccountDetails(string name)
        {
            _accountName = name;
            _accountBalanceHistory = new List<double>();
            highestBalance = 0;
            biggestLoss = 0;
        }

        public string GetName()
        {
            return _accountName;
        }

        public void AddBalance(double balance)
        {
            _accountBalanceHistory.Add(balance);
            highestBalance = Math.Max(balance, highestBalance);
            biggestLoss = Math.Min(balance, biggestLoss);
        }

        public double CurrentBalance()
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

        public double HighestBalance()
        {
            return highestBalance;
        }

        public double BiggestLoss()
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
