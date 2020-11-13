namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            int[] test = null;
            int[] newArray = ArrayOperations.InsertLast(test,0);
            foreach (int i in newArray)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
