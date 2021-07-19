using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 1};
            //int[] array = new int[] { 1 };

            /*ArrayOperations.Sort(array);
            ArrayOperations.Reverse(array);
            ArrayOperations.RemoveFirst(array);*/
            //ArrayOperations.RemoveLast(array);
            ArrayOperations.InsertFirst(null, 10);
        }
    }
}
