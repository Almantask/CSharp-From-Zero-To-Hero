using System;

namespace BootCamp.Chapter.Examples
{
    class OutOfRange_ZeroIndexed_WhileTrue
    {
        public static void ll()
        {
            int[] array = new int[100];

            Print1(array);
            Print2(array);
            Print3(array);
        }

        public static void Print1(int[] array)
        {
            for (int i = 1; i <= array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Print2(int[] array)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Print3(int[] array)
        {
            int i = array.Length;
            int subtraction = 100000;

            while (true)
            {
                subtraction -= array[i];
                --i;
            }
        }
    }
}