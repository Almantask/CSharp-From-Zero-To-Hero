using System;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var index = 0;
            var number = 7;
            var array = new int[] {10, 0, 1};
            if (array == null || array.Length == 0)
            {
                if (array != null && array.Length == 0 && index != 0)
                {
                    Console.WriteLine(array);
                }

                int[] newArray = new[] {number};
                foreach (var i in newArray)
                {
                    Console.WriteLine(newArray[i]);
                }

                foreach (var j in newArray )
                {
                    Console.WriteLine(newArray[j]);
                }

                
            }

            var tempArray = new int[array.Length + 1] ;
            
                     
            for (var i = 0; i < tempArray.Length; i++)
            {
                if (i < index)
                    tempArray[i] = array[i];
                else if (i == index)
                    tempArray[i] = number;
                else
                    tempArray[i] = array[i - 1];
            }

            foreach (var h in tempArray)
            {
                Console.WriteLine(tempArray[h]);
            }*/
            

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
            return RemoveAt(array,array.Length - 1);

        }

        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0) return array;
            return RemoveAt(array,0);
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length <= 0 || index == -1 || array.Length <= index) return array;
            
            var tempArray = array.Length - 1;
            var arrayIndex = new int[tempArray];

            for (var i = 0; i < tempArray; i++)
            {
                if (i < array.Length)
                    arrayIndex[i] = array[i];
                if (i >= index)
                    arrayIndex[i] = array[i + 1];

            }
            return arrayIndex;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null)
            {
                int[] newArray = new[] {number};
                return newArray;
            }
            int[] tempArray = InsertAt(array, number, 0);
            return tempArray;
        }

        public static int[] InsertLast(int[] array, int number)
        {
            int arrayLength = 0;
            if (array != null && array.Length != 0)
            {
                arrayLength = array.Length;
            }

            int[] resultArray = InsertAt(array, number, arrayLength);
            return resultArray;
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {

            if (array == null || array.Length == 0)
            {
                if (array != null && array.Length == 0 && index != 0)
                {
                    return array;
                }

                int[] newArray = new[] {number};
                return newArray;
            }
      
            var tempArray = new int[array.Length + 1] ;
            
                     
            for (var i = 0; i < tempArray.Length; i++)
            {
                if (i < index)
                    tempArray[i] = array[i];
                else if (i == index)
                    tempArray[i] = number;
                else
                    tempArray[i] = array[i - 1];
            }
            
            return tempArray;
        }
    }
}
