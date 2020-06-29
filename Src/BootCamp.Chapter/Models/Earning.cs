using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace BootCamp.Chapter.Models
{
    [XmlRoot("Earning")]
    public class Earning
    {
        [XmlElement("Day")]
        public string Day { get; set; }

        [XmlElement("Earned")]
        public string Earned { get; set; }

        public static Earning ConvertFromDecimal(EarnedDayDecimal input)
        {
            return new Earning() { Day =  input.Day , Earned = ConvertDecimalToStringCurrency(input.Earned) };
        }

        private static string ConvertDecimalToStringCurrency(decimal earned)
        {
            return earned.ToString("C2", CultureInfo.GetCultureInfo("lt-LT"));
        }
    }
}
