using System;

namespace BootCamp.Chapter.Examples.Tuple
{
    public static class TupleDemo
    {
        public static void Run()
        {
            DemoBasicTuple();
            (int a, string b) = DemoTwoValuesReturn();
            DemoNamedTuple();
        }

        public static void DemoBasicTuple()
        {
            var tuple = new Tuple<int, string>(5, "Test");
            Console.WriteLine(tuple);
        }

        public static (int, string) DemoTwoValuesReturn()
        {
            return (5, "Test");
        }

        public static void DemoNamedTuple()
        {
            var named = (Number: 1, Word: "Test");
            Console.WriteLine(named);
            Console.WriteLine($"{named.Number} {named.Word}");
        }
    }
}
