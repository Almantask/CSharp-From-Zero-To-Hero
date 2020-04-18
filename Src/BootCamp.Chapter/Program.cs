using System;
using System.Text;
using BootCamp.Chapter.Examples.CheckPeopleEquality;
using BootCamp.Chapter.Examples.CompareFruits;
using BootCamp.Chapter.Examples.MoneyOperations;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("----People---");
            DemoCheckPeopleEquality.Run();
            Console.WriteLine("----Money----");
            DemoAddOrSubstractMoney.Run();
            Console.WriteLine("----Fruits---");
            CompareFruitsDemo.Run();
        }
    }
}
