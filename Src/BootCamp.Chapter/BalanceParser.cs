using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class BalanceParser
    {
        private const string InValidOutput = "N/A.";

        public static BalanceStats FindHighestBalance(string[] balances)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            var persons = new StringBuilder();
            var personWithHighestBalance = new Person("", decimal.MinValue);

            for (int i = 0; i <= balances.Length - 1; i++)
            {
                var currentPersonData = balances[i].Split(',');

                var highestAmountOfPerson = decimal.Parse(currentPersonData[1..].Max(), NumberStyles.Currency);

                if (highestAmountOfPerson > personWithHighestBalance.GetAmount())
                {
                    personWithHighestBalance = new Person(currentPersonData[0], highestAmountOfPerson);
                    persons.Clear();
                }

                if (highestAmountOfPerson >= personWithHighestBalance.GetAmount())
                {
                    AddPerson(currentPersonData[0], persons);
                }
            }

            if (persons.ToString().Contains(", "))
            {
                ReplaceCommaWithAnd(persons);
            }

            return new BalanceStats(persons, personWithHighestBalance.GetAmount());
        }

        private static void AddPerson(string person, StringBuilder sb)
        {
            if (sb.Length == 0)
            {
                sb.Append(person);
            }
            else
            {
                sb.Append(", " + person);
            }
        }

        private static void ReplaceCommaWithAnd(StringBuilder message)
        {
            var index = message.ToString().LastIndexOf(", ");
            message.Remove(index, 2).Insert(index, " and ");
        }

        public static BalanceStats FindBiggestLoss(string[] balances)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            var persons = new StringBuilder();
            var personBiggestLoss = new Person("", decimal.MinValue);

            for (int i = 0; i <= balances.Length - 1; i++)
            {
                var currentPersonData = balances[i].Split(',');
                var allAmounts = currentPersonData[1..];

                // calculateLoss

                if (allAmounts.Length <= 1)
                {
                    return new BalanceStats(new StringBuilder(), 0);
                }

                var biggestLossPerson = FindBiggestLossPerson(allAmounts);

                if (biggestLossPerson > personBiggestLoss.GetAmount())
                {
                    personBiggestLoss = new Person(currentPersonData[0], biggestLossPerson);
                    persons.Clear();
                }

                if (biggestLossPerson >= personBiggestLoss.GetAmount())
                {
                    AddPerson(currentPersonData[0], persons);
                }
            }

            return new BalanceStats(persons, personBiggestLoss.GetAmount());
        }

        private static decimal FindBiggestLossPerson(string[] allAmounts)
        {
            var biggestLossPerson = decimal.MinValue;
            for (int j = 0; j < allAmounts.Length - 1; j++)
            {
                var amount1 = decimal.Parse(allAmounts[j], NumberStyles.Currency | NumberStyles.Number);
                var amount2 = decimal.Parse(allAmounts[j + 1], NumberStyles.Currency | NumberStyles.Number);
                var lossForCurrentPerson = amount1 - amount2;

                //check if loss is greater then the current highest loss
                if (lossForCurrentPerson > biggestLossPerson)
                {
                    biggestLossPerson = lossForCurrentPerson ;
                }
            }

            return biggestLossPerson;
        }
    }
}