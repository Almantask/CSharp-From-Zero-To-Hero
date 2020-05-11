using System;
using BootCamp.Chapter.Examples;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Randomizer.Instance.Next(5));
        }
    }
}
