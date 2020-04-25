using System.Reflection;

namespace BootCamp.Chapter.Examples.Reflection
{
    public static class CallingPriveMethodExample
    {
        public static void Run()
        {
            var dummy = new DummyPrivate();

            DemoStaticNoArgs(dummy);
            DemoInstanceNoArgs(dummy);
            DemoInstanceArgs(dummy);
        }

        private static void DemoStaticNoArgs(DummyPrivate dummy)
        {
            MethodInfo foo = dummy.GetType().GetMethod("Foo", 
                BindingFlags.NonPublic | BindingFlags.Static);
            foo.Invoke(dummy, new object[] { });
        }

        private static void DemoInstanceNoArgs(DummyPrivate dummy)
        {
            MethodInfo bar = dummy.GetType().GetMethod("Bar", BindingFlags.NonPublic | BindingFlags.Instance);
            bar.Invoke(dummy, new object[] { });
        }

        private static void DemoInstanceArgs(DummyPrivate dummy)
        {
            MethodInfo fooBar = dummy.GetType().GetMethod("FooBar", BindingFlags.NonPublic | BindingFlags.Instance);
            fooBar.Invoke(dummy, new object[] {"arg1"});
        }
    }
}
