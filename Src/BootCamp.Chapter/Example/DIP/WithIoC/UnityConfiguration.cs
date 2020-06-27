using System;
using BootCamp.Chapter.Example.DIP.NoIoc;
using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Application;
using BootCamp.Chapter.Ref.Repository.InMemory;
using BootCamp.Chapter.Ref.Repository.InMemory.Repositories;
using BootCamp.Chapter.Ref.Repository.Interfaces;
using Unity;
using Unity.Injection;

namespace BootCamp.Chapter.Example.DIP.WithIoC
{
    public static class UnityConfiguration
    {
        public static ISchoolTerminal InitializeSchoolTerminal()
        {
            var container = new UnityContainer();
            container.RegisterType<ISchoolMemoryContext, SchoolMemoryContext>();
            container.RegisterType<ITeachersRepository, TeachersRepository>();
            container.RegisterType<IGradesRepository, GradesRepository>();
            container.RegisterType<ILessonClassesRepository, LessonClassesRepository>();
            container.RegisterType<IStudentsRepository, StudentsRepository>();

            container.RegisterType<ISchoolTerminal, SchoolTerminal>();

            return container.Resolve<ISchoolTerminal>();
        }

        interface IFoo
        {

        }

        class Foo : IFoo
        {

        }

        private static UnityContainer _container;

        private static void DemoTransient() => 
            _container.RegisterType<IFoo, Foo>();

        private static void DemoScoped() =>
            _container.RegisterType<IFoo, Foo>(TypeLifetime.PerResolve);

        private static void DemoSingleton() =>
            _container.RegisterType<IFoo, Foo>(TypeLifetime.Singleton);

        private static void DemoDelegate() => 
            _container.RegisterType<Write>(new InjectionFactory(i => new Write(Console.Write)));
    }
}
