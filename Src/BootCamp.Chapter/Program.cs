using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Console.WriteLine(BinaryConverter.ToBinary(5));

            var foo = "0101";
            byte[] bytes = Encoding.Unicode.GetBytes(foo);
            var bar = Encoding.ASCII.GetString(bytes);
           
            Console.WriteLine(bar);
            
         //   Console.WriteLine(aaa);
          //  Console.WriteLine(1/2);

            //  Console.WriteLine(foo = foo % 2);


        }
    }
}
