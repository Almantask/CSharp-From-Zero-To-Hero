using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testArr = null;
            //int[] testArr = new int[0];
            int[] testArr = new int[5] {1, 2, 3, 4, 5};

            //ArrayOperations.Sort(testArr);
            ArrayOperations.Reverse(testArr);
            Array.ForEach(testArr, Console.WriteLine);
        }
    }
}
