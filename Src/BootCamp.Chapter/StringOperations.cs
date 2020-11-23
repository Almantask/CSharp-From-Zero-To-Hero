using System;

namespace BootCamp.Chapter
{
    public class StringOperations
    {
        public static string PluralizeIsByCount(int count)
        {
            return Pluralize("is", "are", count);
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