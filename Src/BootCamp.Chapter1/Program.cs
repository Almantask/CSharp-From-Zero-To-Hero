using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[] { 1, 1, 1 };
            Array.ForEach(ArrayOperations.RemoveAt(testArr, 4), Console.WriteLine);
        }
    }
}
