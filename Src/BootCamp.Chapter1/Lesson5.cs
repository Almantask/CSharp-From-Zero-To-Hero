namespace BootCamp.Chapter1
{
    class Lesson5
    {
        public static void Sort(int[] array)
        {
            //check if array is null
            if (array == null)
            {
                return;
            }

            while (true)
            {
                bool noSwaps = true;
             
                for (int i = 0; i < (array.Length - 1); i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        noSwaps = false;
                    }
                }

                if (noSwaps)
                {
                    break;
                }
            }
        }

        public static void Reverse(int[] array)
        {
            //check if array is null
            if (array == null)
            {
                return;
            }

            int[] copyArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                copyArray[i] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = copyArray[array.Length - i - 1];
            }
        }

        public static int[] RemoveLast(int[] array)
        {
            //check if array is null
            if (array == null)
            {
                return array;
            }

            //check for arrays of less than length 2
            if (array.Length < 2)
            {
                int[] emptyArray = new int[0];
                return emptyArray;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        public static int[] RemoveFirst(int[] array)
        {
            //check if array is null
            if (array == null)
            {
                return array;
            }


            //check for arrays of less than length 2
            if (array.Length < 2)
            {
                int[] emptyArray = new int[0];
                return emptyArray;
            }

            int[] newArray = new int[array.Length - 1];
            for(int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[1 + i];
            }

            return newArray;
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            //check if array is null
            if (array == null)
            {
                return array;
            }

            // check if index is out of range
            if (index < 0 || index >= array.Length)
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if(i < index)
                {
                    newArray[i] = array[i];
                    continue;
                }

                newArray[i] = array[i + 1];
            }

            return newArray;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            //check if array is null
            if (array == null)
            {
                var returnArray = new int[1];
                returnArray[0] = number;
                return returnArray;
            }

            int[] newArray = new int[array.Length + 1];
            newArray[0] = number;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            return newArray;
        }

        public static int[] InsertLast(int[] array, int number)
        {
            //check if array is null
            if (array == null)
            {
                var returnArray = new int[1];
                returnArray[0] = number;
                return returnArray;
            }

            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = number;
            return newArray;
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (array == null)
            {
                var returnArray = new int[1];
                returnArray[0] = number;
                return returnArray;
            }

            //check if it is valid
            if (index < 0 || index > array.Length)
            {
                return array;
            }

            int[] newArray = new int[array.Length + 1];
            newArray[index] = number;

            for(int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = array[i];
                    continue;
                }

                newArray[i + 1] = array[i];
            }

            return newArray;
        }
    }
}
