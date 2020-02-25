using System.Globalization;
using System;

namespace BootCamp.Chapter
{
    public static class Settings
    {
        // BalanceStats settings
        public static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };

        public static readonly char stringSplitDivider = ',';
        public static readonly string validNameChars = "'-";

        // ¤ currency sign
        public static readonly string currencySymbol = "\u00A4";

        // FileCleaner settings
        public static readonly CultureInfo cultureInfo = new CultureInfo("en-GB");

        public static readonly string corruptionChar = "_";
        public static readonly string emptyChar = "";

        // TextTable settings
        public static readonly char cornerChar = '+';

        public static readonly char horizontalBorderChar = '-';
        public static readonly char verticalBorderChar = '|';
        public static readonly char emptySpace = ' ';
        public static readonly string messageDivider = Environment.NewLine;
    }
}