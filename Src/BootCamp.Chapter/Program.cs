
using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Running");
            // test inputs:
            // "C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv" "time 09:00-22:00" "C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\"
            if (args != null)
            {
                ApplicationController applicationController = new ApplicationController(args);
                applicationController.Run();
            }
        }
    }
}