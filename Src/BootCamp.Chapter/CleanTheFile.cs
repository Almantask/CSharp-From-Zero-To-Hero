using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BootCamp.Chapter
{
    class CleanTheFile
    {
        //TODO add exeptions for invalid balances exeption. name not right and wrong char in places.
        public void Clean(string file, string outputFile)
        {
            if (!IsThisStringValid(file) || !IsThisStringValid(outputFile))
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
            using (var fileS = new FileStream(outputFile, FileMode.Create))
            {
                using(var writer = new StreamWriter(fileS))
                {
                    writer.Write(cleanFile);
                }
            }
        }
        public bool IsThisStringValid(string file)
        {
            if (String.IsNullOrEmpty(file) || String.IsNullOrWhiteSpace(file))
            {
                return false;
            }
            
            return true;
        }
    }
}
