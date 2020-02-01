using System;
namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            arr[0] = 2;
            arr[1] = 0;
            arr[2] = 1;
            ArrayOperations.Reverse(arr);
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
