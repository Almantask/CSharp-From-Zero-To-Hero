using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[2] { 0, 1 };
            Array.ForEach(ArrayOperations.RemoveAt(testArr, 2), Console.WriteLine);
        }
    }
}
