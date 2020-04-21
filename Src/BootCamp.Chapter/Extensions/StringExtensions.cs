using System;

namespace BootCamp.Chapter
{
    public static class StringExtensions
    {
        public static bool IsValid(this string input)
        {
            return !string.IsNullOrWhiteSpace(input) || !string.IsNullOrEmpty(input);
        }

        public static string ToCamelCase(this string input)
        {
            if (!input.IsValid())
            {
                throw new ArgumentException("input cannot be null or empty");
            }

            var charArray = input.ToCharArray();
            charArray[0] = char.ToLowerInvariant(charArray[0]);

            return new string(charArray);
        }

        public static string AddQuotes(this string input)
        {
            if (!input.IsValid())
            {
                throw new ArgumentException("input cannot be null or empty");
            }

            return $@"""{input}""";
        }
    }
}