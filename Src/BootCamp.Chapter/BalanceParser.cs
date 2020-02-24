using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    internal class BalanceParser
    {
        public static BalanceStats FindHighestBalance(BalanceStats data)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            var amounts = data.GetAmounts();
            var persons = data.GetPersons();
            var personWithHighestBalance = new Person("", 0);

            for (int i = 0; i <= amounts.Length - 1; i++)
            {
                var currentPersonData = amounts[i].Split(',');

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
    }
}