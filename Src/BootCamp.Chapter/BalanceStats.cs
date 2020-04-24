using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        public static string FindHighestBalanceEver(Person[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.NotAvailable;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var highestBalanceEver = balances.GetHighestBalanceEver();
            if (highestBalanceEver == null) return Constants.NotAvailable;

            var names = ProcessName(highestBalanceEver);
            var money = highestBalanceEver[0].GetMaxBalance();

            return $"{names} had the most money ever. {ConvertCurrencyToString(money)}.";
        }

        public static string FindPersonWithBiggestLoss(Person[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.NotAvailable;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var personWithBiggestLoss = balances.GetPersonWithBiggestLoss();
            if (personWithBiggestLoss == null) return Constants.NotAvailable;
            
            var names = ProcessName(personWithBiggestLoss);
            var money = personWithBiggestLoss[0].GetMinNetGain();
            
            return $"{names} lost the most money. {ConvertCurrencyToString(money)}.";
        }

        public static string FindRichestPerson(Person[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.NotAvailable;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var richestPerson = balances.GetRichestPerson();
            if (richestPerson == null) return Constants.NotAvailable;
            
            var names = ProcessName(richestPerson);
            var money = richestPerson[0].GetLatestBalance();
            var areOrIs = IsMultiplePeople(names) ? "are" : "is";
            var peopleOrPerson = IsMultiplePeople(names) ? "people" : "person";
            
            return $"{names} {areOrIs} the richest {peopleOrPerson}. {ConvertCurrencyToString(money)}.";
        }

        public static string FindMostPoorPerson(Person[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.NotAvailable;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var mostPoorPerson = balances.GetMostPoorPerson();
            if (mostPoorPerson == null) return Constants.NotAvailable;
            
            var names = ProcessName(mostPoorPerson);
            var money = mostPoorPerson[0].GetLatestBalance();
            var haveOrHas = (IsMultiplePeople(names)) ? "have" : "has";

            return $"{names} {haveOrHas} the least money. {ConvertCurrencyToString(money)}.";
        }
        
        private static Balances CreateBalanceDatabase(Person[] peopleAndBalances)
        {
            var balances = new Balances();
            foreach (var person in peopleAndBalances)
            {
                balances.AddAccount(person.GetName(), person.GetBalances());
            }
            
            return balances;
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
        
        private static bool IsMultiplePeople(string names)
        {
            return names.Contains(",") || names.Contains(" and ");
        }

        private static bool IsNullOrEmpty(Person[] peopleAndBalances)
        {
            return (peopleAndBalances == null || peopleAndBalances.Length == 0);
        }
    }
}
