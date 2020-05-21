using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new[] {1, 2, 3, 4, 5};
            testArray = ArrayOperations.InsertAt(testArray, 10, 3);

            foreach (var i in testArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
