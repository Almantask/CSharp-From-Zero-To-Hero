namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 0,};
            ArrayOperations.InsertAt(array, 10, 1);
            ArrayOperations.RemoveLast(array);
        }
    }
}
