using System;
namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="intArray">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }
            // Bubble Sort

            //Go through the entire length of the array
            //Keeps going so the inner loop can keep checking for every position
            for (int i = 0; i < array.Length; i++)
            {
                //the inner loop
                // go over the indexes and compare numbers side by side
                //go through the array with array.Length -1 -i because
                //we know the value on the right will be the biggest and dont need
                //to check that number to the right of it because that will be out of bounds
                //on the check. ex)   6,1,7,11,9 >>>> 1,6,7,9,11 if I check 11 and the next one to the right
                //it will be checking nothing because there is no value to the right of it so that is why its -1
                //but we also -i because we know after 1st pass all values to the right -1 of length and -i will be largest
                // this helps with efficiency
                for (int j = 0; j < (array.Length - 1 - i); j++)
                {
                    //take index j = 0 and compre it to the next one right beside it with j+1
                    // so side by side comparison
                    if (array[j] > array[j + 1])
                    {
                        // if its bigger then place it into a temporary variable
                        int temp = array[j];
                        // now put the smaller variable into the position of the larger variable which was 1 behind it
                        array[j] = array[j + 1];

                        //now take the temp variable that is holding the larger int and place it into the 
                        //position of j+1 
                        array[j + 1] = temp;
                    }
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
            if (array == null || array.Length == 0)
            {
                return;
            }
            //Only have to go half way of the array because after swap of half the entire array is swap, if kept going 
            //will put back to what it was
            for(int i = 0; i < array.Length / 2; i++)
            {
                //create temp int variable to hold the value at index i
                //this changes each loop
                int temp = array[i];
                //place into it at index i the last value -1 -i because it keeps shrinking each iteration
                
                array[i] = array[array.Length - 1 - i];
                //now place the temp variable into that last index -1 -i because it keeps shrinking index each iteration
                array[array.Length -1 - i] = temp;
            }

        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            int index = array.Length-1;
            return RemoveAt(array, index);
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

           const int index = 0;
            return RemoveAt(array, index);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            //return array of the index is less than 0, there is no negative index values 
            //return array if the index is greater than the length of the array, -1 because
            // index is a number like 10 but in the array it would be array[9]
            if (array == null || array.Length == 0 || index < 0 || index > array.Length -1)
            {
                return array;
            }

            //declare variable with length of -1 because this method removed only 1 index
            int[] modifiedArray = new int[array.Length -1];

            //declare a count variable so I can skip when the index is found
            int count = 0;
            //loop through entire array with length -1 because when I skip over the match up 
            //it will try to put an out of bound value into the new array.
            for (int i = 0; i < array.Length -1; i++)
            {
                //check if the index passed in matches an index in the array
                if(i == index)
                {
                    //if it does increase count by 1 so that it knows to skip that index
                    count++;
                }
                //place array values into modifiedarray 
                modifiedArray[i] = array[count];
                count++;
            }
            return modifiedArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            return InsertAt(array, number, 0);
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                int[] newArray = new int[1];
                newArray[0] = number;
                return newArray;
            }

            int index = array.Length +1;
            return InsertAt(array, number, index);
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
                int[] newArray = new int[1];
                newArray[0] = number;
                return newArray;
            }

            if (array.Length == 0 && index > 0)
            {
                return array;
            }

            if (array.Length == 0 && index == 0)
            {
                int[] newArray = new int[1];
                newArray[0] = number;
                return newArray;
            }

            if (index < 0)
            {
                return array;
            }


            int[] insertNumAtIndex = new int[array.Length + 1];
            int count = 0;


            if(insertNumAtIndex.Length == index)
            {
                insertNumAtIndex[insertNumAtIndex.Length - 1] = number;
            }
           
            for(int i = 0; i < insertNumAtIndex.Length-1; i++)
            {
                if(i == index)
                {
                    insertNumAtIndex[i] = number;
                    count++;
                }
               
                insertNumAtIndex[count] = array[i];
                count++;
            }
            return insertNumAtIndex;
        }
    }
}
