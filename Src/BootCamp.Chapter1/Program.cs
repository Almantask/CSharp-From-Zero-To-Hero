using System;
using System.Collections.Immutable;
using System.Runtime.ExceptionServices;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] Sort(int[] array)
        {
            if (array == null || array.Length < 1) return array;

            Array.Sort(array);
            return array;
        }
        public static int[] Reverse(int[] array)
        {
            if (array == null || array.Length < 1) return array;

            Array.Reverse(array);
            return array;
        }
        public static int[] removeLast(int[] array)
        {
            if (array == null || array.Length < 1) return array;

            int[] array2 = new int[array.Length - 1];
            for (int i = 0; i < array2.Length; i++)
            {
               array2[i] = array[i];
            }
            return array2;
        }
        public static int[] removeFirst(int[] array)
        {
            if (array == null || array.Length < 1) return array;

            int[] array2 = new int[array.Length - 1];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i++];
            }
            return array2;
        }
    }
}

