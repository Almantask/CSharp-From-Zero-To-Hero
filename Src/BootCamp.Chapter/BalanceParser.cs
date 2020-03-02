using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class BalanceParser
    {
        private const string InValidOutput = "N/A.";

        public static bool IsInValidInput(string[] input) => input == null || input.Length == 0;

        public static Person[] Parser(string[] contents)
        {
            if (contents == null)
            {
                return new Person[0];
            }
            var culture = new CultureInfo("en-GB");
            var allPersons = new Person[contents.Length];
            for (int i = 0; i < contents.Length; i++)
            {
                var data = contents[i];
                var splittedData = data.Split(",");
                var name = splittedData[0];
                var amounts = splittedData[1..];
                var convertedAmounts = new decimal[amounts.Length];
                for (int j = 0; j < amounts.Length; j++)
                {
                    var isValid = decimal.TryParse(amounts[j], NumberStyles.Currency, culture, out decimal number);
                    if (!isValid)
                    {
                        throw new InvalidBalancesException();
                    }

                    convertedAmounts[j] = number;
                }

                allPersons[i] = new Person(name, convertedAmounts);
            }

            return allPersons;
        }

        public static string FindRichestPersonEver(string[] contents)
        {
            if (IsInValidInput(contents))
            {
                return InValidOutput;
            }

            var person = BalanceStats.FindHighestBalanceEver(contents);
            
           

            StringBuilder sb = ConvertToStringBuilder(person);

            var answer = $"{sb.ToString()} had the most money ever. ¤{person[0].HighestBalance()}.";
            return answer;
        }

        public static string FindPoorestPerson(string[] contents)
        {
            if (IsInValidInput(contents))
            {
                return InValidOutput;
            }

            var person = BalanceStats.FindMostPoorPerson(contents); 
            StringBuilder sb = ConvertToStringBuilder(person);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            NumberFormatInfo noParens = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            noParens.CurrencyNegativePattern = 1;
            var lowestBalanceString = person[0].CurrentBalance().ToString("C0", noParens);


            if (sb.ToString().Contains(','))
            {
                return $"{sb.ToString()} have the least money. {lowestBalanceString}.";
            }
            else
            {
                return $"{sb.ToString()} has the least money. {lowestBalanceString}.";
            }

           
        }

        public static string FindPersonWithBiggestLoss(string[] contents)
        {
            if (IsInValidInput(contents))
            {
                return InValidOutput;
            }

            var person = BalanceStats.FindPersonWithBiggestLoss(contents); 
            StringBuilder sb = ConvertToStringBuilder(person);

            if (person.Length == 0 )
            {
                return InValidOutput;
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            NumberFormatInfo noParens = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            noParens.CurrencyNegativePattern = 1;
            var lowestBalanceString = person[0].BiggestLoss().ToString("C0", noParens);

            var answer =  $"{sb.ToString()} lost the most money. {lowestBalanceString}.";
            return answer; 
           
        }



        public static StringBuilder ConvertToStringBuilder(Person[] person)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < person.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append(person[i].GetName());
                }
                else
                {
                    sb.Append(", " + person[i].GetName());
                }
            }

            if (sb.ToString().Contains(','))
            {
                ReplaceCommaWithAnd(sb);
            }

            return sb;
        }

        private static void ReplaceCommaWithAnd(StringBuilder message)
        {
            var index = message.ToString().LastIndexOf(", ");
            message.Remove(index, 2).Insert(index, " and ");
        }
    }
}