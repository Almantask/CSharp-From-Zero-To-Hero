using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        { 
            //tests for in-progress code
            var array = new[] { 5, 4, 3, 2, 1, 7 };
            var array2 = new[] { 0, 1 };
            Sort(array);
            Reverse(array2);
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
            var array3 = InsertAt(array, 3, 2);
            var array4 = RemoveAt(array, 2);
            foreach (var number in array3)
            {
                Console.WriteLine(number);
            }

        }
        public static void Sort(int[] array)
        {
            if (array == null || array.Length == 0) return;

            for (var i = 0; i < array.Length; i++)
            {
                for (var nextIndex = i + 1; nextIndex < array.Length; nextIndex++)
                {
                    if (array[i] > array[nextIndex])
                    {
                        var tempNumber = array[i];
                        array[i] = array[nextIndex];
                        array[nextIndex] = tempNumber;
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0) return;

            var nextIndex = array.Length - 1;
            for (var i = 0; i < nextIndex; i++)
            {
                var tempNumber = array[i];
                array[i] = array[nextIndex];
                array[nextIndex] = tempNumber;
                nextIndex--;
            }
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0) return array;

            var array2 = new int[array.Length - 1];
            if (index > array2.Length || index < 0)
            {
                return array;
            }

            for (var i = 0; i < array2.Length; i++)
            {
                if (i < index)
                {
                    array2[i] = array[i];
                }
                else
                {
                    array2[i] = array[i + 1];
                }
            }
            return array2;
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (array == null)
            {
                int[] newArray = new int[] { number };
                return newArray;
            }
            else
            {
                var array2 = new int[array.Length + 1];
                if (index >= array2.Length || index < 0)
                {
                    return array;
                }

                for (var i = 0; i < array2.Length; i++)
                {
                    if (i < index)
                    {
                        array2[i] = array[i];
                    }
                    else if (i == index)
                    {
                        array2[i] = number;
                    }
                    else
                    {
                        array2[i] = array[i - 1];
                    }
                }
                return array2;
            }
        }
    }
}  

