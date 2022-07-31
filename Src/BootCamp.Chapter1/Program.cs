using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1];
            array = ArrayOperations.InsertAt(array, 10, 1);

            foreach (int i in array)
            {
                Console.Write(i);
            }
        }
    }
}
