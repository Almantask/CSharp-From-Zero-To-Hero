using System;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            var newValue  = 5;
            var index = 3;
            
            
            var array = new int[] { 1, 2, 3, 4, 5 };
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" the index {i} of Array has as value {array[i]}");
            }
            var newArray = new int[array.Length+1];
            if (array.Length < newArray.Length)
            {
                Console.WriteLine("newArray es mas grande");
            }
            for(var i = 0; i < array.Length + 1; i++)
            {
                if (i < index - 1)
                    newArray[i] = array[i];
                else if (i == index - 1)
                    newArray[i] = newValue;
                else
                    newArray[i] = array[i - 1];
            }
            foreach(var i in newArray)
            {
                Console.WriteLine($"newArray is {i} ");
            }
            


        }

        public static void Sort(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int result = 0;
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        result = array[i];
                        array[i] = array[j];
                        array[j] = result;
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0) return;
            Array.Reverse(array);
            for (var i = 0; i < array.Length / 2; i++)
            {
                var temp = array[i];
            }
        }

        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0) return array;

            return array;

        }

        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0) return array;

            return array;
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0) return array;
            return array;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null || array.Length == 0) return array;
            return array;
        }

        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0) return array;
            return array;
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (array == null || array.Length == 0) return array;
            for(var i = 0; i < array.Length; i++)
            { 
                
            }

            return array;
        }
    }
}
