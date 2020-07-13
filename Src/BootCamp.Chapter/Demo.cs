using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    class Demo
    {
        List<int> collection1 = new List<int>() { 1, 2, 3, 6, 7, 11, 12, 14, 18, 20, 93, 104, 144 };
        List<string> collection2 = new List<string>() { "perfectly", "balanced", "as", "all", "things", "should", "be" };
        List<int> collection3 = new List<int>() { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };


        public void DemoOfInBuiltLinqExtensions()
        {
            // Using Any()
            Console.WriteLine($"Collection 1 contains a Odd Integer?: {collection1.Any(Filters.IsNumberOdd)}");
            Console.WriteLine("--------");

            // Using Count()
            Console.WriteLine($"The number of elements in the collections are as follows:");
            Console.WriteLine($"Collection 1: {collection1.Count()}");
            Console.WriteLine($"Collection 2: {collection2.Count()}");
            Console.WriteLine($"Collection 13 {collection3.Count()}");
            Console.WriteLine("--------");

            // Using OrderBy()
            Console.WriteLine($"Re-ordering Collection 1");
            Console.WriteLine("From:");
            CollectionWriter.WriteCollectionToConsole(collection1);
            Console.WriteLine(" ");
            Console.WriteLine("To:");
            CollectionWriter.WriteCollectionToConsole(collection1.OrderBy(Filters.IsNumberEven));
            Console.WriteLine("--------");

            // Using Sets (Union, Intersection, Subtraction)
            Console.WriteLine("Testing Union");
            CollectionWriter.WriteCollectionToConsole(collection1.Union(collection3));
            Console.WriteLine("\n--------\n");
            Console.WriteLine("Testing Intersect");
            CollectionWriter.WriteCollectionToConsole(collection1.Intersect(collection3));
            Console.WriteLine("\n--------\n");
            Console.WriteLine("Testing Subtract (Except)");
            CollectionWriter.WriteCollectionToConsole(collection1.Except(collection3));
        }
    }
}
