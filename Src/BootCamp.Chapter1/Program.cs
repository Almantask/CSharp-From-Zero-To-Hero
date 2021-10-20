using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test = new int[] { 1, 2, 3, 4, 5 };

            PrintMessage("Reverse array:");
            ArrayOperations.Reverse(test);
            PrintArray(test);

            PrintMessage("Remove last element in array:");
            var modifiedTest = ArrayOperations.RemoveLast(test);
            PrintArray(modifiedTest);

            PrintMessage("Remove first element in array:");
            var modifiedTest2 = ArrayOperations.RemoveFirst(test);
            PrintArray(modifiedTest2);

            PrintMessage("Remove element of array at index = 0 (first)");
            var modText3 = ArrayOperations.RemoveAt(test, 0);
            PrintArray(modText3);

            PrintMessage("Remove element of array at index = 1");
            var modText5 = ArrayOperations.RemoveAt(test, 1);
            PrintArray(modText5);

            PrintMessage("Remove element of array at index = 2");
            var modText6 = ArrayOperations.RemoveAt(test, 2);
            PrintArray(modText6);

            PrintMessage("Remove element of array at index = 3");
            var modText7 = ArrayOperations.RemoveAt(test, 3);
            PrintArray(modText7);

            PrintMessage("Remove element of array at index = 4 (last)");
            var modText4 = ArrayOperations.RemoveAt(test, 4);
            PrintArray(modText4);

            PrintMessage("Insert element at first index");
            var modText8 = ArrayOperations.InsertFirst(test, 10);
            PrintArray(modText8);

            PrintMessage("Insert element at last index");
            var modText9 = ArrayOperations.InsertLast(test, 10);
            PrintArray(modText9);

            PrintMessage("Insert element at desired index");
            var modText10 = ArrayOperations.InsertAt(test, 10, 4);
            PrintArray(modText10);

            Console.ReadKey();

        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static void PrintMessage(string text)
        {
            Console.WriteLine(text);
        }

    }

  
}
