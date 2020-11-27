using System;


namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Calculate();
            test.CalculateBMI(new Logger());
        }
    }
}
