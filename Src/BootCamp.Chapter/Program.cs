using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = new string[]{"Hi", Environment.NewLine, "Squirrel"};

            Console.WriteLine("Expecting: 3");
            Console.WriteLine(testArray.Length);
        }
    }
}
