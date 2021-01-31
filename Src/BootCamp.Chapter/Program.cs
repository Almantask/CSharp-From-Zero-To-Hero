using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.OutputEncoding = Encoding.UTF8;

            //char number = ArrowMovement.GetIndicator('W');
            //char number = ArrowMovement.GetIndicator('w');
            //char number = ArrowMovement.GetIndicator('A');
            //char number = ArrowMovement.GetIndicator('a');
            //char number = ArrowMovement.GetIndicator('S');
            char number = ArrowMovement.GetIndicator('s');
            //char number = ArrowMovement.GetIndicator('D');
            //char number = ArrowMovement.GetIndicator('d');

            //char number = ArrowMovement.GetIndicator('C');
            //char number = ArrowMovement.GetIndicator('c');

            Console.WriteLine(number);
        }
    }
}