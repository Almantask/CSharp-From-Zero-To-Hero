using System;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        public static void Sort(int[] array)
        {
            if (IsNullArray(array))
                return;
            
            int temp;

            for (int i = 0; i < array.Length; i++)                  //For each index of the array...
            {
                for (int j = i + 1; j < array.Length; j++)  
                {
                    if (array[j] < array[i])                        //Check if each following index is smaller.
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;                            //Swap if so.
                    }
                }
            }
            
            return;
        }

        public static void Reverse(int[] array)
        {
            if (IsNullArray(array))
                return;
            
            int temp;
            
            for (int i = 0; i < array.Length / 2; i++)              // only need to iterrate through half of the array to reverse.
            {
                temp = array[i];                                    // Set temp to equal first element
                array[i] = array[(array.Length - 1) - i];           // set first element to equal last element
                array[(array.Length - 1) - i] = temp;               // set last element to equal temp, or first element
            }                                                       // increment i, meaning next loop will swap second and second-last elements etc.
            WriteArray(array);
        }

        public static int[] RemoveLast(int[] array)
        {
            if (array == null)
                return null;

            array = RemoveAt(array, array.Length - 1);

            return array;
        }

        public static int[] RemoveFirst(int[] array)
        {
            array = RemoveAt(array, 0);

            return array;
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (IsNullArray(array) || index < 0 || index > array.Length - 1)
                return array;

            var removeArray = new int[array.Length - 1];                        // Create new array 1 element smaller than original

            for (var i = 0; i < array.Length - 1; i++)
            {
                if (i == index)
                    break;
                removeArray[i] = array[i];                                      // Add elements to the new array until we reach index to be removed.
            }
            for (var i = index; i < array.Length - 1; i++)
            {
                removeArray[i] = array[i + 1];                                  // Keep adding elements, skipping the specified index.
            }

            return removeArray;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            array = InsertAt(array, number, 0);

            return array;
        }

        public static int[] InsertLast(int[] array, int number)
        {
            if (IsNullArray(array))             
                return new[] { number };

            array = InsertAt(array, number, array.Length);

            return array;
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (IsNullArray(array) && (index != 0 && index != array.Length))
                return array;

            if (IsNullArray(array))
                return new[] { number };

            var insertArray = new int[array.Length + 1];                        // Create index 1 size bigger than original.

            for (var i = 0; i < index; i++)
            {
                insertArray[i] = array[i];                                      // Add elements to the new array until we reach the index to be added.
            }

            insertArray[index] = number;                                        // Add the new specified element.

            for (var i = index; i < array.Length; i++)
            {
                insertArray[i + 1] = array[i];                                  // continue adding elements from the original array, but 1 index further along in the new one.
            }
            return insertArray;
        }


        

        public static void WriteArray(int[] array)      // used to test solutions in console and see what code was outputting.
        {
            foreach (var number in array)
                Console.Write($"{number} ");
            Console.WriteLine();
        }

        public static bool IsNullArray(int[] array)     
        {
            if (array == null || array.Length == 0)
                return true;
            return false;
        }

    }
}
