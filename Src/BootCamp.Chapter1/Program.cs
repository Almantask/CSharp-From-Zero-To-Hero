namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 0, 7 };
            testArray = ArrayOperations.InsertLast(testArray, 1);
            foreach (var item in testArray)
            {
                System.Console.Write(item + ", ");
            }
        }
    }
}
