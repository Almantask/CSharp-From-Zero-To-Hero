using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileCleaner
    {
        private const string _corruptionChar = "_";
        private const string _emptyChar = "";
        private readonly string _dirtyFile;
        private readonly string _cleanedFile;

        public FileCleaner(string dirtyFile, string cleanedFile)
        {
            _dirtyFile = dirtyFile;
            _cleanedFile = cleanedFile;
        }

        public void Clean()
        {
            if (Test.IsStringValid(_dirtyFile) || Test.IsStringValid(_cleanedFile))
            {
                throw new ArgumentException();
            }

            using StreamReader reader = new StreamReader(_dirtyFile);
            using StreamWriter writer = new StreamWriter(_cleanedFile);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
#if DEBUG
                Console.WriteLine(line);
#endif
                writer.WriteLine(line.Replace(_corruptionChar, _emptyChar));
            }
            // not sure if this is necessary inside a try catch block
            reader.Dispose();
        }
    }
}