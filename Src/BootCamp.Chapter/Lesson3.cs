using BootCamp.Chapter;
using System;
using System.Collections.Generic;

internal class Lesson3
{
    private static List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    internal static void Demo()
    {
        //Demo the Shuffle method

        Console.Write("Outcome of the shuffle extension method : ");
        var list2 = list1.ShuffleColllectionExtension<int>();
        foreach (var item in list2)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine(Environment.NewLine);
        ;
        //Demo the linq methods

        LinqDemo.Demo();

        //Demo the snapfingers extension method

        static bool mypredicate(int number) => number < 4;
        list2 = list1.SnapFingers<int>(mypredicate);

        Console.Write("Outcome of the snapfingers extensiom method: ");

        foreach (var item in list2)
        {
            Console.Write($"{item} ");
        }
    }
}