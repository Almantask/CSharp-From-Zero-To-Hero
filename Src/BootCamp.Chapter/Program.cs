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

                //(string tupleTest, int value) = TuplesTest("test", 4);
                //Console.WriteLine($"{tupleTest}, {value}");

                ClearGrid gridClearer = new ClearGrid();
                ToggleableGridJagged toggleableGridJagged = new ToggleableGridJagged(jaggedArray, gridClearer);

                bool isRunning = false;
                do
                {
                    isRunning = ToggleArray(toggleableGridJagged);
                } while (isRunning);

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

        public static bool ToggleArray(ToggleableGridJagged toggleableGridJagged)
        {
            string userInput = PrintMessage("Input x,y to toggle element in an array");
            string[] input = userInput.Split(",");
            int x, y, xResult, yResult;

            if (input.Length > 1)
            {
                bool isXOk = int.TryParse(input[0], out xResult);
                if (isXOk)
                {
                    x = xResult;
                }
                bool isYOk = int.TryParse(input[1], out yResult);
                if (isYOk)
                {
                    y = yResult;
                }

                toggleableGridJagged.Toggle(xResult, yResult);
                return true;
            }
   
            return false;
        }

        public static (string test, int numberOne) TuplesTest(string message, int numberOne)
        {
            numberOne += 100;
            message += numberOne;

            return (message, numberOne);
        }
    }
}
