using System;
using Method = BootCamp.Chapter.Examples.Demos.Method;
using Query = BootCamp.Chapter.Examples.Demos.Query;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Method syntax--------");
            DemoMethod();
            Console.WriteLine("--------Query  syntax--------");
            DemoQuery();
            Console.WriteLine("--------  Anonymous ---------");
            DemoAnonym();
        }

        private static void DemoMethod()
        {
            Method.SelectDemo.Run();
            Method.SelectManyDemo.Run();
            Method.JoinDemo.Run();
            Method.GroupByDemo.Run();
            Method.GroupJoinDemo.Run();
        }

        private static void DemoQuery()
        {
            Query.SelectDemo.Run();
            Query.SelectManyDemo.Run();
            Query.JoinDemo.Run();
            Query.GroupByDemo.Run();
            Query.GroupJoinDemo.Run();
        }

        private static void DemoAnonym()
        {
            var anonym = FooAnon();
            // { Name = Kaisinel }
            Console.WriteLine(anonym);
        }

        private static object FooAnon()
        {
            var anonym = new { Name = "Kaisinel" };
            return anonym;
        }
    }
}
