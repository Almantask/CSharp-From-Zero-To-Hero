using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples
{
    public interface ICollection1<T>
    {
        void Add(T item);
    }

    public class ArrayCollection<T> : ICollection1<T>
    {
        public void Add(T item)
        {
            throw new NotSupportedException("Collection is of fixed size.");
        }
    }

    public class ListCollection<T> : ICollection1<T>
    {
        private readonly List<T> _collection = new List<T>();

        public void Add(T item)
        {
            _collection.Add(item);
        }
    }


    public static class NetFrameworkLspViolationDemo
    {
        public static void Run()
        {
            ICollection1<string> listCollection = new ListCollection<string>();
            listCollection.Add("Hello");

            ICollection1<string> arrayCollection = new ArrayCollection<string>();
            arrayCollection.Add("Hello");
        }
    }
}
