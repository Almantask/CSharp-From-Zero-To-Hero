using System;
using BootCamp.Chapter.Mediator;
using BootCamp.Chapter.Observer;

namespace BootCamp.Chapter
{
    class Program
    {
        public event EventHandler e;

        static void Main(string[] args)
        {
            // MediatorDemo.Run();
            ObserverDemo.Run();
        }
    }
}
