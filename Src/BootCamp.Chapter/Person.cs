namespace BootCamp.Chapter
{
    public class Person
    {
        private readonly string _name;
        public string GetName()
        {
            return _name;
        }

        private readonly decimal[] _balances;
        public decimal[] GetBalances()
        {
            return _balances;
        }
        
        public Person(string name, decimal[] balances)
        {
            _name = name;
            _balances = balances;
        }
    }
}