using System;

namespace BootCamp.Chapter1
{
    class Program
    {

        static void Main(string[] args)
        {
            var array = new[] { 3, 2, 1, 4, 5 };

            Console.WriteLine("Before sort: ");
            PrintArray(array);
            Array.Sort(array);
            Console.WriteLine("\nAfter sort: ");
            PrintArray(array);
            array = ReverseArray(array);
            Console.WriteLine("\nAfter reverse: ");
            PrintArray(array);
            var arrayWithoutFirst = RemoveFirst(array);
            Console.WriteLine("\nAfter RemoveFirst: ");
            PrintArray(arrayWithoutFirst);
            var arrayWithoutLast = RemoveLast(array);
            Console.WriteLine("\nAfter RemoveFirst: ");
            PrintArray(arrayWithoutLast);
            var arrayWithoutNdx = RemoveOnIndex(array, 4);
            Console.WriteLine("\nAfter RemoveOnIndex: ");
            PrintArray(arrayWithoutNdx);

        }


        static void PrintArray(int[] ints)
        {
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
        }

        static int[] ReverseArray(int[] ints)
        {
            var reversedArray = new int[ints.Length];
            for(int i = 0; i < ints.Length; i++)
            {
                reversedArray[reversedArray.Length-1-i] = ints[i];
            }
            return reversedArray;
        }
        static int[] RemoveFirst(int[] ints)
        {
            var newArray = new int[ints.Length-1];

            for(int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = ints[i+1];
            }
            return newArray;
        }
        static int[] RemoveLast(int[] ints)
        {
            var newArray = new int[ints.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = ints[i];
            }
            return newArray;
        }

        static int[] RemoveOnIndex(int[] ints, int index)
        {
            var newArray = new int[ints.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = ints[i];
            }
            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = ints[i+1];
            }
            return newArray;
        }
    }
}
