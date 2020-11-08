using System;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace BootCamp.Chapter
{
    class Program
    {
        static int[] array;

        static void Main(string[] args)
        {
            SuboptimalLoopComparisonDemo();
        }

        public static void SuboptimalLoopComparisonDemo()
        {
            var sw = new Stopwatch();
            sw.Start();
            SlowSortedNumbersPrint();
            sw.Stop();
            // Took 1370 ms.
            Console.WriteLine("Slow sort took: " + sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            // Took 62 ms.
            FastSortedNumbersPrint();
            sw.Stop();
            Console.WriteLine("Fast sort took " + sw.ElapsedMilliseconds);
            sw.Reset();
        }

        private static void SlowSortedNumbersPrint()
        {
            int[] unsortedArray = new int[2048];
            System.Console.WriteLine("The first 100 numbers are:");

            for (int i = 0; i < 99; i++)
            {
                // DO NOT sort inside a loop or do any other complex number.
                int[] sortedArray = Sort(unsortedArray);
                System.Console.WriteLine(sortedArray[i]);
            }
        }

        private static void FastSortedNumbersPrint()
        {
            int[] unsortedArray = new int[2048];
            System.Console.WriteLine("The first 100 numbers are:");

            // Sort the loop outside of array and then print the results.
            int[] sortedArray = Sort(unsortedArray);
            for (int i = 0; i < 99; i++)
            {
                System.Console.WriteLine(sortedArray[i]);
            }
        }

        public static int[] Sort(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int ii = 0; ii < array.Length; ii++)
                {
                    result[ii] = ii;
                }
            }
            return result;
        }

        private static void StringDemo()
        {
            var name = "kaisinel";
            Console.WriteLine("Before: " + name);
            CapitalizeFirstV1(name);
            // prints kaisinel.
            Console.WriteLine("After v1: " + name);

            name = CapitalizeFirstV2(name);
            // prints Kaisinel.
            Console.WriteLine("After v2: " + name);
        }

        private static void CapitalizeFirstV1(string name)
        {
            // string is immuatable, won't work!
            // name[0] = "K";

            var firstLetter = name[0].ToString().ToUpper();
            name = firstLetter + name.Substring(1, name.Length - 1);

            Console.WriteLine("In between: " + name);
        }

        private static string CapitalizeFirstV2(string name)
        {
            // string is immuatable, won't work!
            // name[0] = "K";

            var firstLetter = name[0].ToString().ToUpper();
            name = firstLetter + name.Substring(1, name.Length - 1);

            // prints Kaisinel.
            Console.WriteLine("In between: " + name);

            return name;
        }



        private static void DemoPassByReference()
        {
            var array = new[] {1, 2, 3};
            SetAllElementsOfArrayTo(array, 10);
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            
        }

        private static void SetAllElementsOfArrayTo(int[] array, int number)
        {
            // This won't work- because we work with copies of elements in array,
            // not with the array itself.
            //foreach(var element in array)
            //{
            //    element = number;
            //}

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number;
            }

            // No need to return anything- changes persisted.
        }

        private static void DemoNullReference()
        {
            // Null reference exception
            Console.WriteLine(array[0]);
        }

        private static void DemoOutofRange()
        {
            var array = new int[0];
            // IndexOutOfRangeException
            Console.WriteLine(array[0]);
        }

        private static void DemoAppendToArray()
        {
            // Empty array
            var array = new int[0];
            // New array with one element. { 10 }. 
            var expandedArray = AppendToArray(array, 10);

            // Prints System.int32[]. DO NOT print array object, print array elements.
            Console.WriteLine(array);

            // Will not print all elements.
            foreach (var number in expandedArray)
            {
                Console.Write(number + " ");
            }
        }

        private static int[] AppendToArray(int[] array, int numberToBeAdded)
        {
            // Expand the array
            var array2 = new int[array.Length + 1];
            // Copy elements over
            for (var i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            // Fill the last spot with the number to be added.
            array2[array2.Length-1] = numberToBeAdded;

            return array2;
        }
    }
}
