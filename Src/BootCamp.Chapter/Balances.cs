using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Balances
    {
        private readonly List<PersonalAccount> _account = new List<PersonalAccount>();

        public PersonalAccount[] GetAllBalances()
        {
            return _account.ToArray();
        }

        public PersonalAccount[] GetHighestBalanceEver()
        {
            return FindHighestBalanceEver();
        }
        
        public PersonalAccount[] GetPersonWithBiggestLoss()
        {
            return FindPersonWithBiggestLoss();
        }

        public PersonalAccount[] GetMostPoorPerson()
        {
            return FindMostPoorPerson();
        }

        public PersonalAccount[] GetRichestPerson()
        {
            return FindRichestPerson();
        }

        public PersonalAccount GetPersonBalance(string name)
        {
            return ExportPersonBalanceByName(name);
        }

        // Ctr
        public void AddAccount(string name, decimal[] balances)
        {
            _account.Add(new PersonalAccount(name, balances));
        }
        public void AddAccount(string name)
        {
            _account.Add(new PersonalAccount(name));
        }

        //Gets
        private int FindPersonIndexByName(string searchName)
        {
            for (var index = 0; index < _account.Count; index++)
            {
                var accountName = _account[index].GetName().ToLower();
                if (searchName.ToLower().Equals(accountName))
                {
                    return index;
                }
            }

            return -1;
        }
        
        private PersonalAccount[] FindHighestBalanceEver()
        {
            var highestBalance = new decimal?[_account.Count];
            for (var i = 0; i < _account.Count; i++)
            {
                highestBalance[i] = _account[i].GetMaxBalance();
            }
            var moneyValue = highestBalance.Max();
            if (moneyValue == null) return null;
            var indexOfNames = highestBalance.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
            
            return BuildAccountListByIndex(indexOfNames);
        }
        
        private PersonalAccount[] FindPersonWithBiggestLoss()
        {
            var biggestLoss = new decimal?[_account.Count];
            for (var i = 0; i < _account.Count; i++)
            {
                biggestLoss[i] = _account[i].GetMinNetGain();
            }
            var moneyValue = biggestLoss.Min();
            if (moneyValue == null) return null;
            var indexOfNames = biggestLoss.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
                        
            return BuildAccountListByIndex(indexOfNames);
        }

        private PersonalAccount[] FindMostPoorPerson()
        {
            var mostPoor = new decimal?[_account.Count];
            for (var i = 0; i < _account.Count; i++)
            {
                mostPoor[i] = _account[i].GetLatestBalance();
            }

            var moneyValue = mostPoor.Min();
            if (moneyValue == null) return null;
            var indexOfNames = mostPoor.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
            
            return BuildAccountListByIndex(indexOfNames);
        }

        private PersonalAccount[] FindRichestPerson()
        {
            var richest = new decimal?[_account.Count];
            for (var i = 0; i < _account.Count; i++)
            {
                richest[i] = _account[i].GetLatestBalance();
            }

            var moneyValue = richest.Max();
            if (moneyValue == null) return null;
            var indexOfNames = richest.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
            
            return BuildAccountListByIndex(indexOfNames);
        }

        private PersonalAccount ExportPersonBalanceByName(string name)
        {
            var index = FindPersonIndexByName(name);
            if (index == -1) return null;

            return _account[index];
        }
        
        private PersonalAccount[] BuildAccountListByIndex(int[] indexes)
        {
            var accounts = new PersonalAccount[indexes.Length];
            for (var i = 0; i < indexes.Length; i++)
            {
                var accIndex = indexes[i];
                accounts[i] = _account[accIndex];
            }

            return accounts;
        }
    }
}
