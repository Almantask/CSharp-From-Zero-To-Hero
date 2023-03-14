using System;

namespace BootCamp.Chapter1
{
    class Program
    {

        static void Main(string[] args)
        {
            //int[] array = new int[0];
            var array = new[] {0,1};

            Console.WriteLine("Before sort: ");
            PrintArray(array);
            var arraySorted = SortArray(array);
            Console.WriteLine("After sort: ");
            PrintArray(arraySorted);
            var arrayReversed = ReverseArray(array);
            Console.WriteLine("After reverse: ");
            PrintArray(arrayReversed);
            var arrayWithoutFirst = RemoveFirst(array);
            Console.WriteLine("After RemoveFirst: ");
            PrintArray(arrayWithoutFirst);
            var arrayWithoutLast = RemoveLast(array);
            Console.WriteLine("After RemoveLast: ");
            PrintArray(arrayWithoutLast);
            var arrayWithoutNdx = RemoveAtIndex(array, 4);
            Console.WriteLine("After RemoveOnIndex: ");
            PrintArray(arrayWithoutNdx);
            var arrayInsertAtStart = InsertAtStart(array, 0);
            Console.WriteLine("After InsertAtStart: ");
            PrintArray(arrayInsertAtStart);
            var arrayInsertAtEnd = InsertAtLast(array, 0);
            Console.WriteLine("After InsertAtEnd: ");
            PrintArray(arrayInsertAtEnd);
            var arrayInsertAtIndex = InsertAtIndex(array, 1, 0);
            Console.WriteLine("After InsertAtIndex: ");
            PrintArray(arrayInsertAtIndex);

        }


        static void PrintArray(int[] ints)
        {
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        public static int[] SortArray(int[] ints)
        {
            if (ints == null || ints.Length == 0)
            {
                return ints;
            }

            int[] sortedArray = (int[])ints.Clone();
            int length = sortedArray.Length;
            int temp = 0;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (sortedArray[i] > sortedArray[j])
                    {
                        temp = sortedArray[i];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = temp;
                    }
                }
            }
            return sortedArray;
        }

        public static int[] ReverseArray(int[] ints)
        {
            if (ints == null || ints.Length == 0)
            {
                return ints;
            }

            var reversedArray = new int[ints.Length];
            for(int i = 0; i < ints.Length; i++)
            {
                reversedArray[reversedArray.Length-1-i] = ints[i];
            }
            return reversedArray;
        }
        public static int[] RemoveFirst(int[] ints)
        {
            if (ints == null || ints.Length == 0)
            {
                return ints;
            }

            var newArray = new int[ints.Length-1];

            for(int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = ints[i+1];
            }
            return newArray;
        }
        public static int[] RemoveLast(int[] ints)
        {
            if (ints == null || ints.Length == 0)
            {
                return ints;
            }

            var newArray = new int[ints.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = ints[i];
            }
            return newArray;
        }
        public static int[] RemoveAtIndex(int[] ints, int index)
        {
            if (ints == null || ints.Length == 0)
            {
                return ints;
            }

            if (index < 0 || index > ints.Length -1)
            {
                Console.WriteLine("index out of range");
                return ints;
            }
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
        public static int[] InsertAtStart(int[] ints, int insertion)
        {
            int[] newArray;

            if (ints == null)
            {
                newArray = new int[1];
                newArray[0] = insertion;
                return newArray;
            }

            newArray = new int[ints.Length + 1];

            newArray[0] = insertion;

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = ints[i-1];
            }
            return newArray;
        }
        public static int[] InsertAtLast(int[] ints, int number)
        {
            int[] newArray;

            if (ints == null)
            {
                newArray = new int[1];
                newArray[0] = number;
                return newArray;
            }

            newArray = new int[ints.Length + 1];

            for (int i = 0; i < newArray.Length - 1; i++)
            {
                newArray[i] = ints[i];
            }

            newArray[newArray.Length - 1] = number;
            return newArray;
        }
        public static int[] InsertAtIndex(int[] ints, int index, int number)
        {
            int[] newArray;

            if (ints == null || ints.Length == 0)
            {
                newArray = new int[1];
                if (index < 0 || index > newArray.Length - 1)
                {
                    Console.WriteLine("index out of range");
                    return ints;
                }
                newArray[0] = number;
                return newArray;
            }

            if (index < 0 || index > ints.Length - 1)
            {
                Console.WriteLine("index out of range");
                return ints;
            }

            if (ints == null || ints.Length == 0)
            {
                newArray = new int[1];
                newArray[0] = number;
                return newArray;
            }

            newArray = new int[ints.Length + 1];



            for (int i = 0; i < index; i++)
            {
                newArray[i] = ints[i];
            }
            
            newArray[index] = number;

            for (int i = index + 1; i < newArray.Length; i++)
            {
                newArray[i] = ints[i - 1];
            }
            return newArray;
        }

    }
}
