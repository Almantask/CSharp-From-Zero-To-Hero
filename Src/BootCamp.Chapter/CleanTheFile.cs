using System;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    static class CleanTheFile
    {
        public static void Clean(string file, string outputFile)
        {
            if (Testers.IsThisStringValid(file) || Testers.IsThisStringValid(outputFile))
            {
                throw new ArgumentException();
            }

            StringBuilder cleanFile = new StringBuilder();

            using (var fileS = new FileStream(file, FileMode.Open))
            {
                using (var reader = new StreamReader(fileS))
                {
                    foreach (char letter in reader.ReadToEnd())
                    {
                        if (letter == '_')
                        {

                        }
                        else
                        {
                            cleanFile.Append(letter);
                        }
                    }
                }
            }
            string[] splitCleanFile = cleanFile.ToString().Split(Environment.NewLine);

            foreach (string line in splitCleanFile)
            {
                string[] splitLine = line.Split(',');
                if (!Testers.IsThisAValidName(splitLine[0]) || !Testers.IsThisAValidBalance(line))
                {
                    throw new InvalidBalancesException();
                }
            }

            using (var fileS = new FileStream(outputFile, FileMode.Create))
            {
                using (var writer = new StreamWriter(fileS))
                {
                    writer.Write(cleanFile);
                }
            }
        }

    }
}
