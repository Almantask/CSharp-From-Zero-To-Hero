using System;

namespace BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.Your
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
