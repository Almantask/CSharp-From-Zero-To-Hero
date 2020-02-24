using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    internal class BalanceParser
    {
        public static BalanceStats FindHighestBalance(string [] balances)
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

        //    public static BalanceStats FindBiggestLoss(BalanceStats data)
        //    {
        //        CultureInfo.CurrentCulture = new CultureInfo("en-GB");
        //        var amounts = data.GetAmounts();
        //        var persons = data.GetPersons();
        //        var personWithBiggesrLoss = new Person("", 0);

        //        for (int i = 0; i <= amounts.Length - 1; i++)
        //        {
        //            var currentPersonData = amounts[i].Split(',');
        //            var allAmounts = currentPersonData[1..];

        //            // calculateLoss

        //            if (allAmounts.Length <= 1)
        //            {
        //                return InValidOutput;
        //            }

        //            for (int j = 0; j < allAmounts.Length - 1; j++)
        //            {
        //                var amount1 = decimal.Parse(allAmounts[j], NumberStyles.Currency | NumberStyles.Number);
        //                var amount2 = decimal.Parse(allAmounts[j + 1], NumberStyles.Currency | NumberStyles.Number);
        //                var lossForCurrentPerson = amount1 - amount2;

        //                //check if loss is greater then the current highest loss
        //                if (lossForCurrentPerson > highestLossEver)
        //                {
        //                    highestLossEver = lossForCurrentPerson;
        //                    personWithHighestLoss.Clear();
        //                    personWithHighestLoss.Append(currentPersonData[0]);
        //                }

        //            }
        //        }
        //    }
    }
}