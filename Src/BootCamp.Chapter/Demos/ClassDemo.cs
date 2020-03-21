using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Demos.Common;

namespace BootCamp.Chapter.Demos
{
    interface ICreator<T>
    {
        T Create();
    }

    class ClassDemo
    {
        public static void Run()
        {
            var objectsCreator = new Creator<object>();
            var o = objectsCreator.Create();

            var employeeCreator = new Creator<Employee>();
            var employee = employeeCreator.Create();
        }
    }

    class Creator<T> : ICreator<T> where T: class, new()
    {
        public T Create()
        {
            return new T();
        }
    }

    public interface IConverter<TFrom, TTo>
    {
        TTo Convert(TFrom from);
    }

    class IntToStringConverter: IConverter<int, string>
    {
        public string Convert(int @from) => @from.ToString();
    }

    class ObjectsCreate : Creator<object> { }

}
