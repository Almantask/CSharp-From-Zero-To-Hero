using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            // Tests of the Custom Shuffle Extension
            List<int> testListInt = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<string> testListString = new List<string>() { "perfectly", "balanced", "as", "all", "things", "should", "be" };

            Console.WriteLine("Without Shuffle Extension");
            CollectionWriter.WriteCollectionToConsole(testListInt);

            Console.WriteLine("With Shuffle Extension");
            CollectionWriter.WriteCollectionToConsole(LINQExtensions.Shuffle(testListInt));

            Console.WriteLine("\n\nSnap Fingers Int");

            CollectionWriter.WriteCollectionToConsole(SnapFingersLINQ.SnapFingers(testListInt));

            Console.WriteLine("\n\nSnap Fingers String");

            CollectionWriter.WriteCollectionToConsole(SnapFingersLINQ.SnapFingers(testListString));

            Console.WriteLine("w/ Predicate");
            CollectionWriter.WriteCollectionToConsole(SnapFingersLINQ.SnapFingers(testListInt, Filters.IsNumberEven));


            // Test of the Demo
            Console.WriteLine("\n\nRunning The Demo\n\n");
            Demo demo = new Demo();
            demo.DemoOfInBuiltLinqExtensions();
        }  
    }
}
