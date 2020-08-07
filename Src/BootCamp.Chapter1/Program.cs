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
            if (array == null || array.Length < 1) return array;//Null check

            Array.Sort(array);
            return array;
        }

        public static int[] Reverse(int[] array)
        {
            if (array == null || array.Length < 1) return array;//Null check

            Array.Reverse(array);//Reversion itself
            return array;
        }

        public static int[] removeLast(int[] array)
        {
            if (array == null || array.Length < 1) return array;//Null check

            int[] array2 = new int[array.Length - 1];//Assignation of a new array

            //Assignation of values from array to an array2, but the last value doesn't fit
            for (int i = 0; i < array2.Length; i++)
            {
               array2[i] = array[i];
            }
            return array2;
        }

        public static int[] removeFirst(int[] array)
        {
            if (array == null || array.Length < 1) return array;//Null check

            int[] array2 = new int[array.Length - 1];//Assignation of a new array

            //Assignation of values from array to an array2, but skipping the first
            for (int i = 1; i < array.Length; i++)
            {
                array2[i-1] = array[i];
            }

            return array2;
        }

        public static int[] removeAt(int[] array, int index)
        {
            if (array == null || array.Length < 1) return array;//Null check

            int[] array2 = new int[array.Length - 1];//Assignation of a new array

            if (index >= array.Length || index < 0) return array;//index check

            //Assignation of values from array to an array2, but skipping the index
            for (int i = 0; i < array2.Length; i++)
            {
                if (i < index) array2[i] = array[i];

                if (i >= index) array2[i] = array[i + 1];
            }
            return array2;
        }
        public static int[] insertFirst(int[] array, int number)
        {
            if (array == null) array = new int[0];//Null check
            int[] array2 = new int[array.Length + 1]; //Assignation of a new array

            for (int i = 1; i < array2.Length; i++) //This is the rest of the array, as it was
            {
               array2[i] = array[i - 1];
            }

            array2[0] = number; //Insertion itself

            return array2; //Gotta return them arrays
        }
        public static int[] insertLast(int[] array, int number)
        {
            if (array == null) array = new int[0];//Null check

            int[] array2 = new int[array.Length + 1];//Assignation of a new array

            //Assignation of values from array to an array2, but last
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[array.Length] = number;
            return array2;
        }
        public static int[] insertAt(int[] array, int number, int index)
        {
            if (array == null) array = new int[0];//Null check

            int[] array2 = new int[array.Length + 1];//Assignation of a new array

            if (index > array.Length || index < 0) return array;//index check

            //Assignation of values from array to an array2
            for (int i = 0; i < array.Length; i++)
            {
                if (i < index) array2[i] = array[i];
                if (i > index) array2[i] = array[i + 1];
            }

            array2[index] = number;//Insertion of a number

            return array2;
        }
    }
}

