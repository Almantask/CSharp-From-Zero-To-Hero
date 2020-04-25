using System;

namespace BootCamp.Chapter.Examples.Reflection
{
    public class DummyPrivate
    {
        public string Id { get; }
        public DummyPrivate()
        {
            Id = Guid.NewGuid().ToString();
        }

        public DummyPrivate(string id)
        {
            Id = id;
        }
        private static void Foo()
        {
            Console.WriteLine("Foo");
        }
        private void Bar()
        {
            Console.WriteLine("Bar");
        }
        private void FooBar(string arg)
        {
            Console.WriteLine("FooBar " + arg);
        }
        public override string ToString() => Id;
    }
}