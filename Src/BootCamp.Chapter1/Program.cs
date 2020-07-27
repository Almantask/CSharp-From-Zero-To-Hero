namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = {1, 0, 4, 7, 3 };
            System.Console.Write("Printing starting array: ");
            foreach (var item in testArray)
            {
                System.Console.Write(item + ",");
            }
            System.Console.WriteLine();
            ArrayOperations.Reverse(testArray);
            System.Console.Write("Sorting the array in reverse order: ");
            foreach (var item in testArray)
            {
                System.Console.Write(item + ",");
            }
            System.Console.WriteLine();
            var testArray2 = ArrayOperations.InsertAt(testArray, 10, 1);
            System.Console.Write("Inserting number 10 at index 1: ");
            foreach (var item in testArray2)
            {
                System.Console.Write(item + ",");
            }
            System.Console.WriteLine();
            ArrayOperations.Sort(testArray2);
            System.Console.Write("Sorting the array in ascending order: ");
            foreach (var item in testArray2)
            {
                System.Console.Write(item + ",");
            }
            System.Console.WriteLine();
        }
    }
}
