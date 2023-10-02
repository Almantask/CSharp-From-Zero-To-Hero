using System;
using System.Net.Http.Headers;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1};
            foreach (var num in array)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine(Environment.NewLine);
           ArrayOperations.Reverse(array);

            foreach(var num in array)
            {
                Console.Write(num + ",");
            }

        }
    }
}
