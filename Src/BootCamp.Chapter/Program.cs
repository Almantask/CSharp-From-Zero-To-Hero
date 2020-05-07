using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = ParseFile.Parse();
            var foundZipCodes = Statics.FindPostOfficeWithMostErrors(data);
            Console.WriteLine(foundZipCodes);
        }
    }
}
