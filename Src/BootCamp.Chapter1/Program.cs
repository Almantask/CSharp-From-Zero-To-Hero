namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 10, 2, 3, 6, 5 };
            int[] test = null;
            int[] newArray = ArrayOperations.InsertAt(array,0,5);
            foreach(int i in newArray)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
