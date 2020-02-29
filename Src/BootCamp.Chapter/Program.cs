using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "./Input/b.txt";
         //   var foo = File.ReadAllText(file);   


          //  System.Console.WriteLine(FileCleaner.IsFileClean(foo));
            FileCleaner.Clean(file, "./Input/ttft.txt");

         //   System.Console.WriteLine(foo);
        }
    }
}
