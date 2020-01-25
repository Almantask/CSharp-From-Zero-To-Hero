using System;

namespace BootCamp.Chapter.Examples
{
    class NullRef
    {
        public static void jj()
        {
            int[] someIntegers = null;
            DoSomething(someIntegers);

            int[] someMoreIntegers = SortOrNull(someIntegers);

            for (int i = 0; i < someMoreIntegers.Length; i++)
            {
                if (someMoreIntegers[i] == someIntegers[i])
                {
                    Console.WriteLine("Yeeeehaw!");
                }
                else
                {
                    Console.WriteLine("Not lucky! :(");
                }
            }
        }
        public static void DoSomething(int[] array)
        {
            if (array[0] == 1)
            {
                array[1] = 2;
            }
            else
            {
                array[3] = 4;
            }
        }

        public static int[] SortOrNull(int[] array)
        {
            return null;
        }
    }
}