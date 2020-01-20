using System;

namespace BootCamp.Chapter
{
    class Conversions
    {
        //These are tests but not sure if supposed to make input from user or just setup
        public static void ConvertToInt()
        {
            Console.WriteLine("Type something and it will be returned as an int.");
            int toAnInt = int.Parse(Console.ReadLine());
            Console.WriteLine($"The converted entry is: {toAnInt}");
        }

        public static void ConvertToString()
        {
            Console.WriteLine("Type something and it will be returned as a string.");
            string toAString = Console.ReadLine();
            Console.WriteLine($"The converted entry is {toAString}");
        }

        public static void ConvertToFloat()
        {
            Console.WriteLine("Type something and it will be returned as a string.");
            float toAFloat = float.Parse(Console.ReadLine());
            Console.WriteLine($"The converted entry is {toAFloat}");
        }
    }
}
