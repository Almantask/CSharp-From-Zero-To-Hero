using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryConverter.ToBinary(512));
            Console.WriteLine(BinaryConverter.ToInteger("10101"));

            Console.OutputEncoding = System.Text.Encoding.Unicode; // Just for testing ArrowMovement.GetIndicator
            Console.WriteLine(ArrowMovement.GetIndicator(Console.ReadKey(true).KeyChar)); 
        }
    }
}
