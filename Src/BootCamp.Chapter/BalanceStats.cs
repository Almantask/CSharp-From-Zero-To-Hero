using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        private const string conversionNotPerformed = "N/A.";
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>       
        public static string FindHighestBalanceEver(string[] peoplesBalances)
        {
            if (IsNullOrEmpty(peoplesBalances))

                return conversionNotPerformed;

            var (peopleNames, cashIndex) = CalculatePeoplesBalances(peoplesBalances, "max");

            return $"{peopleNames} had the most money ever. {FormatCash(cashIndex)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peoplesBalances)
        {
            if (IsNullOrEmpty(peoplesBalances))

                return conversionNotPerformed;

            var (peopleNames, cashIndex) = CalculatePeoplesBalances(peoplesBalances, "min");

            if (cashIndex >= 0)

                return conversionNotPerformed;

            return $"{peopleNames} lost the most money. {FormatCash(cashIndex)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>

        public static string FindRichestPerson(string[] peoplesBalances)
        {
            if (IsNullOrEmpty(peoplesBalances))

                return conversionNotPerformed;

            var (peopleNames, cashIndex) = CalculatePeoplesBalances(peoplesBalances, "rich");
            var subjects = PeoplePlus(peopleNames);
            var word = new string[]
            {
                (subjects) ? "are" : "is",
                (subjects) ? "people" : "person"
            };
            return $"{peopleNames} {word[0]} the richest {word[1]}. {FormatCash(cashIndex)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peoplesBalances)
        {
            if (IsNullOrEmpty(peoplesBalances)) 
                
                return conversionNotPerformed;

            var (peopleNames, cashIndex) = CalculatePeoplesBalances(peoplesBalances, "poor");
            var subjects = PeoplePlus(peopleNames);
            var word = new string[]
            {
                (subjects) ? "have" : "has",
            };

            return $"{peopleNames} {word[0]} the least money. {FormatCash(cashIndex)}.";
        }
         // Calculates and Processes Peoples cash balances
        private static (StringBuilder peopleNames, float cash) CalculatePeoplesBalances(string[] peoplesBalances, string attribution)
        {
            var options = new string[]
            { "max", "min", "rich", "poor" };

            if (!options.Contains(attribution)) 
                
                return (new StringBuilder(), 0);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var peopleNames = new string[peoplesBalances.Length];
            var cashIndex = new float[peoplesBalances.Length];
          
            for (int i = 0; i < peoplesBalances.Length; i++)
            {
                var peopleInfo = peoplesBalances[i].Split(", ");
                var values = NumPyArrayConversion(peopleInfo[1..]);

                peopleNames[i] = peopleInfo[0];

                if (attribution == "max")
                {
                    cashIndex[i] = values.Max();
                }
                else if (attribution == "min")
                {
                    if (values.Length <= 1) continue;

                    var balance = new float[values.Length - 1];

                    for (int j = 0; j < values.Length - 1; j++)
                    {
                        if (j == values.Length - 1) continue;
                        balance[j] = values[j + 1] - values[j];
                    }
                    cashIndex[i] = balance.Min();
                }
                else if (attribution == "rich" || attribution == "poor")
                {
                    cashIndex[i] = values[^1];
                }
            }
            var maximumCash = (attribution == "max" || attribution == "rich");
            float cashCheck = (maximumCash) ? cashIndex.Max() : cashIndex.Min();
            var listBuilder = LookForPeopleCash(peopleNames, cashIndex, cashCheck);
            var listAllNames = ListNames(listBuilder.ToString());

            return (listAllNames, cashCheck);
        }

        // Validates if peoples names should contain comma' or and' between them
        private static bool PeoplePlus(StringBuilder names)
        {
            return (names.ToString().Contains(",") || names.ToString().Contains(" and "));
        }

        // Validates if peoples balances are null or empty.
        private static bool IsNullOrEmpty(string[] peoplesBalances)
        {
            return (peoplesBalances == null || peoplesBalances.Length == 0);
        }

        // // Converts string array to array of floats
        private static float[] NumPyArrayConversion(string[] numbers)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var nullString = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (string.IsNullOrEmpty(numbers[i])) nullString++;
            }

            var convertList = new float[numbers.Length - nullString];
            var new_i = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (string.IsNullOrEmpty(numbers[i]))
                    continue;

                if (float.TryParse(numbers[i], out float numeric))
                {
                    convertList[new_i] = numeric;
                    new_i++;
                }
            }
            return convertList;
        }

       // Lists out names separated by commas and "and" converting it to more readable string message to console
        private static StringBuilder ListNames(string nameLine)
        {
            var output = new StringBuilder();
            if (string.IsNullOrEmpty(nameLine))

                return output;

            var convert = nameLine.Split(", ");
           
            output.Append(convert[0]);

            if (convert.Length > 2)
            {
                for (int i = 1; i < convert.Length; i++)
                {
                    var andCom = (i == convert.Length - 1) ? " and" : ",";
                    output.Append($"{andCom} {convert[i]}");
                }
            }
            return output;
        }

        // Compares cash index of Peoples Cash bigger than one.
        private static StringBuilder LookForPeopleCash(string[] names, float[] cashIndex, float cashValidator)
        {
            var pax = new StringBuilder();
           
            for (int i = 0; i < cashIndex.Length; i++)
            {
                if (cashIndex[i] == cashValidator)
                {
                    pax.Append($"{names[i]}, ");
                }
            }
            pax.Length -= 2;

            return pax;
        }

        // Prints to console the Formatted currency to -¤9999 
        private static string FormatCash(float numeric)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var currencySeparator = (numeric < 0) ? "-" : "";
            var currencySign = NumberFormatInfo.CurrentInfo.CurrencySymbol;

            return $"{currencySeparator}{ currencySign}{Math.Abs(numeric)}";
        }
    }
}