using System;


namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var test = new Calculate();
            test.ProcessData(new FileLogger(random.Next()));
            test.ProcessData(new ConsoleLogger());
        }
    }
}
