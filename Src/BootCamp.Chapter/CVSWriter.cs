using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CVSWriter
    {
        public static void WriteCityData(string file, string headertext, string outcome)
        {
            File.WriteAllText(file, outcome); 

        }

        public static void WriteTimeData(string file, string headertext, List<OutputTime> outcome)
        {
            var encoding = new UTF8Encoding();
            File.WriteAllText(file,$"Hour, Count, Earned{Environment.NewLine}");
            CultureInfo dutch = new CultureInfo("nl-NL");
            dutch = (CultureInfo)dutch.Clone();
            dutch.NumberFormat.CurrencyPositivePattern = 3;
            dutch.NumberFormat.CurrencyNegativePattern = 3;

            foreach (var line in outcome)
            {

                File.AppendAllText(file, line.Hour.ToString("00"));
                File.AppendAllText(file, ", ");
                File.AppendAllText(file, line.Count.ToString());
                File.AppendAllText(file, ", ");
                File.AppendAllText(file, $"\"{line.Average.ToString("C",dutch)}\"", encoding);
                File.AppendAllText(file, Environment.NewLine);
            }

            var rushHour = outcome.OrderByDescending(x => x.Average).First().Hour;
            File.AppendAllText(file,$"Rush hour: {rushHour:00}{Environment.NewLine}");
        }
    }
}