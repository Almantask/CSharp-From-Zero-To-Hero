namespace BootCamp.Chapter
{
    public class Person
    {
        private readonly string[] _personAndBalanceArray;
        private readonly float[] _balance;

        public Person(string person)
        {
            _personAndBalanceArray = ArrayHandler.ConvertToArray(person);
            _balance = ArrayHandler.ConvertToBalanceArray(person);
        }

        public string GetName()
        {
            return _personAndBalanceArray[0];
        }

        public float[] GetBalanceHistory()
        {
            return _balance;
        }

        public float GetCurrentBalance()
        {
            return _balance[^1];
        }

        public float GetHighestBalance()
        {
            var highestBalance = _balance[0];
            for (int i = 0; i < _balance.Length; i++)
            {
                if (highestBalance < _balance[i])
                {
                    highestBalance = _balance[i];
                }
            }
            return highestBalance;
        }

        public float GetLoss()
        {
            var loss = 0f;
            for (int i = 0; i < _balance.Length - 1; i++)
            {
                if (_balance[i + 1] - _balance[i] < loss)
                {
                    loss = _balance[i + 1] - _balance[i];
                }
            }
            return loss;
        }
    }
}
