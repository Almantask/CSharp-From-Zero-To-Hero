using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> lista2 = new List<int> { 1, 2, 3, 4, 5, 6 };
            lista2.ShuffleListIList();

            lista.SnapFingers();

            int[] arrayList = new int[] { 1, 2, 3, 4, 5 };
            arrayList.ShuffleListIList();

            Console.ReadKey();
        }
    }
}
