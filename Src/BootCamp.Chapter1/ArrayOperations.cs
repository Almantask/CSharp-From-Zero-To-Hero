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

            foreach (int number in array)
            {
                Console.Write("[" + number + "]");
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


            Console.Write("Before reverse:");

            foreach (int number in array)
            {
                Console.Write("[" + number + "]");
            }
            Console.WriteLine();
            
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

            Console.Write("After reverse: ");
            foreach (int number in array)
            {
                Console.Write("[" + number + "]");
            }
            Console.WriteLine();

            
           
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

            Console.Write("Before removing last element: ");
            foreach (int number in array)
            {
                Console.Write("[" + number + "]");
            }
            Console.WriteLine();

          // declare int[] with the length of old array - the last index 
            int[] removedLastElement = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                removedLastElement[i] = array[i];
            }

            Console.Write("After removing last element:  ");
            foreach (int number in removedLastElement)
            {
                Console.Write("[" + number + "]");
            }
            Console.WriteLine();

            return removedLastElement;
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

            Console.Write("Before removing first element:");
            foreach (int number in array)
            {
                Console.Write("[" + number + "]");
            }
            Console.WriteLine();

            //declare new int array and give it the length of incoming array -1 spot
            int[] removeFirstElement = new int[array.Length-1];

            //start at 2nd position of array index and go through entire array length and add
            //the rest of the array into the new declared array.
            for(int i = 1; i < array.Length; i++)
            {
                //take ith position and -1 to place it into first index of array
                removeFirstElement[i-1] = array[i];
            }

            Console.Write("After removing first element:    ");
            foreach (int number in removeFirstElement)
            {
                Console.Write("[" + number + "]");
            }
            Console.WriteLine();

            return removeFirstElement;
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

            Console.Write("Before removing at index: ");
            foreach (int number in array)
            {
                Console.Write("[" + number + "]");
            }
            Console.WriteLine();

            //declare variable with length of -1 because this method removed only 1 index
            int[] modifiedArray = new int[array.Length -1];

            //declare a count variable so I can skip when the index is found
            int count = 0;
            //loop through entire array with length -1 because when I skip over the match up 
            //it will try to put an out of bound value into the new array.
            for (int i = 0; i < array.Length -1; i++)
            {
                //check if the index passed in matches an index in the array
                if(array[index] == array[i])
                {
                    //if it does increase count by 1 so that it knows to skip that index
                    count++;
                }
                //place array values into modifiedarray 
                modifiedArray[i] = array[count];
                count++;
            }

            Console.Write("After removing at index:  ");
            foreach (int number in modifiedArray)
            {
                Console.Write("[" + number + "]");
            }
            Console.WriteLine();

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
                if (array == null || array.Length == 0)
                {
                    int[] newArray = new int[1];
                    newArray[0] = number;
                    return newArray;
                }

            int[] addedNumberArray = new int[array.Length + 1];

            Console.Write("Before adding new number: ");
            foreach (int num in array)
            {
                Console.Write("[" + num + "]");
            }
            Console.WriteLine();

            addedNumberArray[0] = number;
            for (int i = 0; i < addedNumberArray.Length-1; i++)
            {
                addedNumberArray[i+1] = array[i];
            }

            Console.Write("After adding new number:  ");
            foreach (int num in addedNumberArray)
            {
                Console.Write("[" + num + "]");
            }
            Console.WriteLine();

            return addedNumberArray;
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

            Console.Write("Before adding Last number: ");
            foreach (int num in array)
            {
                Console.Write("[" + num + "]");
            }
            Console.WriteLine();

            int[] insertLastNum = new int[array.Length + 1];


            //put all values of array into new array called insertLastNum
            for(int i = 0; i < insertLastNum.Length - 1; i++)
            {
                insertLastNum[i] = array[i];
            }

            //add the insert value called number to end of the array
            insertLastNum[insertLastNum.Length -1] = number;

            Console.Write("After adding Last number:  ");
            foreach (int num in insertLastNum)
            {
                Console.Write("[" + num + "]");
            }
            Console.WriteLine();


            return insertLastNum;
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
            if(array.Length == 0 && index == 0)
            {
                int[] newArray = new int[1];
                newArray[0] = number;
                return newArray;
            }

            if (index < 0)
            {
                return array;
            }
           
            if(index > array.Length -1)
            {
                return array;
            }

            Console.Write("Before InsertingAt new number: ");
            foreach (int num in array)
            {
                Console.Write("[" + num + "]");
            }
            Console.WriteLine();

            int[] insertNumAtIndex = new int[array.Length + 1];
            int count = 0;

            for(int i = 0; i < insertNumAtIndex.Length -1; i++)
            {
                if(i == index)
                {
                    insertNumAtIndex[i] = number;
                    count++;
                }

                insertNumAtIndex[count] = array[i];
                count++;
            }


            Console.Write("After InsertingAt new number:  ");
            foreach (int num in insertNumAtIndex)
            {
                Console.Write("[" + num + "]");
            }
            Console.WriteLine();

            return insertNumAtIndex;
        }
    }
}
