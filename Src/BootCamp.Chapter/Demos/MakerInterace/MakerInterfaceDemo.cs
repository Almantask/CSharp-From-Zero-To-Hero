using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Demos.MakerInterace
{
    public interface IFactoryItem { }

    public class Car : IFactoryItem { }
    public class Human : IFactoryItem { }

    public class Factory
    {
        public T Create<T>() where T : IFactoryItem, new()
        {
            return new T();
        }
    }


    public static class MakerInterfaceDemo
    {
        public static void Run()
        {

        }
    }
}
