using System;
using System.Collections.Generic;
using System.Text;
// ReSharper disable All

namespace BootCamp.Chapter.Examples
{
    public static class NullValueDemo
    {
        public static void Run()
        {
            int? a = null;
            if (a is null)
            {
                // this will be printed.
                Console.WriteLine("a is null.");
            }

            a = 5;
            if (a != null)
            {
                Console.WriteLine($"a has a value of a.Value = {a.Value}" +
                                  $"or a={a}");
            }
        }
    }
}
