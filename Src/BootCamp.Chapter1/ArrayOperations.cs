namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (array == null)
            {
                return;
            }

            // Im using a bubble sort I found on the net. 

            var temp = 0;
            int numLength = array.Length;

            //sorting an array  
            for (var i = 1; i < numLength; i++)
            {
                for (var j = 0; j < (numLength - 1); j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        break;  // array is sorted now so the loop can be leaved.       
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
            var stop = 0;

            if (array == null)
            {
                return;
            }

            stop = array.Length / 2;

            // Here I take a element and put it into temp. 
            // So I can put there the element of the other half of the arrau
            // and put that on that place. After that I can take the contents of
            // temp and put it on the new place 

            // Example lets say we have this {1,2,3,4,5} 
            // then temp will be the 1 
            // then I put the 5 in the place of the 1 so we get {5,2,3,4,5} 
            // then I put the contents of temp on the place on the index the number is placed. 
            // so we get {5,2,3,4,1} 
            // then we goto the next number 2 , that is placed in temp 
            // and the 4 is placed in the place where the 2 was 
            // so we get {5,4,3,4,1} 
            // then we place the 2 on the place where the 4 was so we get {5,4,,2,1} 

            for (var i = 0; i < stop; i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array == null)
            {
                return array;
            }
            var newArray = RemoveAt(array, array.Length - 1);
            return newArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            var newArray = RemoveAt(array, 0);
            return newArray;

        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {

            // check if a array is null 
            if (array == null)
            {
                return array;
            }


            // Check if a array or a index has a invalid content 
            if (index < 0 || index == array.Length || array.Length == 0 || index > array.Length)
            {
                return array;
            }

            // new array to set the new data in , which lenght is 1 smaller because 
            // we only need to remove 1 item.
            var newArray = new int[array.Length - 1];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i < index)
                {
                    // copy the orginal content
                    newArray[i] = array[i];
                }
                else if (i > index)
                {
                    //  because the index is now 1 to high for the new index , we copy it to a index 1 lower
                    newArray[i - 1] = array[i];
                }
            }

            return newArray;
        }



        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {

            if (array == null)
            {
                return new[] { number };
            }

            var newArray = InsertAt(array, number, 0);
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns input array.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                return new[] { number };
            }

            var newArray = InsertAt(array, number, array.Length);
            newArray[newArray.Length - 1] = number;
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {

            // check for a invalid index             
            if (index < 0)
            {
                return array;
            }

            // check for a invalid array 
            if (array == null || array.Length == 0)
            {
                if (index == 0)
                {
                    return new[] { number };
                }
                return array;
            }

            //  a new array that holds the new data with the new item 
            var newArray = new int[array.Length + 1];
            
            // The actual copy and insert data into the new array 
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i < index)
                {
                    // copy the orginal content
                    newArray[i] = array[i];
                }
                else if (i > index)
                {
                    //  because the index is now 1 to high for the new index , we copy it to a index 1 higher
                    newArray[i + 1] = array[i];
                }
                else
                {
                    //we have the new element
                    newArray[i] = number;
                }
            }

            return newArray;

        }

    }
}
