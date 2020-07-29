using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ICsvGenerator
    {
        void GenerateCsvCity();
        void GenerateCsvTime();
        void GenerateCsvFull();
        void GenerateCsvDaily();
    }
}
