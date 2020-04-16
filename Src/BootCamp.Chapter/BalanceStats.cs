using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>       
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";
            var (peopleNames, money) = ProcessPeopleAndAbalances(peopleAndBalances, "max");

            return $"{peopleNames} had the most money ever. {FixMoneyFormat(money)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            var (peopleNames, money) = ProcessPeopleAndAbalances(peopleAndBalances, "min");
            if (money >= 0) return "N/A.";

            return $"{peopleNames} lost the most money. {FixMoneyFormat(money)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";
            var (peopleNames, money) = ProcessPeopleAndAbalances(peopleAndBalances, "rich");

            var isPlural = IsMultiplePeople(peopleNames);
            var dictionary = new string[]
            { 
                (isPlural) ? "are" : "is",          // [0]
                (isPlural) ? "people" : "person"    // [1]
            };

            return $"{peopleNames} {dictionary[0]} the richest {dictionary[1]}. {FixMoneyFormat(money)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";
            var (peopleNames, money) = ProcessPeopleAndAbalances(peopleAndBalances, "poor");

            var isPlural = IsMultiplePeople(peopleNames);
            var dictionary = new string[]
            {
                (isPlural) ? "have" : "has",        // [0]
            };

            return $"{peopleNames} {dictionary[0]} the least money. {FixMoneyFormat(money)}.";
        }

        private static (StringBuilder peopleNames, float money) ProcessPeopleAndAbalances(string[] peopleAndBalances, string option)
        {
            var validOptions = new string[] {"max", "min", "rich", "poor"};
            if (!validOptions.Contains(option)) return (new StringBuilder(), 0);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var peopleNames = new string[peopleAndBalances.Length];
            var money = new float[peopleAndBalances.Length];
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleInfo = peopleAndBalances[i].Split(", ");

                var values = ConvertToArrayOfFloats(peopleInfo[1..]);
                peopleNames[i] = peopleInfo[0];

                if (option == "max")
                {
                    money[i] = values.Max();
                }
                else if (option == "min")
                {
                    if (values.Length <= 1) continue;

                    var balance = new float[values.Length - 1];
                    for (int j = 0; j < values.Length - 1; j++)
                    {
                        if (j == values.Length - 1) continue;
                        balance[j] = values[j + 1] - values[j];
                    }
                    money[i] = balance.Min();
                }
                else if (option == "rich" || option == "poor")
                {
                    money[i] = values[^1];
                }
            }

            var isMaxValue = (option == "max" || option == "rich");
            float moneyToAnalyse = (isMaxValue) ? money.Max() : money.Min();
            var listToBuid = AnalisePeopleAndMoney(peopleNames, money, moneyToAnalyse);
            var listOfNames = BuildListOfNames(listToBuid.ToString());

            return (listOfNames, moneyToAnalyse);
        }

        // Convert an array of string to array of floats
        private static float[] ConvertToArrayOfFloats(string[] numbers)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var emptyStrings = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (string.IsNullOrEmpty(numbers[i])) emptyStrings++;
            }

            var tempArray = new float[numbers.Length - emptyStrings];
            var newIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (string.IsNullOrEmpty(numbers[i])) continue;

                if (float.TryParse(numbers[i], out float value))
                {
                    tempArray[newIndex] = value;
                    newIndex++;
                }
            }

            return tempArray;
        }

        // Analyse a raw list of name (with join = ", ") and convert to readable
        // eg.: "John, Will, Mary, " -> "John, Will and Mary
        private static StringBuilder BuildListOfNames(string tempPersonName)
        {
            var text = new StringBuilder();
            if (string.IsNullOrEmpty(tempPersonName)) return text;

            var temp = tempPersonName.Split(", ");

            text.Append(temp[0]);

            if (temp.Length > 2)
            {
                for (int i = 1; i < temp.Length; i++)
                {
                    var commaOrAnd = (i == temp.Length - 1) ? " and" : ",";
                    text.Append($"{commaOrAnd} {temp[i]}");
                }
            }

            return text;
        }

        // Create a raw list of money with same money (if is more than 1)
        private static StringBuilder AnalisePeopleAndMoney(string[] names, float[] money, float moneyToCompare)
        {
            var peoples = new StringBuilder();
            for (int i = 0; i < money.Length; i++)
            {
                if (money[i] == moneyToCompare)
                {
                    peoples.Append($"{names[i]}, ");
                }
            }
            peoples.Length -= 2;

            return peoples;
        }

        // Fix money format to print. -¤9999 instead of (¤9999) 
        private static string FixMoneyFormat(float value)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var currencySign = (value < 0) ? "-" : "";
            var currencySymbol = NumberFormatInfo.CurrentInfo.CurrencySymbol;

            return $"{currencySign}{currencySymbol}{Math.Abs(value)}";
        }

        private static bool IsMultiplePeople(StringBuilder names)
        {
            return (names.ToString().Contains(",") || names.ToString().Contains(" and "));
        }

        private static bool IsNullOrEmpty(string[] peopleAndBalances)
        {
            return (peopleAndBalances == null || peopleAndBalances.Length == 0);
        }
    }
}
