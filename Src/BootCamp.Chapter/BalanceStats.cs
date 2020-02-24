using System.Text;

namespace BootCamp.Chapter
{
    internal class BalanceStats
    {
        private const string InValidOutput = "N/A.";
        private StringBuilder _persons;
        private decimal _amount;

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

        //public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        //{
        //    if (IsInValidInput(peopleAndBalances))
        //    {
        //        return InValidOutput;
        //    }

        //    var balanceStat = new BalanceStats(new StringBuilder(), peopleAndBalances);
        //    var answer = BalanceParser.FindBiggestLoss(balanceStat);

        //    return $"{answer.GetPersons()} lost the most money. -¤{answer.GetAmount()}.";
        //}
    }
}