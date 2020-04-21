using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Culture
    {
        public static CultureInfo Input { get; }

        public static CultureInfo Output { get; }

        static Culture()
        {
            Input = new CultureInfo("es-ES");
            Input.NumberFormat.CurrencyPositivePattern = 0;
            Input.NumberFormat.CurrencyNegativePattern = 2;
            Input.NumberFormat.CurrencyDecimalDigits = 2;
            Input.NumberFormat.CurrencyDecimalSeparator = ",";
            Input.NumberFormat.CurrencySymbol = "€";
            Input.DateTimeFormat.DateSeparator = "-";
            Input.DateTimeFormat.TimeSeparator = ":";
            Input.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            Input.DateTimeFormat.ShortTimePattern = "hh:mm:ss";
            Input.DateTimeFormat.FullDateTimePattern = "yyyy-MM-ddTHH:mm:ssZ";

            Output = new CultureInfo("de-DE");
            Output.NumberFormat.CurrencyPositivePattern = 3;
            Output.NumberFormat.CurrencyNegativePattern = 8;
            Output.NumberFormat.CurrencyDecimalDigits = 2;
            Output.NumberFormat.CurrencyDecimalSeparator = ",";
            Output.NumberFormat.CurrencySymbol = "€";
            Output.DateTimeFormat.DateSeparator = "-";
            Output.DateTimeFormat.TimeSeparator = ":";
            Output.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            Output.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            Output.DateTimeFormat.FullDateTimePattern = "yyyy-MM-ddTHH:mm:ssZ";
        }
    }
}