using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class AnswerFormatter
    {
        public string GetFormattedAnswerForPersonWithBiggestLoss(PersonAndBalance personWithBiggestLoss)
        {
            return $"{personWithBiggestLoss.GetName()} lost the most money. {FormatCurrency(personWithBiggestLoss.GetLoss())}.";
        }

        public string GetFormattedAnswerForHighestBalanceEver(PersonAndBalance[] peopleAndBalances, float highestBalanceEver)
        {
            var peopleWithSameBalance = GetPeopleNamesWithSameBalance(peopleAndBalances, highestBalanceEver, "highest");
            var formatedPeopleNames = FormatPeopleNames(peopleWithSameBalance);
            return $"{formatedPeopleNames} had the most money ever. ¤{highestBalanceEver}.";
        }
        
        public string GetFormattedAnswerForRichestPerson(PersonAndBalance[] peopleAndBalances, float balance)
        {
            var peopleWithSameBalance = GetPeopleNamesWithSameBalance(peopleAndBalances, balance, "current");
            var formatedPeopleNames = FormatPeopleNames(peopleWithSameBalance);

            var areOrIs = (peopleWithSameBalance.Length > 1) ? "are" : "is";
            var peopleOrPerson = (peopleWithSameBalance.Length > 1) ? "people" : "person";
            return $"{formatedPeopleNames} {areOrIs} the richest {peopleOrPerson}. ¤{balance}.";
        }

        public string GetFormattedAnswerForPoorestPerson(PersonAndBalance[] peopleAndBalances, float balance)
        {
            var peopleWithSameBalance = GetPeopleNamesWithSameBalance(peopleAndBalances, balance, "current");
            var formatedPeopleNames = FormatPeopleNames(peopleWithSameBalance);

            var hasOrHave = (peopleWithSameBalance.Length > 1) ? "have" : "has";
            return $"{formatedPeopleNames} {hasOrHave} the least money. {FormatCurrency(balance)}.";
        }

        private string FormatCurrency(float number)
        {
            var originalCulture = CultureInfo.CurrentCulture;
            var culture = CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var clonedNumbers = (NumberFormatInfo)culture.NumberFormat.Clone();
            clonedNumbers.CurrencyNegativePattern = 1;
            var formatedBiggestLoss = string.Format(clonedNumbers, "{0:C0}", number);
            CultureInfo.CurrentCulture = originalCulture;

            return formatedBiggestLoss;
        }

        private string[] GetPeopleNamesWithSameBalance(PersonAndBalance[] peopleAndBalances, float balance, string typeOfBalance)
        {
            var individualPersonAndBalance = 0f;
            var sb = new StringBuilder();
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var person = peopleAndBalances[i];

                if (typeOfBalance.ToLowerInvariant().Equals("current"))
                {
                    individualPersonAndBalance = person.GetCurrentBalance();
                }
                if (typeOfBalance.ToLowerInvariant().Equals("highest"))
                {
                    individualPersonAndBalance = person.GetHighestBalance();
                }
                if (individualPersonAndBalance.Equals(balance))
                {
                    sb.Append($"{person.GetName()}, ");
                }
            }
            // To remove comma at the end.
            var peopleWithSameBalance = sb.ToString().Remove(sb.ToString().Length - 2);
            return ConvertToArray(peopleWithSameBalance);
        }
        private string FormatPeopleNames(string[] peopleNames)
        {
            switch (peopleNames.Length)
            {
                case 1:
                    return peopleNames[0];
                case 2:
                    return $"{peopleNames[0]} and {peopleNames[1]}";
                default:
                    // If need to this can be implemented to loop through the array, in any case only 3 different cases needed.
                    return $"{peopleNames[0]}, {peopleNames[1]} and {peopleNames[2]}";
            }
        }

        private string[] ConvertToArray(string personAndBalance)
        {
            // this to remove white spaces in string array
            personAndBalance = personAndBalance.Replace(", ", ",");
            string[] personAndBalanceArray = personAndBalance.Split(',');
            return personAndBalanceArray;
        }
    }
}
