using System;
using System.Globalization;
namespace BootCamp.Chapter
{
    public class StringOperations
    {
        public static string FormatHighestBalanceMessage(string[] names, decimal amount)
        {
            return FormatGlobalizedMessage(
                $"{ArrayOperations.FormatToString(names)} had the most money ever.",
                amount
                );
        }

        public static string FormatBiggestLossMessage(string[] names, decimal amount)
        {
            return FormatGlobalizedMessage(
                $"{ArrayOperations.FormatToString(names)} lost the most money.",
                amount
                );
        }

        public static string FormatRichestPersonMessage(string[] names, decimal amount)
        {

            return FormatGlobalizedMessage(
                $"{ArrayOperations.FormatToString(names)} {PluralizeIsByCount(names.Length)} the richest " +
                $"{PluralizePersonByCount(names.Length)}.",
                amount
            );
        }
        
        public static string FormatPoorestPersonMessage(string[] names, decimal amount)
        {
            return FormatGlobalizedMessage(
                $"{ArrayOperations.FormatToString(names)} {PluralizeHasByCount(names.Length)} the least money.",
                amount
            );
        }

        public static string FormatGlobalizedMessage(string message, decimal amount)
        {
            var cultureInfo = new CultureInfo("");
            cultureInfo.NumberFormat.CurrencyGroupSeparator = "";
            cultureInfo.NumberFormat.CurrencyNegativePattern = 1;
            return $"{message} {amount.ToString("C0", cultureInfo)}.";
        }

    public static string PluralizeIsByCount(int count)
        {
            return Pluralize("is", "are", count);
        }
        
        public static string PluralizeHasByCount(int count)
        {
            return Pluralize("has", "have", count);
        }
        
        public static string PluralizePersonByCount(int count)
        {
            return Pluralize("person", "people", count);
        }

        private static string Pluralize(string singular, string plural, int count)
        {
            return count == 1 ? singular : plural;
        }
    }
}