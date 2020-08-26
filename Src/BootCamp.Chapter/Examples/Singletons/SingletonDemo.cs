using System.Threading.Tasks;
using BootCamp.Chapter.Examples.Singletons.Config;
using BootCamp.Chapter.Examples.Singletons.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace BootCamp.Chapter.Examples.Singletons
{
    public static class SingletonDemo
    {
        public static void Run()
        {
            //SpamAccessNestedClass();
            //SpamAccessLazyLoaded();
            //SpamAccessNaive();
            //SpamAccessSimple();

            var serviceProvider = ToDoServiceBuilder.BuildServiceProvider();
            var todoService1 = serviceProvider.GetService<Config.ToDoService>();
            todoService1.Test();
            var todoService2 = serviceProvider.GetService<Config.ToDoService>();
            todoService2.Test();
        }

        private static void SpamAccessNaive()
        {
            Parallel.For(0, 1000, _ =>
            {
                NaiveSingleton singleton = NaiveSingleton.Instance;
            });
        }

        private static void SpamAccessSimple()
        {
            Parallel.For(0, 1000, _ =>
            {
                SimpleSingleton singleton = SimpleSingleton.Instance;
            });
        }

        private static void SpamAccessNestedClass()
        {
            Parallel.For(0, 1000, _ =>
            {
                NestedClassSingleton singleton = NestedClassSingleton.Instance;
            });
        }

        private static void SpamAccessLazyLoaded()
        {
            Parallel.For(0, 1000, _ =>
            {
                LazyLoadedSingleton singleton = LazyLoadedSingleton.Instance;
            });
        }
    }
}
