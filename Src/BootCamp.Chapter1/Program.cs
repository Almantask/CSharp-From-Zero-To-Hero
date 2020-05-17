using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, 3, 6, 9, 4, 2 };
            OutputArr(arr);

            ArrayOperations.Sort(arr);
            OutputArr(arr);

            ArrayOperations.Reverse(arr);
            OutputArr(arr);

            OutputArr(ArrayOperations.RemoveLast(arr));

            OutputArr(ArrayOperations.RemoveFirst(arr));

            OutputArr(ArrayOperations.RemoveAt(arr, 3));

            OutputArr(ArrayOperations.InsertFirst(arr, 3));

            OutputArr(ArrayOperations.InsertLast(arr, 7));

            OutputArr(ArrayOperations.InsertAt(arr, 9, 3));
        }

        static void OutputArr(int[] arr)
        {
            Console.Write("[ ");
            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.Write("]\n");
        }


    }
}