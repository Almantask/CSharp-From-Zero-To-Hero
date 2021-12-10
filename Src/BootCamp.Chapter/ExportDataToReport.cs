using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class ExportDataToReport
    {
        public static void PrintTimeReport(List<List<string>> outputFile, string outputPath, string fileName)
        {
            try
            {
                string filePath = outputPath;
                string dirPath = Path.GetDirectoryName(outputPath);
                if (!Directory.Exists(outputPath))
                    Directory.CreateDirectory(outputPath);

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                var enc1252 = Encoding.GetEncoding(1252); 

                using (StreamWriter sw = new StreamWriter(Path.Combine(outputPath, fileName)))
                {
                    int count = 0;
                    foreach (var data in outputFile)
                    {
                        List<string> lines = data;
                        CultureInfo invC = CultureInfo.InvariantCulture;
                        if (count < 1) sw.WriteLine("Hour, Count, Earned");
                        if (count >= 0 && count < 10) sw.WriteLine("0" + lines[0] + ", " + lines[1] + ", \"" + lines[2] + '€' + "\"", new UTF8Encoding(true)); //€ "\u20AC"
                        if (count >= 10 && count < 24) sw.WriteLine(lines[0] + ", " + lines[1] + ", \"" + lines[2] + " \u20AC" + "\"", Encoding.Default); //€ "\u20AC"
                        if (count == 24) sw.WriteLine(lines[0]);
                        count++;
                    }
                }

                Console.WriteLine("File has been written to hdd");
            }
            catch(Exception ex)
            {
                Console.WriteLine("**** ERRROR ****");
                Console.WriteLine(ex);
            }
        }

        public static void PrintMinMaxReport(string cityName, string outputPath, string fileName)
        {
            try
            {
                string filePath = outputPath;
                string dirPath = Path.GetDirectoryName(outputPath);
                if (!Directory.Exists(outputPath))
                    Directory.CreateDirectory(outputPath);

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                var enc1252 = Encoding.GetEncoding(1252);

                using (StreamWriter sw = new StreamWriter(Path.Combine(outputPath, fileName)))
                {
                    CultureInfo invC = CultureInfo.InvariantCulture;
                    sw.WriteLine(cityName);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("**** ERRROR ****");
                Console.WriteLine(ex);
            }
        }

        public static void PrintDailyReport(List<List<String>> data, string outputPath, string shopName, string fileName)
        {
            try
            {
                int count = 0;
                string filePath = outputPath;
                string dirPath = Path.GetDirectoryName(outputPath);
                if (!Directory.Exists(outputPath))
                    Directory.CreateDirectory(outputPath);

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                var enc1252 = Encoding.GetEncoding(1252);

                using (StreamWriter sw = new StreamWriter(Path.Combine(outputPath, fileName)))
                {
                    CultureInfo invC = CultureInfo.InvariantCulture;
                    
                    foreach(var day in data)
                    {
                        if (count < 1) sw.Write("Day, Earned" + Environment.NewLine);
                        sw.Write(day[0] + ", \"" + day[1] + " €\"" + Environment.NewLine);
                        if (count < 2) count++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("**** ERRROR ****");
                Console.WriteLine(ex);
            }
        }

    }
}
