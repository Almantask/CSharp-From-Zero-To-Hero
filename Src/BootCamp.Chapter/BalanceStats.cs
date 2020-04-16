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

            var listToBuid = AnalisePeopleAndMoney(peopleNames, money, money.Max());
            var listOfNames = BuildListOfNames(listToBuid.ToString());

            return $"{listOfNames} had the most money ever. {FixMoneyFormat(money.Max())}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            var (peopleNames, money) = ProcessPeopleAndAbalances(peopleAndBalances, "min");
            if (money.Min() >= 0) return "N/A.";

            var listToBuid = AnalisePeopleAndMoney(peopleNames, money, money.Min());
            var listOfNames = BuildListOfNames(listToBuid.ToString());

            return $"{listOfNames} lost the most money. {FixMoneyFormat(money.Min())}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            var (peopleNames, money) = ProcessPeopleAndAbalances(peopleAndBalances, "richAndPoor");

            var listToBuid = AnalisePeopleAndMoney(peopleNames, money, money.Max());
            var listOfNames = BuildListOfNames(listToBuid.ToString());

            return $"{listOfNames} {CheckIfIsPlural(listOfNames)[0]} the richest {CheckIfIsPlural(listOfNames)[1]}. {FixMoneyFormat(money.Max())}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return "N/A.";

            var (peopleNames, money) = ProcessPeopleAndAbalances(peopleAndBalances, "richAndPoor");

            var listToBuid = AnalisePeopleAndMoney(peopleNames, money, money.Min());
            var listOfNames = BuildListOfNames(listToBuid.ToString());

            return $"{listOfNames} {CheckIfIsPlural(listOfNames)[2]} the least money. {FixMoneyFormat(money.Min())}.";
        }

        private static (string[] peopleNames, float[] money) ProcessPeopleAndAbalances(string[] peopleAndBalances, string option)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var peopleNames = new string[peopleAndBalances.Length];
            var money = new float[peopleAndBalances.Length];
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleInfo = peopleAndBalances[i].Split(", ");

                var values = ConvertToArrayOfFloats(peopleInfo[1..]);
                peopleNames[i] = peopleInfo[0];
                switch (option)
                {
                    case "max":
                        money[i] = values.Max();
                        break;

                    case "min":
                        if (values.Length <= 1) break;

                        var balance = new float[values.Length - 1];
                        for (int j = 0; j < values.Length - 1; j++)
                        {
                            if (j == values.Length - 1) break;
                            balance[j] = values[j + 1] - values[j];
                        }
                        money[i] = balance.Min();
                        break;

                    case "richAndPoor":
                        money[i] = values[^1];
                        break;
                }
            }

            return (peopleNames, money);
        }

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

        private static string[] CheckIfIsPlural(StringBuilder names)
        {
            string[] plural;
            if (names.ToString().Contains(",") || names.ToString().Contains(" and "))
            {
                plural = new string[] { "are", "people", "have", };
            }
            else
            {
                plural = new string[] { "is", "person", "has" };
            }

            return plural;
        }

        private static string FixMoneyFormat(float value)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var currencySign = (value < 0) ? "-" : "";
            var currencySymbol = "¤";

            return $"{currencySign}{currencySymbol}{Math.Abs(value)}";
        }

        private static bool IsNullOrEmpty(string[] peopleAndBalances)
        {
            return (peopleAndBalances == null || peopleAndBalances.Length == 0);
        }
    }
}
