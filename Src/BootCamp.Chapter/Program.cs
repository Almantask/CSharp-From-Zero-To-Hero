using System;
using BootCamp.Chapter.Example.DIP.NoIoc;
using BootCamp.Chapter.Example.DIP.WithIoC;
using BootCamp.Chapter.Ref;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // High level depends on abstraction
            ISchoolTerminal app = UnityConfiguration.InitializeSchoolTerminal();
            app.Start();
        }
    }
}