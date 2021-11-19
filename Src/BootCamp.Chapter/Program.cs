using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///     Get amount of rows from user
            ///</summary>
            int rowsAmount = GetAmountOfRows();

            if (rowsAmount != -1)
            {
                ///<summary>
                ///     Get length of each grind from a user, and store input in array
                /// </summary>
                int[] gridLength = new int[rowsAmount];
                GetLengthOfRows(rowsAmount, gridLength);

                ///<summary>
                ///     Create jagged array, based on user input
                /// </summary>
                bool[][] jaggedArray = new bool[rowsAmount][];
                CreateJaggedArray(rowsAmount, jaggedArray, gridLength);

                //IGridClearer gridClearer = null;
                ToggleableGridJagged test = new ToggleableGridJagged(jaggedArray, null);

                (string tupleTest, int value) = TuplesTest("test", 4);
                Console.WriteLine($"{tupleTest}, {value}");

                test.Toggle(2, 1);
            }
           


            Console.ReadKey();
        }

        public static int GetAmountOfRows()
        {
            int result;
            bool convertSuccess = int.TryParse(PrintMessage("What's the amount of rows in the grid"), out result);

            return (convertSuccess == true && result > 0) ? result : -1;
        }

        public static void GetLengthOfRows(int rowsAmount, int[] gridLength)
        {
            for (int i = 0; i < gridLength.Length; i++)
            {
                bool success = int.TryParse(PrintMessage($"Enter length of {i} grid"), out rowsAmount);
                if (success)
                {
                    gridLength[i] = rowsAmount;
                }
            }
        }

        public static void CreateJaggedArray(int rowsAmount, bool[][] jaggedArray, int[] gridLength)
        {
            for (int i = 0; i < rowsAmount; i++)
            {
                jaggedArray[i] = new bool[gridLength[i]];
            }
        }

        public static string PrintMessage(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static (string test, int numberOne) TuplesTest(string message, int numberOne)
        {
            numberOne += 100;
            message += numberOne;

            return (message, numberOne);
        }
    }
}
