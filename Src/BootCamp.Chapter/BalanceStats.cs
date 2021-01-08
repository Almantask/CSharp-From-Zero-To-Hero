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
        public static string FindHighestBalanceEver(string[] peoplesBalances)
        {
            if (IsNullOrEmpty(peoplesBalances))

                return "N/A.";

            var (peopleNames, cash) = CalculatePB(peoplesBalances, "max");

            return $"{peopleNames} had the most money ever. {FormatCash(cash)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peoplesBalances)
        {
            if (IsNullOrEmpty(peoplesBalances))

                return "N/A.";

            var (peopleNames, cash) = CalculatePB(peoplesBalances, "min");

            if (cash >= 0)

                return "N/A.";

            return $"{peopleNames} lost the most money. {FormatCash(cash)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>

        public static string FindRichestPerson(string[] peoplesBalances)
        {
            if (IsNullOrEmpty(peoplesBalances))

                return "N/A.";

            var (peopleNames, cash) = CalculatePB(peoplesBalances, "rich");
            var subjects = PeoplePlus(peopleNames);
            var word = new string[]
            {
                (subjects) ? "are" : "is",
                (subjects) ? "people" : "person"
            };
            return $"{peopleNames} {word[0]} the richest {word[1]}. {FormatCash(cash)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peoplesBalances)
        {
            if (IsNullOrEmpty(peoplesBalances))

                return "N/A.";

            var (peopleNames, cash) = CalculatePB(peoplesBalances, "poor");
            var subjects = PeoplePlus(peopleNames);
            var word = new string[]
            {
                (subjects) ? "have" : "has",
            };

            return $"{peopleNames} {word[0]} the least money. {FormatCash(cash)}.";
        }

        private static (StringBuilder peopleNames, float cash) CalculatePB(string[] peoplesBalances, string attribution)
        {
            var validation = new string[]
            { "max", "min", "rich", "poor" };

            if (!validation.Contains(attribution)) return (new StringBuilder(), 0);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var peopleNames = new string[peoplesBalances.Length];
            var cash = new float[peoplesBalances.Length];
            int i, j;

            for (i = 0; i < peoplesBalances.Length; i++)
            {
                var peopleInfo = peoplesBalances[i].Split(", ");
                var values = NumPyArrayConversion(peopleInfo[1..]);

                peopleNames[i] = peopleInfo[0];

                if (attribution == "max")
                {
                    cash[i] = values.Max();
                }
                else if (attribution == "min")
                {
                    if (values.Length <= 1) continue;

                    var balance = new float[values.Length - 1];

                    for (j = 0; j < values.Length - 1; j++)
                    {
                        if (j == values.Length - 1) continue;
                        balance[j] = values[j + 1] - values[j];
                    }
                    cash[i] = balance.Min();
                }
                else if (attribution == "rich" || attribution == "poor")
                {
                    cash[i] = values[^1];
                }
            }
            var maximumCash = (attribution == "max" || attribution == "rich");
            float cashCheck = (maximumCash) ? cash.Max() : cash.Min();
            var listBuilder = LookForPeopleCash(peopleNames, cash, cashCheck);
            var listAllNames = ListNames(listBuilder.ToString());

            return (listAllNames, cashCheck);
        }

        private static bool PeoplePlus(StringBuilder names)
        {
            return (names.ToString().Contains(",") || names.ToString().Contains(" and "));
        }

        private static bool IsNullOrEmpty(string[] peoplesBalances)
        {
            return (peoplesBalances == null || peoplesBalances.Length == 0);
        }

        private static float[] NumPyArrayConversion(string[] numbers)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var nullString = 0;
            int i, j;

            for (i = 0; i < numbers.Length; i++)
            {
                if (string.IsNullOrEmpty(numbers[i])) nullString++;
            }

            var convertList = new float[numbers.Length - nullString];
            j = 0;

            for (i = 0; i < numbers.Length; i++)
            {
                if (string.IsNullOrEmpty(numbers[i]))
                    continue;

                if (float.TryParse(numbers[i], out float numeric))
                {
                    convertList[j] = numeric;
                    j++;
                }
            }
            return convertList;
        }

        private static StringBuilder ListNames(string nameLine)
        {
            var output = new StringBuilder();
            if (string.IsNullOrEmpty(nameLine))

                return output;

            var convert = nameLine.Split(", ");
            int i;

            output.Append(convert[0]);

            if (convert.Length > 2)
            {
                for (i = 1; i < convert.Length; i++)
                {
                    var andCom = (i == convert.Length - 1) ? " and" : ",";
                    output.Append($"{andCom} {convert[i]}");
                }
            }
            return output;
        }

        private static StringBuilder LookForPeopleCash(string[] names, float[] cash, float cashValidator)
        {
            var pax = new StringBuilder();
            int i;

            for (i = 0; i < cash.Length; i++)
            {
                if (cash[i] == cashValidator)
                {
                    pax.Append($"{names[i]}, ");
                }
            }
            pax.Length -= 2;

            return pax;
        }

        private static string FormatCash(float numeric)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var currencySeparator = (numeric < 0) ? "-" : "";
            var currencySign = NumberFormatInfo.CurrentInfo.CurrencySymbol;

            return $"{currencySeparator}{ currencySign}{Math.Abs(numeric)}";
        }
    }
}