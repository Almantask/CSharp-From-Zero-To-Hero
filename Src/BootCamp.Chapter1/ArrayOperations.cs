using System;
namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        // *************private helpers**********
        /// <summary>
        /// Test that Array is neither null or empty.
        /// </summary>
        /// <returns>True if array can be manipulated by standard functions.</returns>
        /// 
        private static bool ValidateArrayForManipulation(int[] array)
        {
            return ((array != null) && (array.Length != 0));
        }

        /// <summary>
        /// Makes the array one index item shorter.
        /// </summary>
        /// <returns>A new array with (original length - 1)</returns>
        /// 
        private static int[] MakeAShorterArray(int[] array)
        {
            return new int[array.Length - 1];
        }

        /// <summary>
        /// Makes a new array with one index with an int
        /// </summary>
        /// <returns>A new array with a single index with value {number}>
        /// 
        private static int[] AddOneNumberToNullArray(int number)
        {
            return new[] { number };
        }

         /// <summary>
        /// Makes the array one index item longer.
        /// </summary>
        /// <returns>A new array with (original length+ 1)</returns>
        private static int[] MakeALongerArray(int[] array)
        {
            return new int[array.Length + 1];
        }

        /// <summary>
        /// set a new value at either the very first or very last index point
        /// </summary>
        /// <returns>array that has one value replaced at specified index
        /// 

        private static void PlaceTheNewNumberAtTheAppropriateIndexPosition(int[] lengthenedArray, string position, int number)
        {
            switch (position)
            {
                case "Last":
                    lengthenedArray[lengthenedArray.Length - 1] = number;
                    break;

                case "First":
                    lengthenedArray[0] = number;
                    break;
            }
        }

        /// <summary>
        /// set a new value at the specified index point
        /// </summary>
        /// <returns>array that has one value replaced at specified index
        ///  
        private static void PlaceTheNewNumberAtTheAppropriateIndexPosition(int[] lengthenedArray, int index, int number)
        {
            lengthenedArray[index] = number;
        }

        /// <summary>
        /// Confirm thar the index to be modified exists.
        /// </summary>
        /// <returns>True if index is valid
        /// 
        private static bool ConfirmThatTargetIndexToManipulateIsWithinTheRangeOfTheArray(int[] array, string action, int index)
        {
            return (action == "Remove") ? ((index < array.Length) && (index >= 0)) : ((index <= array.Length) && (index >= 0));
        }


        //public array operations

         /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (ValidateArrayForManipulation(array))
            // insertion sort
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int index = array[i]; int j = i;
                    while (j > 0 && array[j - 1] > index)
                    {
                        array[j] = array[j - 1];
                        j--;
                    }
                    array[j] = index;
                }
            }
        }
        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (ValidateArrayForManipulation(array))
            {
                int[] tempArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = tempArray[array.Length - 1 - i];
                }
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (ValidateArrayForManipulation(array)) 
            {
                var shortenedArray = MakeAShorterArray(array);

                for (int i = 0; i < shortenedArray.Length; i++)
                {
                    shortenedArray[i] = array[i];
                }
                return shortenedArray;
            }
            return array;
        }
       
        
        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        /// 
        public static int[] RemoveFirst(int[] array)
        {
            if (ValidateArrayForManipulation(array))
            {
                var shortenedArray = MakeAShorterArray(array);
                
                for (int i = 0; i < shortenedArray.Length; i++)
                {
                    shortenedArray[i] = array[i+1];
                }
                return shortenedArray;
            }
            return array;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
          
            if ((ValidateArrayForManipulation(array)) && (ConfirmThatTargetIndexToManipulateIsWithinTheRangeOfTheArray(array, "Remove", index)))
            {
                var shortenedArray = MakeAShorterArray(array);

                for (int i = 0; i < shortenedArray.Length; i++)
                {
                shortenedArray[i] = i >= index ? array[i + 1] : array[i];
                }
                return shortenedArray;
            }
            return array;
        }
      

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null)
            {
                return AddOneNumberToNullArray(number);
            }

            var lengthenedArray = MakeALongerArray(array);

            PlaceTheNewNumberAtTheAppropriateIndexPosition(lengthenedArray, "First", number);
            
            for (int i = 1; i < lengthenedArray.Length; i++)
            {
                lengthenedArray[i] = array[i-1];
            }
            array = lengthenedArray;
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null)
            {
                return AddOneNumberToNullArray(number);
            }

            var lengthenedArray = MakeALongerArray(array);
            
            //place the new number at the end of the new, long array
            PlaceTheNewNumberAtTheAppropriateIndexPosition(lengthenedArray, "Last", number);
            
            //repopulate the rest of the numbers at their same index in the longer array
            for (int i = 1; i < lengthenedArray.Length-1; i++)
            {
                lengthenedArray[i] = array[i];
            }
            return lengthenedArray;
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
            if (array == null)
            {
                return AddOneNumberToNullArray(number);
            }
            if ((ConfirmThatTargetIndexToManipulateIsWithinTheRangeOfTheArray(array, "Insert", index)))
            {
                var lengthenedArray = MakeALongerArray(array);

                //place the new number at the desired index

                PlaceTheNewNumberAtTheAppropriateIndexPosition(lengthenedArray, index, number);

                // place all the original array numbers in their original position. 
                //when we get to the new index placement, offsetting position of the old array positions by one
                for (int i = 0; i < lengthenedArray.Length - 1; i++)
                {
                    if (i >= index)
                    {
                        lengthenedArray[i + 1] = array[i];
                    }
                    else
                    {
                        lengthenedArray[i] = array[i];
                    }
                }
                return lengthenedArray;
            }
            return array;
        }
    }
}
