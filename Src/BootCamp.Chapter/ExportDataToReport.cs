using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class ExportDataToReport
    {
        public static void printReport(List<List<string>> outputFile, string outputPath, string fileName)
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
            }
            catch(Exception ex)
            {
                Console.WriteLine("**** ERRROR ****");
                Console.WriteLine(ex);
            }
        }

    }
}
