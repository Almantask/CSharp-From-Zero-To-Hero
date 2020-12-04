using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter1
{
    class Lesson5
    {
        public static void Sort(int[] array)
        {
            // ToDo: implement.
            if(array == null)
            {
                return;
            }

            Array.Sort(array);
            
        }


        public static void Reverse(int[] array)
        {
            // ToDo: implement.
            if(array == null)
            {
                return;
            }

            int[] newarr = new int[array.Length];

            for(int i=0; i<(array.Length); i++)
            {
                newarr[i] = array[i];
            }

            for(int i=0; i<array.Length; i++)
            {
                array[i] = newarr[array.Length - i -1];
            }
        }

        public static int[] RemoveLast(int[] array)
        {
            // ToDo: implement.
            if(array == null)
            {
                return array;
            }

            if ((array.Length).Equals(0))
            {
                return array;
            }

            int[] newarr = new int[(array.Length) - 1];
            for(int i=0; i<newarr.Length; i++)
            {
                newarr[i] = array[i];
            }
            return newarr;

        }

        public static int[] RemoveFirst(int[] array)
        {
            // ToDo: implement.
            if (array == null)
            {
                return array;
            }

            if((array.Length).Equals(0))
            {
                return array;
            }

            int[] newarr = new int[array.Length - 1];

            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = array[i+1];
            }
            return newarr;
        }


        public static int[] RemoveAt(int[] array, int index)
        {
            // ToDo: implement.
            if (array == null)
            {
                return array;
            }

            if(index<0 || index> (array.Length)-1)
            {
                return array;
            }

            int[] newarr = new int[array.Length - 1];
            for (int i = 0; i < newarr.Length; i++)
            {
                if(i<index)
                {
                    newarr[i] = array[i];
                    continue;
                }
                newarr[i] = array[i + 1];
            }
            return newarr;
        }


        public static int[] InsertFirst(int[] array, int number)
        {
            // ToDo: implement.
            if (array == null)
            {
                var singleArray = new int[1];
                singleArray[0] = number;
                return singleArray;
                
            }

            int[] newarr = new int[array.Length + 1];
            newarr[0] = number;

            for (int i = 0; i < array.Length; i++)
            {
                newarr[i+1] = array[i];
            }
            return newarr;

        }

        public static int[] InsertLast(int[] array, int number)
        {
            // ToDo: implement.
            if (array == null)
            {
                var singleArray = new int[1];
                singleArray[0] = number;
                return singleArray;

            }

            int[] newarr = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newarr[i] = array[i];
            }
            newarr[array.Length] = number;

            return newarr;
            
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {
            // ToDo: implement.
            if (array == null)
            {
                var singleArray = new int[1];
                singleArray[0] = number;
                return singleArray;
            }

            if (index < 0 || index > array.Length)
            {
                return array;
            }

            int[] newarr = new int[array.Length + 1];
            newarr[index] = number;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    newarr[i] = array[i];
                    continue;
                }

                newarr[i+1] = array[i];
            }
            return newarr;
        }
    }
}
