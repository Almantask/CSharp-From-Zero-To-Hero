using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class Balances
    {
        private readonly List<PersonalAccount> _account = new List<PersonalAccount>();
        private List<decimal> _balances = new List<decimal>();

        public string[] GetHighestBalanceEver()
        {
            return FindHighestBalanceEver();
        }
        
        public string[] GetPersonWithBiggestLoss()
        {
            return FindPersonWithBiggestLoss();
        }

        public string[] GetMostPoorPerson()
        {
            return FindMostPoorPerson();
        }

        public string[] GetRichestPerson()
        {
            return FindRichestPerson();
        }

        public string GetPersonBalance(string name)
        {
            return ExportPersonBalanceByName(name);
        }

        public string GetAllBalances()
        {
            return ExportAllBalances();
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

        private string[] FindHighestBalanceEver()
        {
            var highestBalance = new decimal?[_account.Count];
            for (var i = 0; i < _account.Count; i++)
            {
                highestBalance[i] = _account[i].GetMaxBalance();
            }
            var moneyValue = highestBalance.Max();
            if (moneyValue == null) return null;

            var indexOfNames = highestBalance.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
            var names = ProcessName(indexOfNames);

            return new[] { names, ConvertCurrencyToString(moneyValue) };
        }
        
        private string[] FindPersonWithBiggestLoss()
        {
            var biggestLoss = new decimal?[_account.Count];
            for (var i = 0; i < _account.Count; i++)
            {
                biggestLoss[i] = _account[i].GetMinNetGain();
            }
            var moneyValue = biggestLoss.Min();
            if (moneyValue == null) return null;

            var indexOfNames = biggestLoss.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
            var names = ProcessName(indexOfNames);

            return new[] { names, ConvertCurrencyToString(moneyValue) };
        }

        private string[] FindMostPoorPerson()
        {
            var mostPoor = new decimal?[_account.Count];
            for (var i = 0; i < _account.Count; i++)
            {
                mostPoor[i] = _account[i].GetLatestBalance();
            }

            var moneyValue = mostPoor.Min();
            if (moneyValue == null) return null;

            var indexOfNames = mostPoor.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
            var names = ProcessName(indexOfNames);

            return new[] { names, ConvertCurrencyToString(moneyValue) };
        }

        private string[] FindRichestPerson()
        {
            var richest = new decimal?[_account.Count];

            for (var i = 0; i < _account.Count; i++)
            {
                richest[i] = _account[i].GetLatestBalance();
            }

            var moneyValue = richest.Max();
            if (moneyValue == null) return null;

            var indexOfNames = richest.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
            var names = ProcessName(indexOfNames);

            return new[] { names, ConvertCurrencyToString(moneyValue) };
        }

        private string ExportPersonBalanceByName(string name)
        {
            var index = FindPersonIndexByName(name);
            if (index == -1) return "Account name not found";

            var account = _account[index];
            var userName = account.GetName();
            var personalBalance = ConvertBalanceToString(account);

            return $"{userName},{personalBalance}";
        }

        private string ExportAllBalances()
        {
            var balance = new StringBuilder();

            foreach (var account in _account)
            {
                var userName = account.GetName();
                var userBalances = ConvertBalanceToString(account);
                balance.AppendLine($"{userName},{userBalances}");
            }

            return balance.ToString();
        }

        //Utilities
        private string ConvertBalanceToString(PersonalAccount account)
        {
            var userBalances = new StringBuilder();
            if (!IsNullOrEmpty(account.GetBalances()))
            {
                userBalances.AppendJoin(',', account.GetBalances());
            }

            return userBalances.ToString();
        }

        private string ProcessName(int[] arrayIndex)
        {
            const string commaJoin = ", ";
            const string andJoin = " and ";
            var names = new StringBuilder();

            for (var i = 0; i < arrayIndex.Length; i++)
            {
                var name = _account[arrayIndex[i]].GetName();
                var join = "";
                if (i == arrayIndex.Length - 1 && i != 0) join = andJoin;
                else if (i > 0) join = commaJoin;

                names.Append(join + name);
            }

            return names.ToString();
        }

        private string ConvertCurrencyToString(decimal? value)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(Constants.CultureLocale);

            var currencySign = (value < 0) ? "-" : "";

            return $"{currencySign}{Constants.CurrencySymbol}{Math.Abs(value.Value)}";
        }

        private bool IsNullOrEmpty(decimal[] value)
        {
            return value == null || value.Length == 0;
        }
    }
}
