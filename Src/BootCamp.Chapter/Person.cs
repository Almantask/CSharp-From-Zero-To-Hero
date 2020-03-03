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

        public string GetName()
        {
            return _name;
        }

        public decimal[] GetBalance()
        {
            return _balances;
        }

        public decimal CurrentBalance()
        {
            if (_balances.Length == 0 )
            {
                return 0;
            }

            return _balances[^1];
        }

        public decimal HighestBalance()
        {
            var highestAmount = decimal.MinValue;
            foreach (var amount in _balances)
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
            var amount1 = _balances[^1];
            var amount2 = _balances[^2];
            var lossForCurrentPerson = amount1 - amount2;
            return lossForCurrentPerson;
        }
    }
}