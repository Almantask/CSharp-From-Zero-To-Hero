using System;
using System.Text;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly bool[][] _jaggedArray;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            _jaggedArray = toggles;
        }

        public void Toggle(int x, int y)
        {
            _gridClearer.Clear();

            try
            {
                if (_jaggedArray[x][y] == false)
                {
                    ///<summary>
                    ///  print black square
                    /// </summary>
                    _jaggedArray[x][y] = true;
                }
                else
                {
                    ///<summary>
                    /// delete existing black square, by setting previous true to false
                    /// </summary>
                    _jaggedArray[x][y] = false;
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw new IndexOutOfRangeException("Index was out of range", ex);
            }

            string[][] outputArray = new string[_jaggedArray.GetLength(0)][];
            InitializeArray(_jaggedArray, outputArray);
            BuildArray(_jaggedArray, outputArray);
            PrintArray(outputArray);
        }

        public void InitializeArray(bool[][] jaggedArray, string[][] outputArray)
        {
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                outputArray[row] = new string[jaggedArray[row].Length];
            }
        }

        public void BuildArray(bool[][] jaggedArray, string[][] outputArray)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for(int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if(jaggedArray[row][col] == false)
                    {
                        outputArray[row][col] = " ";
                    }
                    else
                    {
                        outputArray[row][col] = "\u25A0";
                        //outputArray[row][col] = "■";
                    }
                }
            }
        }

        public void PrintArray(string[][] outputArray)
        {
            for (int row = 0; row < outputArray.GetLength(0); row++)
            {
                for (int col = 0; col < outputArray[row].Length; col++)
                {
                    Console.Write(outputArray[row][col]);
                }

                if (row < outputArray.GetLength(0) - 1)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}