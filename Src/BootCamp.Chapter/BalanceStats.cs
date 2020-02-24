using System;
using System.Text;

namespace BootCamp.Chapter
{
    public class BalanceStats
    {
        private const string InValidOutput = "N/A.";
        private readonly StringBuilder _persons;
        private readonly decimal _amount;

        public BalanceStats(StringBuilder persons, decimal amount)
        {
            _persons = persons;
            _amount = amount;
        }

        public StringBuilder GetPersons()
        {
            return _persons; 
        }

        public decimal GetAmount()
        {
            return _amount; 
        }

        public static bool IsInValidInput(string[] input) => input == null || input.Length == 0;

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsInValidInput(peopleAndBalances))
            {
                return InValidOutput;
            }

            var answer = BalanceParser.FindHighestBalance(peopleAndBalances);

            return $"{answer.GetPersons()} had the most money ever. ¤{answer.GetAmount()}.";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsInValidInput(peopleAndBalances))
            {
                return InValidOutput;
            }

            var answer = BalanceParser.FindBiggestLoss(peopleAndBalances);

            if (String.IsNullOrEmpty(answer.GetPersons().ToString()))
            {
                return InValidOutput; 
            }

            return $"{answer.GetPersons()} lost the most money. -¤{answer.GetAmount()}.";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsInValidInput(peopleAndBalances))
            {
                return InValidOutput;
            }

            var answer = BalanceParser.FindRichest(peopleAndBalances);

            if (answer.GetPersons().ToString().Contains(", "))
            {
                BalanceParser.ReplaceCommaWithAnd(answer.GetPersons());
                return $"{answer.GetPersons()} are the richest people. ¤{answer.GetAmount()}.";
            }
            else
            {
                return $"{answer.GetPersons()} is the richest person. ¤{answer.GetAmount()}.";
            }

        }
    }
}