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
            int iOne, iTwo;

            for (iOne = 0; iOne < peoplesBalances.Length; iOne++)
            {
                var peopleInfo = peoplesBalances[iOne].Split(", ");
                var values = NumPyArrayConversion(peopleInfo[1..]);

                peopleNames[iOne] = peopleInfo[0];

                if (attribution == "max")
                {
                    cash[iOne] = values.Max();
                }
                else if (attribution == "min")
                {
                    if (values.Length <= 1) continue;

                    var balance = new float[values.Length - 1];

                    for (iTwo = 0; iTwo < values.Length - 1; iTwo++)
                    {
                        if (iTwo == values.Length - 1) continue;
                        balance[iTwo] = values[iTwo + 1] - values[iTwo];
                    }
                    cash[iOne] = balance.Min();
                }
                else if (attribution == "rich" || attribution == "poor")
                {
                    cash[iOne] = values[^1];
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
            int iThree, iFour;

            for (iThree = 0; iThree < numbers.Length; iThree++)
            {
                if (string.IsNullOrEmpty(numbers[iThree])) nullString++;
            }

            var convertList = new float[numbers.Length - nullString];
            iFour = 0;

            for (iThree = 0; iThree < numbers.Length; iThree++)
            {
                if (string.IsNullOrEmpty(numbers[iThree]))
                    continue;

                else if (float.TryParse(numbers[iThree], out float numeric))
                {
                    convertList[iFour] = numeric;
                    iFour++;
                    continue;
                }
                else
                {
                    convertList[iFour] = numeric;
                    iFour++;
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
            int iFive;

            output.Append(convert[0]);

            if (convert.Length > 2)
            {
                for (iFive = 1; iFive < convert.Length; iFive++)
                {
                    var andCom = (iFive == convert.Length - 1) ? " and" : ",";
                    output.Append($"{andCom} {convert[iFive]}");
                }
            }
            return output;
        }

        private static StringBuilder LookForPeopleCash(string[] names, float[] cash, float cashValidator)
        {
            var pax = new StringBuilder();
            int iSix;

            for (iSix = 0; iSix < cash.Length; iSix++)
            {
                if (cash[iSix] == cashValidator)
                {
                    pax.Append($"{names[iSix]}, ");
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