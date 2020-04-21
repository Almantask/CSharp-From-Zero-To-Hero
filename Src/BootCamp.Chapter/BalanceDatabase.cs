using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class BalanceDatabase
    {
        private readonly List<string> _name = new List<string>();
        private readonly List<List<decimal>> _balances = new List<List<decimal>>();
        private readonly List<List<decimal>> _netGain = new List<List<decimal>>();

        public string[] GetRichestPerson()
        {
            return ProcessLatestBalanceByOption("rich");
        }

        public string[] GetMostPoorPerson()
        {
            return ProcessLatestBalanceByOption("poor");
        }

        public string[] GetMaxBalance()
        {
            return MaxBalance();
        }

        public string[] GetMaxLoss()
        {
            return MaxLoss();
        }

        ////ctor
        //public BalancesDatabase()
        //{
        //}

        // Add a new person and your balance
        public void AddNewPerson(string name, List<decimal> balances)
        {
            _name.Add(name);
            _balances.Add(balances);
            _netGain.Add(CalculateNetGain(balances));
        }

        //Methods
        private List<decimal> CalculateNetGain(List<decimal> balances)
        {
            var netGain = new List<decimal>();
            if (balances.Count <= 1) return netGain;

            for (var i = 0; i < balances.Count - 1; i++)
            {
                var newNet = balances[i + 1] - balances[i];
                netGain.Add(newNet);
            }

            return netGain;
        }

        private string[] ProcessLatestBalanceByOption(string option)
        {
            ValidateOption(option, "rich, poor");
            var latestBalance = GenerateLatestBalanceRegistry();

            var moneyValue = (option == "rich") ? latestBalance.Max() : latestBalance.Min();
            if (moneyValue == null) return null;

            var indexOfNames = latestBalance.Select((b, i) => b == moneyValue ? i : -1).Where(i => i != -1).ToArray();
            var names = ProcessName(indexOfNames);

            return new[] { names, ConvertCurrencyToString(moneyValue) };
        }

        private string[] MaxBalance()
        {
            var temp = new List<decimal?>();
            foreach (var balances in _balances)
            {
                var max = balances.Max();
                temp.Add(max);
            }
            var maxBalance = temp.Max();
            if (maxBalance == null) return null;

            var indexOfNames = temp.Select((b, i) => b == maxBalance ? i : -1).Where(i => i != -1).ToArray();
            var names = ProcessName(indexOfNames);

            return new[] { names, ConvertCurrencyToString(maxBalance) };
        }

        private string[] MaxLoss()
        {
            var temp = new List<decimal?>();
            foreach (var netGain in _netGain)
            {
                if (netGain.Count > 0)
                {
                    var loss = netGain.Min();
                    if (loss < 0) 
                    {
                        temp.Add(loss);
                        continue;
                    }
                }
                temp.Add(null);
            }
            var maxLoss = temp.Min();
            if (maxLoss == null) return null;

            var indexOfNames = temp.Select((b, i) => b == maxLoss ? i : -1).Where(i => i != -1).ToArray();
            var names = ProcessName(indexOfNames);

            return new[] {names, ConvertCurrencyToString(maxLoss)};
        }

        private List<decimal?> GenerateLatestBalanceRegistry()
        {
            var temp = new List<decimal?>();
            foreach (var balance in _balances)
            {
                if (balance.Count == 0)
                {
                    temp.Add(null);
                    continue;
                }
                temp.Add(balance[^1]);
            }

            return temp;
        }

        private string ProcessName(int[] arrayIndex)
        {
            const string commaJoin = ", ";
            const string andJoin = " and ";
            var names = new StringBuilder();

            for (var i = 0; i < arrayIndex.Length; i++)
            {
                var name = _name[arrayIndex[i]];
                var join = "";
                if (i == arrayIndex.Length - 1 && i != 0) join = andJoin;
                else if (i > 0) join = commaJoin;

                names.Append(join + name);
            }

            return names.ToString();
        }

        private void ValidateOption(string option, string validOptions)
        {
            var valuesToValidate = validOptions.Split(", ");
            var isValid = false;
            foreach (var validOption in valuesToValidate)
            {
                if (option.Equals(validOption))
                {
                    isValid = true;
                    break;
                }
            }

            if (!isValid) throw new InvalidBalancesException($"{option} is not a valid option.");
        }

        private string ConvertCurrencyToString(decimal? value)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(Constants.CultureLocale);

            var currencySign = (value < 0) ? "-" : "";

            return $"{currencySign}{Constants.CurrencySymbol}{Math.Abs(value.Value)}";
        }
    }
}
