using System.Globalization;

namespace BootCamp.Chapter
{
    public class Person
    {
        private readonly string _name;
        private readonly decimal[] _balances;

        public Person(string name, decimal[] balances)
        {
            _name = name;
            _balances = balances;
        }

        
        public decimal CurrentBalance()
        {
            return _balances[^1]; 
        }

        public decimal HighestBalance()
        {
            var highestAmount = decimal.MinValue;
            foreach (var amount in _balances )
            {
                if (amount > highestAmount)
                {
                    highestAmount = amount;
                }
            }

            return highestAmount; 
        }

        public decimal LowestBalance()
        {
            var lowestAmount = decimal.MinValue;
            foreach (var amount in _balances)
            {
                if (amount < lowestAmount)
                {
                    lowestAmount = amount;
                }
            }

            return lowestAmount;
        }
        
        public decimal BiggestLoss()
        {
            var biggestLossPerson = decimal.MinValue;
            for (int j = 0; j < _balances.Length - 1; j++)
            {
                var amount1 = _balances[j]; 
                var amount2 = _balances[j + 1];
                var lossForCurrentPerson = amount1 - amount2;

                if (lossForCurrentPerson > biggestLossPerson)
                {
                    biggestLossPerson = lossForCurrentPerson;
                }
            }

            return biggestLossPerson;
        }
    }

        


}
