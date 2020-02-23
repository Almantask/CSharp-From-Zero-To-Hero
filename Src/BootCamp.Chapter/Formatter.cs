using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Formatter
    {
        public string GetFormatedAnswerForHighestBalanceEver(PersonAndBalance[] peopleAndBalances, float highestBalanceEver)
        {
            var peopleWithSameBalance = GetPeopleNamesWithSameBalance(peopleAndBalances, highestBalanceEver, "highest");
            var formatedPeopleNames = FormatPeopleNames(peopleWithSameBalance);
            return $"{formatedPeopleNames} had the most money ever. ¤{highestBalanceEver}.";
        }

        public string[] GetPeopleNamesWithSameBalance(PersonAndBalance[] peopleAndBalances, float balance, string typeOfBalance)
        {
            var individualPersonAndBalance = 0f;
            var sb = new StringBuilder();
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var person = peopleAndBalances[i];

                if (typeOfBalance.ToLowerInvariant().Equals("current"))
                {
                    // individualPersonAndBalance = GetCurrentBalancefor(peopleAndBalances[i]);
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
