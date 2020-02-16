using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void PrintDatasetResult(string resultType, int[] array)
        {
            Console.Write(resultType);
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.Write(Environment.NewLine);
        }
    }
}
