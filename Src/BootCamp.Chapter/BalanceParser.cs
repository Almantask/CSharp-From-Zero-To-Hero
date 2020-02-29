using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class BalanceParser
    {
        public Person[] Parser(string[] contents)
        {
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
    }
}