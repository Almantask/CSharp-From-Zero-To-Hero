namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void PrintArray(int[] array)
        {
            System.Console.WriteLine($"Length: {array.Length}");
            foreach(var element in array)
            {
                System.Console.Write(element + " ");
                
            }
            System.Console.WriteLine();
        }
    }
}
