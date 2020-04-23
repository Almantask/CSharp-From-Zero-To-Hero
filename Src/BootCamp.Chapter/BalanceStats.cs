using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.NotAvailable;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var highestBalanceEver = balances.GetHighestBalanceEver();
            if (highestBalanceEver == null) return Constants.NotAvailable;

            var names = ProcessName(highestBalanceEver);
            var money = highestBalanceEver[0].GetMaxBalance();

            return $"{names} had the most money ever. {ConvertCurrencyToString(money)}.";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.NotAvailable;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var personWithBiggestLoss = balances.GetPersonWithBiggestLoss();
            if (personWithBiggestLoss == null) return Constants.NotAvailable;
            
            var names = ProcessName(personWithBiggestLoss);
            var money = personWithBiggestLoss[0].GetMinNetGain();
            
            return $"{names} lost the most money. {ConvertCurrencyToString(money)}.";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.NotAvailable;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var richestPerson = balances.GetRichestPerson();
            if (richestPerson == null) return Constants.NotAvailable;
            
            var names = ProcessName(richestPerson);
            var money = richestPerson[0].GetLatestBalance();
            var dictionary = new string[2];
            dictionary[0] = (IsMultiplePeople(names)) ? "are" : "is";
            dictionary[1] = (IsMultiplePeople(names)) ? "people" : "person";
            
            return $"{names} {dictionary[0]} the richest {dictionary[1]}. {ConvertCurrencyToString(money)}.";
        }

        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.NotAvailable;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var mostPoorPerson = balances.GetMostPoorPerson();
            if (mostPoorPerson == null) return Constants.NotAvailable;
            
            var names = ProcessName(mostPoorPerson);
            var money = mostPoorPerson[0].GetLatestBalance();
            var dictionary = new string[1];
            dictionary[0] = (IsMultiplePeople(names)) ? "have" : "has";

            return $"{names} {dictionary[0]} the least money. {ConvertCurrencyToString(money)}.";
        }

        private static Balances CreateBalanceDatabase(string[] peopleAndBalances)
        {
            var balances = new Balances();
            foreach (var personStats in peopleAndBalances)
            {
                var stats = personStats.Split(",");
                var name = stats[0];
                ValidateName(name);

                var balanceInfo = new decimal[0];
                if (stats.LongLength > 1)balanceInfo = ConvertToArrayOfDecimal(stats[1..]);

                balances.AddAccount(name, balanceInfo);
            }
            
            return balances;
        }

        private static decimal[] ConvertToArrayOfDecimal(string[] numbers)
        {
            var emptyStrings = numbers.Count(value => string.IsNullOrEmpty(value) || value == " ");

            var decimalArray = new decimal[numbers.Length - emptyStrings];
            var newIndex = 0;
            foreach (var currency in numbers)
            {
                if (string.IsNullOrEmpty(currency)) continue;
                if (!decimal.TryParse(currency, NumberStyles.Currency, CultureInfo.GetCultureInfo(Constants.CultureLocale), out var value)) continue;

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

        private static bool IsMultiplePeople(string names)
        {
            return names.Contains(",") || names.Contains(" and ");
        }

        private static bool IsNullOrEmpty(string[] peopleAndBalances)
        {
            return (peopleAndBalances == null || peopleAndBalances.Length == 0);
        }
        
        //Utilities
        private static string ProcessName(PersonalAccount[] accounts)
        {
            const string commaJoin = ", ";
            const string andJoin = " and ";
            var names = new StringBuilder();

            for (var i = 0; i < accounts.Length; i++)
            {
                var name = accounts[i].GetName();
                var join = "";
                if (i == accounts.Length - 1 && i != 0) join = andJoin;
                else if (i > 0) join = commaJoin;

                names.Append(join + name);
            }

            return names.ToString();
        }

        private static string ConvertCurrencyToString(decimal? value)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(Constants.CultureLocale);

            var currencySign = (value < 0) ? "-" : "";

            return $"{currencySign}{Constants.CurrencySymbol}{Math.Abs(value.Value)}";
        }
    }
}
