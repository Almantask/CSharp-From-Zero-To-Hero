using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ICsvGenerator
    {
        void GenerateCsv(string outputPath);
    }
}
