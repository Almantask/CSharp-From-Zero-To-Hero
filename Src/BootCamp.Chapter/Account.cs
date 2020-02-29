namespace BootCamp.Chapter
{
    public class Account
    {
        private readonly string _name;
        private readonly decimal[] _balance;

        public Account(string name)
        {
            _name = name;
        }

        public Account(string name, decimal[] balance)
        {
            _name = name;
            _balance = balance;
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
            var highestBalance = ArrayOps.FindMax(_balance);
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