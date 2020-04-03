using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace UtilsLibrary
{
    public static class Utils
    {
        public static bool IsValid(string input)
        {
            return !string.IsNullOrWhiteSpace(input) || !string.IsNullOrEmpty(input);
        }

        public static bool IsValid(char input)
        {
            return char.IsLetterOrDigit(input);
        }

        // methodnot properly implemented
    }
}