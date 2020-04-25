using System;

namespace BootCamp.Chapter.Examples.UnsafeCode
{
    public static class UnsafeCodeDemo
    {
        public static void Run()
        {
            DemoUnsafe();
            PointersExample.Run();
        }

        private static void DemoUnsafe()
        {
            ShortMutableString text = "aello unsafe code!";
            string str = text;

            text[0] = 'H';
            Console.WriteLine(text);
        }
    }
}
