using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 2.
    /// </summary>
    public static class PeoplesBalances
    {
        /// <summary>
        /// Here are people and their balances.
        /// One line = one person.
        /// Line is made by name (no spaces), follow by balances separated by comma (",").
        /// Example: "Gily, 1, 0". Means that currently Gily has 0, which dropped from initial 1.
        /// </summary>
        public static Person[] Balances()
        {
            var tom = new Person("Tom", new[] {15.5m, 200m, 500m, 600m, 200m, 500m, 1000m});
            var katherine = new Person("Katherine", new[] {85m, 0m, -500m, 0m, 500m, 10000m, 1500.99m});
            var bill = new Person("Bill", new[] {99999m, 99970m, 99900m});
            var catie = new Person("Catie", new[] {0m, 500m, 990m, 1300m});
            
            return new[] {tom, katherine, bill, catie};
        }

        public static Person[] CreatePeopleDatabase(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return null;
            
            var people = new List<Person>();
            foreach (var balance in peopleAndBalances)
            {
                var data = balance.Split(",");
                var name = data[0];
                ValidateName(name);

                var balanceInfo = new decimal[0];
                if (data.Length > 1)
                {
                    balanceInfo = ConvertToArrayOfDecimal(data[1..]);
                }
                
                people.Add(new Person(name, balanceInfo));
            }

            return people.ToArray();
        }
        
        private static decimal[] ConvertToArrayOfDecimal(string[] numbers)
        {
            var emptyStrings = numbers.Count(value => string.IsNullOrEmpty(value) || value == " ");

            var decimalArray = new decimal[numbers.Length - emptyStrings];
            var newIndex = 0;
            foreach (var currency in numbers)
            {
                if (string.IsNullOrEmpty(currency)) continue;
                if (!decimal.TryParse(currency, NumberStyles.Currency, 
                    CultureInfo.GetCultureInfo(Constants.CultureLocale), out var value)) continue;

                decimalArray[newIndex] = value;
                newIndex++;
            }

            return decimalArray;
        }

        private static void ValidateName(string name)
        {
            var whiteList = new[]
            {
                ' ',
                '-',
                '\''
            };

            var isValid = name.All(letter => char.IsLetter(letter) || whiteList.Contains(letter));
            if (!isValid) throw new InvalidBalancesException($"{name} is an invalid name.");
        }
    }
}