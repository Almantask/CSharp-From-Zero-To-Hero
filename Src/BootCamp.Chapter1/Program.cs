namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 10, 2, 3, 6, 5 };
            int[] test = null;
            ArrayOperations.Sort(array);
            foreach(int i in array)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
