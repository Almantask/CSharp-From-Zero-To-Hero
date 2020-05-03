using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public static class CVSWriter
    {
        public static void WriteCityData(string file, string headertext, string outcome)
        {
            File.WriteAllText(file, outcome); 

        }
    }
}