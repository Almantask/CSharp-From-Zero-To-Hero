using System;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        public static void Sort(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return;
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int x = i; x > 0; x--)
                {
                    if (array[x] < array[x - 1])
                    {
                        int temp = array[x];
                        array[x] = array[x - 1];
                        array[x - 1] = temp;
                    } 
                    else {
                        break;
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return;
            }

            for (int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length -1 - i] = temp;
            }

        }

        public static int[] RemoveLast(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i];
            }
            
            return newArray;
        }

        public static int[] RemoveFirst(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }

            return newArray;
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (IsNullOrEmpty(array))
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < array.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
            }

            return newArray;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            int[] newArray = new int[array.Length + 1];

            if (IsNullOrEmpty(array))
            {
                newArray[0] = number;
                return newArray;
            }

            newArray[0] = number;

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }

            return newArray;
        }

        public static int[] InsertLast(int[] array, int number)
        {
            int[] newArray = new int[array.Length + 1];

            if (IsNullOrEmpty(array))
            {
                newArray[0] = number;
                return newArray;
            }

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = number;

            return newArray;
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            int[] newArray = new int[array.Length + 1];

            if (IsNullOrEmpty(array))
            {
                newArray[0] = number;
                return newArray;
            }

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            newArray[index] = number;

            for (int i = index + 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }

            return newArray;
        }

        internal static bool Sort()
        {
            throw new NotImplementedException();
        }

        private static bool IsNullOrEmpty(int[] array)
        {
            if (array.Length == 0 || array == null)
            {
                return true;
            }

            return false;
        }
    }
}
