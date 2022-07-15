using System.Linq;

namespace BootCamp.Chapter
{
    public class Person
    {
        private string _name;
        private int[] _balances;
        
        public Person(string name, int[] balances)
        {
            _name = name;
            _balances = balances;
        }

        public string GetName()
        {
            return _name;
        }

        public int[] GetAllBalances()
        {
            return _balances;
        }

        public int GetCurrentBalance()
        {
            return _balances.Last();
        }

        public int GetHighestBalance()
        {
            return _balances.Max();
        }
    }
}