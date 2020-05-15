using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FileCleaner
    {
        private readonly string corruptedPath = @"..\..\..\Input\Balances.corrupted";
        private readonly string cleanedPath = @"..\..\..\Input\Balances.cleaned";
        
        public void CleaningCorruptedFile()
        {
            using(var reader = File.OpenText(corruptedPath))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    using (var writer = File.AppendText(cleanedPath))
                    {
                        var cleanedLine = RemovingInvalidChar(line);
                        writer.WriteLine(cleanedLine);
                    }
                    
                    line = reader.ReadLine();
                }
            }
        }

        private string RemovingInvalidChar(string line)
        {
            var lenght = line.Length;
            var newString = "";

            for(int i = 0; i < lenght; i++)
            {
                if(line[i] != '_')
                {
                    newString += line[i];
                }
            }

            return newString;
        }
        
    }
}
