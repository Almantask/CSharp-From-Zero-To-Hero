﻿using System;

namespace BootCamp.Chapter
{
    public class Account
    {
        private readonly string _name;
        private readonly decimal[] _balance;
        private readonly string[] _accountArray;
        private char _delimiter = ',';

        public Account(string personAndBalance)
        {
            _accountArray = ArrayOps.ConvertToAccountArray(personAndBalance, _delimiter);
            _name = AccountOps.GetNameForPerson(_accountArray);
            _balance = AccountOps.GetBalanceForPerson(_accountArray);
        }

        public string GetName()
        {
            return _name;
        }

        public decimal[] GetBalance()
        {
            return _balance;
        }

        public char GetDelimiter()
        {
            return _delimiter;
        }

        public void SetDelimiter(char delimiter)
        {
            _delimiter = delimiter;
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
            decimal totalBalance = decimal.MinValue;
            for (int i = 0; i < _balance.Length; i++)
            {
                totalBalance += _balance[i];
            }
            return totalBalance;
        }
    }
}