using System;
namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            arr[0] = 3;
            arr[1] = 1;
            ArrayOperations.InsertLast(arr, 222);
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
