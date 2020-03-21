using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Demos
{
    class MethodDemo
    {
        public static void Demo()
        {
            Add(1);
            Add("");
            Add(default(object));
        }


        public static void Add<T>(T item)
        {
        }
    }
}
