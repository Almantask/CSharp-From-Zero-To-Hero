namespace BootCamp.Chapter1
{
    class Program
    {
        static var array = new { 4, 3, 1, 2, 5 };

        static void Main(string[] args)
        {
            PrintArray(array);
            array.Sort();
            PrintArray(array);
        }

        static void PrintArray(int[] ints)
        {
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
        }
    }
}
