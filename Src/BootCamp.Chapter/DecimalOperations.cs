using System;

namespace BootCamp.Chapter
{
    public class DecimalOperations
    {
        public static bool IsAEquivalentToB(decimal a, decimal b)
        {
            return decimal.Compare(a, b) == 0;
        }
    }
}