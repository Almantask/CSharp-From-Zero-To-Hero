namespace BootCamp.Chapter
{
    public class Person
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        private decimal[] _balances;
        public decimal[] GetBalances()
        {
            return _balances;
        }
        public void SetBalances(decimal[] balances)
        {
            _balances = balances;
        }

        public decimal GetCurrentBalance()
        {
            return _balances.Length - 1 >= 0 ? _balances[_balances.Length - 1] : 0;
        }

        public decimal GetHighestBalance(string name)
        {
            var highestBalance = 0m;

            foreach (var balance in _balances)
            {
                if (balance > highestBalance)
                {
                    highestBalance = balance;
                }
            }

            return highestBalance;
        }

        public decimal GetSmallestBalance(string name)
        {
            var smallestBalance = decimal.MaxValue;

            foreach (var balance in _balances)
            {
                if (balance < smallestBalance)
                {
                    smallestBalance = balance;
                }
            }

            return smallestBalance;
        }
    }
}
