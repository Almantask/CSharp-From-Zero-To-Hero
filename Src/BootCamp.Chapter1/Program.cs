using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataset = new[] { 999, 9, 99, 55, 1, 1337 };
            PrintDatasetResult("Start result: ", dataset);

            ArrayOperations.Reverse(dataset);
            PrintDatasetResult("End result: ", dataset);
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
