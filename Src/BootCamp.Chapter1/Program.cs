using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 5, 4 };

            /*ArrayOperations.Sort(array);
            ArrayOperations.Reverse(array);
            ArrayOperations.RemoveFirst(array);*/
            ArrayOperations.RemoveLast(array);
        }
    }
}
