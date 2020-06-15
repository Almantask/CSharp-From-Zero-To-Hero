using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Demos
{
    public class DemoMostCommonLetterFinder
    {
        public static void Demo()
        {
            string sentence = "This is a test sentence with a ton of t-s inside of it.";
            Console.WriteLine(sentence);
            Console.WriteLine($"The most common letter in the above sentence is: {MostCommonLetterFinder.Find(sentence)}");
        }
    }
}
