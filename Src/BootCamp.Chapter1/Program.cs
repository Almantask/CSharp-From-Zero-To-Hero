using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array=new int[] {1,0,2,-1,3 };
            //int[] testArray = new int[10];
            ArrayOperations.Reverse(array);
           // Console.WriteLine(testArray.Length.ToString());
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
