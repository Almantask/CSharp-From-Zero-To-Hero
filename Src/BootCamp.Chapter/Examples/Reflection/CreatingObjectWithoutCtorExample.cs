using System;
using System.Linq.Expressions;
using System.Reflection;

namespace BootCamp.Chapter.Examples.Reflection
{
    public static class CreatingObjectWithoutCtorExample
    {
        public static void Run()
        {
            CreateUsingActivator();
            CreateUsingCompiledLambda();
        }

        private static void CreateUsingActivator()
        {
            var dummy1 = Activator.CreateInstance<DummyPrivate>();
            var dummy2 = Activator.CreateInstance(typeof(DummyPrivate), "Test") as DummyPrivate;
            Console.WriteLine(dummy1);
            Console.WriteLine(dummy2);
        }

        private static void CreateUsingCompiledLambda()
        {
            var dummyType = typeof(DummyPrivate);
            // Take ctor
            var dummyCtor = dummyType.GetConstructor(new Type[0]);
            // Compile creation expression so it's fast to reuse later.
            var delegateWithConstructor = Expression.Lambda(Expression.New(dummyCtor)).Compile();
            // call ctor.
            var dummy = delegateWithConstructor.DynamicInvoke() as DummyPrivate;

            Console.WriteLine(dummy);
        }
    }
}
