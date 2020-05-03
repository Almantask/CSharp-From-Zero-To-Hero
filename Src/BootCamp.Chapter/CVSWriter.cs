using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter
{
    public class CVSWriter
    {
        string file = @"Output\time.csv"; 

        public void Write(string text) => File.WriteAllText(file, text);

       
    }
}