using System;
using BootCamp.Chapter.Exceptions;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null || args.Length < 2 || args.Length > 3)
            {
                Console.WriteLine("Invalid format");
                Console.WriteLine("\"path/to/input\" \"full\"");
                Console.WriteLine("\"path/to/input\" \"command\" \"path/to/output\"");
                Console.WriteLine("Commands: city, time, daily");
                throw new InvalidCommandException();
            }

            if (args.Length == 2)
            {
                ArgumentReader.ReadTwoArgs(args);
            }
            else
            {
                ArgumentReader.ReadThreeArgs(args);
            }
        }
    }
}
