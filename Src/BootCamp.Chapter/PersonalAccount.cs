using System.Linq;

namespace BootCamp.Chapter
{
    public class PersonalAccount
    {
        private readonly string _name;
        private readonly decimal[] _balances;
        private readonly decimal[] _netGain;

        public string GetName()
        {
            return _name;
        }
        
        public decimal[] GetBalances()
        {
            return _balances;
        }
        
        public decimal[] GetNetGain()
        {
            return _netGain;
        }

        public decimal? GetMaxBalance()
        {
            if (IsNullOrEmpty(_balances)) return null;
            return _balances.Max();
        }
        
        public decimal? GetMinBalance()
        {
            if (IsNullOrEmpty(_balances)) return null;
            return _balances.Min();
        } 
        
        public decimal? GetLatestBalance()
        {
            if (IsNullOrEmpty(_balances)) return null;
            return _balances[^1];
        } 
        
        public decimal? GetMaxNetGain()
        {
            if (IsNullOrEmpty(_netGain)) return null;
            return _netGain.Max();
        } 
        
        public decimal? GetMinNetGain()
        {
            if (IsNullOrEmpty(_netGain)) return null;
            var minNet = _netGain.Min();
            if (minNet >= 0) return null;
            return _netGain.Min();
        }

        public PersonalAccount(string name)
        {
            _name = name;
        }
        
        public PersonalAccount(string name, decimal[] balances)
        {
            _name = name;
            _balances = balances;
            _netGain = CalculateNetGain();
        }

        private decimal[] CalculateNetGain()
        {
            if (_balances.Length < 1) return new decimal[]{};
            var netGain = new decimal[_balances.Length - 1];

            for (var i = 0; i < netGain.Length; i++)
            {
                var newNet = _balances[i + 1] - _balances[i];
                netGain[i] = newNet;
            }

            return netGain;
        }

        private bool IsNullOrEmpty(decimal[] value)
        {
            return value == null || value.Length == 0;
        }
    }
}
