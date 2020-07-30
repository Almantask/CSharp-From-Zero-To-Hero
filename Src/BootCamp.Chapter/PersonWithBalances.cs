using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class PersonWithBalances
    {
        private readonly string _name;
        private readonly List<float> _balances;

        public PersonWithBalances(string name, float[] balances)
        {
            _name = name;
            _balances = new List<float>(balances);
        }

        public string GetName()
        {
            return _name;
        }

     public float GetLowestBalance()
        {
            return _balances.Min();
        }

        public float GetHighestBalance()
        {
            return _balances.Max();
        }

        public Tuple <bool,float> GetBiggestLoss()
        {
            var biggestLossEver = float.MaxValue;
            if(_balances.Count < 2)
            {
                return new Tuple <bool, float> (false, 0.0f);
            }

            for (int i = 0; i < _balances.Count-1; i++)
            {
                var balanceDifferences = _balances[i + 1] - _balances[i];
                if (balanceDifferences < biggestLossEver)
                {
                    biggestLossEver = balanceDifferences;
                }
            }
            return new Tuple<bool, float>(true, biggestLossEver);
        }

        public float GetCurrentBalance()
        {
            return _balances.Last();
        }
       

    }
}
