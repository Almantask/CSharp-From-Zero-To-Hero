using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataset = new[] { 999, 9, 99, 55, 1, 1337};
            //var dataset = new int[1];
            PrintDatasetResult("Start result: ", dataset);

            //ArrayOperations.Sort(dataset);
            //PrintDatasetResult("End result: ", dataset);

            //ArrayOperations.Reverse(dataset);
            //PrintDatasetResult("End result: ", dataset);

            //var newDataset = ArrayOperations.RemoveLast(dataset);
            //PrintDatasetResult("End result: ", newDataset);

            //var newDataset = ArrayOperations.RemoveFirst(dataset);
            //PrintDatasetResult("End result: ", newDataset);

            //var newDataset = ArrayOperations.RemoveAt(dataset, 3);
            //PrintDatasetResult("End result: ", newDataset);

            //var newDataset = ArrayOperations.InsertFirst(dataset, 666);
            //PrintDatasetResult("End result: ", newDataset);

            //var newDataset = ArrayOperations.InsertLast(dataset, 666);
            //PrintDatasetResult("End result: ", newDataset);

            var newDataset = ArrayOperations.InsertAt(dataset, 666, 3);
            PrintDatasetResult("End result: ", newDataset);
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
