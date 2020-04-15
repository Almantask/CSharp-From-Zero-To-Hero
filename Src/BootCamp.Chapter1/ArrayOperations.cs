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
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            Swap(array, i, j);
                        }
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
            else
            {
                for (int i = 0; i < (array.Length / 2); i++)
                {
                    Swap(array, i, array.Length - i - 1);
                }
            }
        }

        public static int[] RemoveLast(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return array;
            }
            else
            {
                return RemoveAt(array, array.Length - 1);
            }
        }

        public static int[] RemoveFirst(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return array;
            }
            else
            {
                return RemoveAt(array, 0);
            }
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (IsNullOrEmpty(array) || !CheckRange(array, index))
            {
                return array;
            }
            else
            {
                int[] removeElement = new int[array.Length - 1];
                for(int i = 0; i < removeElement.Length; i++)
                {
                    if (i < index)
                    {
                        removeElement[i] = array[i];
                    }
                    else
                    {
                        removeElement[i] = array[i + 1];
                    }
                }
                return removeElement;
            }
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            if (IsNullOrEmpty(array))
            {
                return new[] { number };
            }
            else return InsertAt(array, number, 0);
        }

        public static int[] InsertLast(int[] array, int number)
        {
            if (IsNullOrEmpty(array))
            {
                return new[] { number };
            }
            else return InsertAt(array, number, array.Length);
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (CheckForInsert(array, index, false))
            {
                return new int[] { number };
            }
            else if (!CheckForInsert(array, index, true))
            {
                return array;
            }
            else
            {
                int[] addElement = new int[array.Length + 1];
                for (int i = 0; i < addElement.Length; i++)
                {
                    if (i > index)
                    {
                        addElement[i] = array[i-1];
                    }
                    else if (i == index)
                    {
                        addElement[i] = number;
                    }
                    else
                    {
                        addElement[i] = array[i];
                    }
                }
                return addElement;
            }
        }
        private static bool IsNullOrEmpty(int[] array)
        {
            return array == null || array.Length == 0;
        }
        private static void Swap(int[] array, int index1, int index2)
        {
            int tempArray = array[index1];
            array[index1] = array[index2];
            array[index2] = tempArray;
        }
        private static bool CheckRange (int[] array, int index)
        {
            return ((index >= 0 && index < array.Length) || (array.Length == 0 && index == 0));
        }
        private static bool CheckForInsert(int[] array, int index, bool IsOkay)
        {
            if (array == null)
            {
                return true;
            }
            else if (array.Length == 0 && CheckRange(array, index))
            {
                return true;
            }
            else if (array.Length == 0 && !CheckRange(array, index))
            {
                return false;
            }
            return IsOkay;
        }
    }
}
