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
            return ArrayOps.FindMax(_balance);
        }

        public decimal GetLoss(int historicBalance = 2)
        {
            if (historicBalance < 2)
            {
                return default;
            }
            decimal previousBalance = _balance[^historicBalance];
            decimal currentBalance = _balance[^(historicBalance - 1)];
            return currentBalance - previousBalance;
        }

        public decimal GetCurrentBalance()
        {
            return _balance[^1];
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