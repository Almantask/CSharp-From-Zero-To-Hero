using System;
using System.IO;

namespace BootCamp.Chapter
{
    class CleanTheFile
    {
        public void Clean(string file, string outputFile)
        {
            if (Testers.IsThisStringValid(file) || Testers.IsThisStringValid(outputFile))
            {
                throw new ArgumentException();
            }

            string cleanFile = "";

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
                            cleanFile += letter;
                        }
                    }
                }
            }
            string[] splitCleanFile = cleanFile.Split(Environment.NewLine);

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
