using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Please input first name: ");
         var name = Console.ReadLine();
         Console.Write("Please input last name: ");
         var surname = Console.ReadLine();
         Console.Write("Please input age: ");
         var age = Console.ReadLine();
         Console.Write("Please input weight: ");
         var weight = Console.ReadLine();
         Console.Write("Please input height: ");
         var height = Console.ReadLine();
         

         Console.WriteLine(name +" "+ surname + " is "+ age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

        }
    }
}
