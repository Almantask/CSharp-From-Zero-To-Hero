using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ArrayOperations
    {
        //Convert String to int method that should be here...

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static string[] RemoveLast(string[] array)
        {
            if (array == null) return null;
            return RemoveAt(array, array.Length - 1);

        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static string[] RemoveFirst(string[] array)
        {
            return RemoveAt(array, 0);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static string[] RemoveAt(string[] array, int index)
        {
            if (array == null || array.Length == 0 || index == -1 || index > array.Length - 1) return array;
            string[] newArray = new string[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }

            return newArray;
        }

        public static double[] ConvertStringArrtoDouble(string[] arr)
        {
            double[] newArr;
            newArr = Array.ConvertAll(arr, new Converter<string, double>(ConverttoDouble));

            static double ConverttoDouble(string element)
            {
                if (element == " ")
                {
                    return 0;
                }
                return Convert.ToDouble(element);
            }

            return newArr;
        }

        /*Method that extract and convert numbers from a string array to Double array,
       then compare the values of the Double Array and return the heighest one in a string Format*/
        public static string ExtractNumbers(StringBuilder sr)
        {
            StringBuilder name = new StringBuilder();

            char n;
            string str = sr.ToString();
            string[] arr = str.Split(" ");

            int compter = 0;
            double balance = 0;
            double Heighestbalance = 0;

            /* newIndex solves the issue with the last item who s an empty string 
             this snippet allows us to remove the last item if it is an empty string
            */
            int Index = Array.FindLastIndex(arr, EndsWithEmpty);
            if (Index != -1)
            {
                Array.Resize(ref arr, Index);
            }

            //Loop that extract the heighest balance form the array
            for (int i = 0; i < arr.Length; i++)
            {
                bool test = Char.IsDigit(arr[i], 0);
                if (test == true)
                {
                    balance = Convert.ToDouble(arr[i]);
                    if (balance > Heighestbalance)
                    {
                        name.Clear();
                        name.Append(arr[i - 1]);
                        Heighestbalance = balance;
                    }
                    else if (balance == Heighestbalance)
                    {
                        if (compter == 0)
                        {
                            compter++;
                            name.Append(", " + arr[i - 1] + " and ");
                        }
                        else
                        {
                            name.Append(arr[i - 1]);
                        }

                    }
                }
            }

            return name + " had the most money ever. ¤" + Heighestbalance.ToString() + ".";

        }

        static bool EndsWithEmpty(String s)
        {
            if (s == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
