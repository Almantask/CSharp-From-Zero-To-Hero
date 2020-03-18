using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples
{
    public static class TernaryDemo
    {
        public static void Run()
        {
            var max1 = Max1(1, 2);
            var max2 = Max2(1, 2);

            Console.WriteLine($"Max1 = {max1}, Max2 = {max2}.");
        }

        private static int Max2(int a, int b)
        {
            return a > b ? a : b;
        }

        private static int Max1(int a, int b)
        {
            int bigger;
            if (a > b)
            {
                bigger = a;
            }
            else
            {
                bigger = b;
            }

            return bigger;
        }
    }
}
