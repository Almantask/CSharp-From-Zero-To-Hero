using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] myArray = new int[] { 4, 8, 0, 1, 9, 3, 7, 2, 88, 54, 11, 18, 100, 6 };
              int[] myArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9  };
            //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] testArray = new int[] { 0, 1 };
           // int[] nullArray = new int[] { };


            //ArrayOperations.Sort(myArray);
            ArrayOperations.Reverse(myArray);
            //ArrayOperations.RemoveLast(myArray);
            //ArrayOperations.RemoveFirst(myArray);
            //ArrayOperations.RemoveAt(myArray, 6);
            ////ArrayOperations.InsertFirst(nullArray, 3);
            //ArrayOperations.InsertFirst(testArray, 10);
            //ArrayOperations.InsertLast(testArray, 10001);
            //ArrayOperations.InsertAt(testArray, 1337, 1);
        }
    }
}
