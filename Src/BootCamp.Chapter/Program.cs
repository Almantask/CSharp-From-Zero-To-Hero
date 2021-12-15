using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Honda", "X 1.0T");
            var testt = TextBoxPrinter.Print(car1);

            var item = new Item("test");
            var text = TextBoxPrinter.Print(item);

            Console.WriteLine(testt);
            Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
