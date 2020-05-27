using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples
{
    public interface IDummyService
    {
        void Foo();
    }

    public class DummyService : IDummyService
    {
        public void Foo()
        {
            Console.WriteLine("Bar");
        }
    }

}
