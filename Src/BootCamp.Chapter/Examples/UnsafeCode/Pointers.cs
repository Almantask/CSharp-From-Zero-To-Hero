using System;

namespace BootCamp.Chapter.Examples.UnsafeCode
{
    public static class PointersExample
    {
        // Taken from: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types
        public static void Run()
        {
            DemoPointerRef();
            DemoPointerToArray();
        }

        private static unsafe void DemoPointerRef()
        {
// Normal pointer to an object.
            int[] a = {10, 20, 30, 40, 50};
            // Must be in unsafe code to use interior pointers.
            unsafe
            {
                // Must pin object on heap so that it doesn't move while using interior pointers.
                // p points to the start of array a.
                fixed (int* p = &a[0])
                {
                    // p is pinned as well as object, so create another pointer to show incrementing it.
                    // p2 points to p, which points to the start of array.
                    int* p2 = p;
                    Console.WriteLine(*p2);
                    // Incrementing p2 bumps the pointer by four bytes due to its type ...
                    // ... which makes it point to the next element in array.
                    p2 += 1;
                    Console.WriteLine(*p2);
                    // Bump again- pointing to the 3rd element now.
                    p2 += 1;
                    Console.WriteLine(*p2);
                    Console.WriteLine("--------");
                    Console.WriteLine(*p);
                    // Dereferencing p and incrementing changes the value of a[0] ...
                    *p += 1;
                    Console.WriteLine(*p);
                    *p += 1;
                    Console.WriteLine(*p);
                    // ... note that *p is not the same as p.
                    p2 += 1;
                    // 4th element
                    Console.WriteLine(*p2);
                    p2 += 1;
                    // 5th element
                    Console.WriteLine(*p2);
                    *p2 += 1;
                    // 51
                    Console.WriteLine(*p2);
                    // p += 1; - does not compile.
                }
            }

            Console.WriteLine("--------");
            Console.WriteLine(a[0]);
        }

        private static unsafe void DemoPointerToArray()
        {
            // Normal pointer to an object.
            int[] a = { 10, 20, 30, 40, 50 };
            // Must be in unsafe code to use interior pointers.
            unsafe
            {
                // Must pin object on heap so that it doesn't move while using interior pointers.
                // p points to the start of array a.
                fixed (int* p = a)
                {
                    Console.WriteLine(*(p + 4));
                    // p is pinned as well as object, so create another pointer to show incrementing it.
                    // p2 points to p, which points to the start of array.
                    int* p2 = p;
                    Console.WriteLine(*p2);
                    // Incrementing p2 bumps the pointer by four bytes due to its type ...
                    // ... which makes it point to the next element in array.
                    p2 += 1;
                    Console.WriteLine(*p2);
                    // Bump again- pointing to the 3rd element now.
                    p2 += 1;
                    Console.WriteLine(*p2);
                    Console.WriteLine("--------");
                    Console.WriteLine(*p);
                    // Dereferencing p and incrementing changes the value of a[0] ...
                    *p += 1;
                    Console.WriteLine(*p);
                    *p += 1;
                    Console.WriteLine(*p);
                    // ... note that *p is not the same as p.
                    p2 += 1;
                    // 4th element
                    Console.WriteLine(*p2);
                    p2 += 1;
                    // 5th element
                    Console.WriteLine(*p2);
                    *p2 += 1;
                    // 51
                    Console.WriteLine(*p2);
                    // p += 1; - does not compile.
                }
            }

            Console.WriteLine("--------");
            Console.WriteLine(a[0]);
        }
    }
}
