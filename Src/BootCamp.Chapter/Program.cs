using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryDemo();
            JaggedDemo();
            ndDemo();
        }

        private static void DictionaryDemo()
        {
            Dictionary<string, string> ltToEn = new Dictionary<string, string>();
            ltToEn.Add("Labas", "Hi");
            ltToEn.Add("Iki", "Bye");

            var translation1 = ltToEn["Labas"];
            var translation2 = ltToEn["Iki"];

            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                {0, "Zero"},
                {1, "one"},
                {2, "two"}
            };
        }

        private static void JaggedDemo()
        {
            ndDemo();
            int[,] table1 = new int[2, 2]; // now both dimensions MUST be given.
            var topLeft = table1[0, 0]; // first row, first column.
            var topRight = table1[0, 1]; // first row, 2nd column.

            int[,,,] table = new int[2, 3, 5, 6];
            var totalElements = table.Length; // 2 * 3 * 5 * 6 = 180
            var d1 = table.GetLength(0); // 2
            var d2 = table.GetLength(1); // 3
            var d3 = table.GetLength(2); // 5
            var d4 = table.GetLength(3); // 6

            Console.WriteLine($"Rows:{totalElements}, [{d1},{d2},{d3},{d4}]");
        }


        private static void ndDemo()
        {
            int[][] table = new int[2][]; // 2 rows.
            table[0] = new int[2]; // row 0.
            table[1] = new int[4]; // row 2.
            var rows = table.Length;
            var columnsOfRow1 = table[0].Length;

            int[][][] array3d = new int[0][][]; // empty 3d array
            int[][][][] array4d = new int[0][][][]; // empty 4d array

            Console.WriteLine($"Rows: {rows}, columns: {columnsOfRow1}");
            // Rows don't need to be matching in size!

            var topLeft = table[0][0]; // 0th row, 0th element in the row.
            var topRight = table[0][1]; // 0th row, 1st element in the row.
        }
    }
}
