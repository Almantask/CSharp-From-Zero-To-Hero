using System;
using System.Collections.Generic;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 3, 5, 6, 7, 9, 11 }; 
            ///         new array { 1,3,5,6,7,9,11}
 
            // Modifies the specified array then returns it
            array = ArrayOperations.RemoveAt(array, 3);

            // Prints the array that should have been returned
            PrintArray(array);
            // Instead it prints the old array that was originally specified
                                                                                     /// Console.Write(array[3]);


        }
 
        public static void PrintArray(int[] array)
        {

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            /// PrintArray(array);
        }
    }
}
