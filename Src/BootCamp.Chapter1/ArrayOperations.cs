using System.ComponentModel.DataAnnotations;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {

        public static void Sort(int[] array)
        {
            if (array == null || array.Length == 0) return;

            for (var i = 0; i < array.Length; i++)
            {

                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var BiggerNumber = array[i];
                        array[i] = array[j];
                        array[j] = BiggerNumber;
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0) return;
            var indexMirror = array.Length - 1;
            for (var i = 0; i < (array.Length / 2); i++)
            {
                var mirrorNumber = array[indexMirror];
                array[indexMirror] = array[i];
                array[i] = mirrorNumber;
                indexMirror--;
            }
        }

        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0) return array;
            var newLength = array.Length - 1;
            var arrayRemovedLastIndex = new int[newLength];
            for (var i = 0; i < newLength; i++)
            {
                arrayRemovedLastIndex[i] = array[i];
            }
            return arrayRemovedLastIndex;
        }

        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0) return array;
            var newLength = array.Length - 1;
            var arrayRemovedFirstIndex = new int[newLength];
            for (var i = 0; i < newLength; i++)
            {
                arrayRemovedFirstIndex[i] = array[i + 1];
            }
            return arrayRemovedFirstIndex;
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0) return array;
            int newLength = array.Length - 1;
            var arrayRemovedAtIndex = new int[newLength];
            for (int i = 0; i < newLength; i++)
            {
                if (index < 0 || index > (array.Length - 1)) return array;
                if (i < index) arrayRemovedAtIndex[i] = array[i];
                if (i >= index) arrayRemovedAtIndex[i] = array[i + 1];
            }
            return arrayRemovedAtIndex;

        }

        public static int[] InsertFirst(int[] array, int number)
        {
            var arrayNullOrZero = new int[1] { number };
            if (array == null || array.Length == 0) return arrayNullOrZero;
            var newLength = array.Length + 1;
            var arrayInsertedFirstIndex = new int[newLength];
            arrayInsertedFirstIndex[0] = number;
            for (var i = 1; i < newLength; i++)
            {
                arrayInsertedFirstIndex[i] = array[i - 1];
            }
            return arrayInsertedFirstIndex;
        }

        public static int[] InsertLast(int[] array, int number)
        {
            var arrayNullOrZero = new int[1] { number };
            if (array == null || array.Length == 0) return arrayNullOrZero;
            var newLength = array.Length + 1;
            var arrayInsertedLastIndex = new int[newLength];
            arrayInsertedLastIndex[newLength - 1] = number;
            for (var i = 0; i < (newLength - 1); i++)
            {
                arrayInsertedLastIndex[i] = array[i];
            }
            return arrayInsertedLastIndex;
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            var arrayNull = new int[1] { number };
            if (array == null) return arrayNull;
            if (array.Length == 0 && index != 0) return array;
            if (array.Length == 0 && index == 0) return arrayNull;
            var newLength = array.Length + 1;
            var arrayInsertedAtIndex = new int[newLength];
            arrayInsertedAtIndex[index] = number;
            for (var i = 0; i < (newLength - 1); i++)
            {
                if (i < index) arrayInsertedAtIndex[i] = array[i];
                if (i > index) arrayInsertedAtIndex[i] = array[i - 1];
            }
            return arrayInsertedAtIndex;
        }
    }
}
