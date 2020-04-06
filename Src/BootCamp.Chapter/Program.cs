using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool mypredicate(int number) => number <= 4;  
            ShuffleDemo.Demo();
            var list = LinqMethodDemo.Demo(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },mypredicate) ;

            Console.Write("The list after a predicate and cutting it to half looks like: "); 
            foreach (var number in list)
            {
                Console.Write($"{number} "); 
            }
            Console.WriteLine(Environment.NewLine); 
            LinqDemo.Demo(); 


        }
    }
}
