using System;
using System.Text;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly bool[,] _2darray;

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            _2darray = toggles;
        }

        public void Toggle(int x, int y)
        {
            _gridClearer.Clear();
            try
            {
                if (_2darray[x, y] == false)
                {
                    ///<summary>
                    ///  print black square
                    /// </summary>
                    _2darray[x, y] = true;
                }
                else
                {
                    ///<summary>
                    /// delete existing black square, by setting previous true to false
                    /// </summary>
                    _2darray[x, y] = false;
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw new IndexOutOfRangeException("Index was out of range", ex);
            }
            
            ///<summary>
            ///     create copy of _jaggedarray in type string, to output squares to the console
            /// </summary>
            string[,] outputArray = new string[_2darray.GetLength(0), _2darray.GetLength(1)];
            BuildArray(_2darray, outputArray);
            PrintArray(outputArray);
        }

        public void BuildArray(bool[,] jaggedArray, string[,] outputArray)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 0; col < _2darray.GetLength(1); col++)
                {
                    if (_2darray[row, col] == false)
                    {
                        outputArray[row, col] = " ";
                    }
                    else
                    {
                        outputArray[row, col] = "\u25A0";
                    }
                }
            }
        }

        public void PrintArray(string[,] outputArray)
        {
            for (int row = 0; row < outputArray.GetLength(0); row++)
            {
                for (int col = 0; col < outputArray.GetLength(1); col++)
                {
                    Console.Write(outputArray[row, col]);
                    if (col == outputArray.GetLength(1) - 1 && row != outputArray.GetLength(0) - 1) Console.Write(Environment.NewLine);
                }
            }
        }
    }
}