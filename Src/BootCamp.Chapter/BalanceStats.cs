using System;
using System.Text;

namespace BootCamp.Chapter
{
    class BalanceStats
    {
        private readonly StringBuilder _persons;
        private readonly decimal _amount;
        private readonly string[] _amounts;

        public BalanceStats(StringBuilder persons, string[] amounts)
        {
            _persons = persons;
            _amounts = amounts;
        }

        public BalanceStats(StringBuilder persons, decimal amount)
        {
            _persons = persons;
            _amount = amount;
        }

        public string[] GetAmounts()
        {
            return _amounts; 
        }

        public StringBuilder GetPersons() 
        {
            return _persons; 
        }

        public decimal GetAmount()
        {
            return _amount;
        }

        private const string InValidOutput = "N/A.";

        public static bool IsInValidInput(string[] input) => input == null || input.Length == 0;

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsInValidInput(peopleAndBalances))
            {
                return InValidOutput;
            }

            var balanceStat = new BalanceStats(new StringBuilder(), peopleAndBalances);
            var answer = BalanceParser.FindHighestBalance(balanceStat);

            return $"{answer.GetPersons()} had the most money ever. ¤{answer.GetAmount()}.";

        }
    }
}
