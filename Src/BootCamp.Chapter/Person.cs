using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Person
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }

        private List<double> _balances;
        
        public double GetCurrentBalance()
        {
            if (_balances.Count == 0) return 0;
            return _balances[^1];
        }

        public Person(string personInformation)
        {
            string[] splittedPersonInformation = GetSplittedInformation(personInformation);
            if (splittedPersonInformation.Length <= 0) throw new InvalidBalancesException("Forwarded balance doesn't contain information");

            _name = splittedPersonInformation[0];
            _balances = GetBalancesFromInput(splittedPersonInformation);


        }

        public double GetHighestBalanceEver()
        {
            double highestBalance = double.MinValue;

            foreach (double balance in _balances)
            {
                if (balance > highestBalance)
                {
                    highestBalance = balance;
                }
            }

            return highestBalance;
        }

        public double GetBiggestLoss()
        {
            const int minNumberOfBalancesToHaveALoss = 2;
            if (_balances.Count < minNumberOfBalancesToHaveALoss) return double.MinValue;

            double biggestLoss = double.MinValue;

            for (int i = 1; i <= _balances.Count -1; i++)
            {
                double currentLoss = (_balances[i-1] - _balances[i]);
                if (currentLoss > biggestLoss)
                {
                    biggestLoss = currentLoss;
                }    
            }

            return biggestLoss;
        }

        private static string[] GetSplittedInformation(string personInformation)
        {
            return personInformation.Replace("£", "").Split(",");
        }

        private static List<double> GetBalancesFromInput(string[] splittedPersonInformation)
        {
            if (splittedPersonInformation.Length == 1) return new List<double>(0);

            List<double> balances = new List<double>();

            const int FirstBalanceIndex = 1;

            for (int i = FirstBalanceIndex; i <= splittedPersonInformation.Length - 1; i++)
            {
                bool isNumber = double.TryParse(splittedPersonInformation[i], out double balance);

                if (!isNumber)
                {
                    throw new InvalidBalancesException($"{splittedPersonInformation[i]} is not a number");
                }

                balances.Add(balance);
            }
            return balances;

        }
    }

}
