using System;
using BootCamp.Chapter.Logger;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BmiCalculator.Logger.Warn("Program started.");
            BmiCalculator.CalculateBmi();
            BmiCalculator.Logger.Warn("Program finished.");
        }
    }
}
