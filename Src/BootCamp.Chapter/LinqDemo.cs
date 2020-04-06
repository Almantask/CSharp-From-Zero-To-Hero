using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class LinqDemo
    {
        internal static void Demo()
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var list2 = new List<int> { 1, 11, 12 };
            var list3 = new List<int> { 4, 2, 5, 4 };

            // Any. so Im going to check if any number in list1 is even.
            var valid = list1.Any(n => n % 2 == 0);

            if (valid)
            {
                Console.WriteLine($"The list does contain a even number{Environment.NewLine}");
            }
            else
            {
                Console.WriteLine("The list does not contain a even number");
            }

            // Count. So we are going to count how many even numbers there are in list1. 
            var count = list1.Count(n => n % 2 == 0);
            Console.WriteLine($"There are {count} even numbers in list1{Environment.NewLine}");

            // now we are going to sort list3  

            var sortedList = list3.OrderBy(n => n);
            Console.Write("List3 sorted looks like this: ");
            PrintList(sortedList); 

            // now we are going to select all numbers under the 6 on list1
            Console.Write("All numbers under the 6 of list 1 looks like: ");
            var selectedList = list1.Where(n => n < 6);
            PrintList(selectedList); 

            // here we make a union of set1 and set2 so it will contain the numbers from 1 till 12
            Console.Write("The union of list1 and list2 looks like this: ");
            var unionList = list1.Union(list2);
            PrintList(unionList); 

            // now we are going to make a intersecion of list1 and list2
            Console.Write("The intersection of list1 and list2 looks like this: ");
                        var intersectedList = list1.Intersect(list2);
            PrintList(intersectedList);

            // now we are going to make a substraction of list1 and list2
            Console.Write("The intersection of list1 and list2 looks like this: ");
            var substractedList = list1.Except(list2);
            PrintList(substractedList); 


        }

        private static void PrintList(IEnumerable<int> list)
        {
            foreach (var number in list)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}