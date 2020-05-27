using System;
using BootCamp.Chapter.Examples;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static IDummyService Service { get; set; }

        public static void Main(string[] args)
        {
            Service?.Foo();
            Console.WriteLine("Hello world!");
        }
    }
}
