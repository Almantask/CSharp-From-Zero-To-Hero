using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    internal static class ShuffleDemo
    {
        internal static void Demo()
        {
            var shuffledList = ShuffleColllectionExtension(new List<int> { 1, 2, 3, 4, 5 });
            Console.Write("The shuffled List looks like this: ");
            foreach (var item in shuffledList)
            {
                Console.Write($"{ item} ");
            }
            Console.WriteLine(Environment.NewLine); 
        }

        private static IEnumerable<T> ShuffleColllectionExtension<T>(this IEnumerable<T> list)
        {
            var random = new Random();
            var buffer = list.ToList();
            var size = buffer.Count();
            for (int i = 0; i < size; i++)
            {
                var newPosition = random.Next(0, size);
                // here I swap items but first I have to store a old value somewhere befor its going to be overwritten 
                var tmp = buffer[newPosition];
                buffer[newPosition] = buffer[i];
                buffer[i] = tmp;
            }

            return buffer;
        }
    }
}