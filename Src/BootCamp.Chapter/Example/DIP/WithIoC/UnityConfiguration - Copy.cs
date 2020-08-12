using System;
using BootCamp.Chapter.Example.DIP.NoIoc;
using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Application;
using BootCamp.Chapter.Ref.Repository.InMemory;
using BootCamp.Chapter.Ref.Repository.InMemory.Repositories;
using BootCamp.Chapter.Ref.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Unity;
using Unity.Injection;

namespace BootCamp.Chapter.Example.DIP.WithIoC
{
    public static class MicrosoftContainerConfiguration
    {
        public static ISchoolTerminal InitializeSchoolTerminal()
        {
            var services = new ServiceCollection();

            services.AddTransient<ISchoolMemoryContext, SchoolMemoryContext>();
            services.AddTransient<ITeachersRepository, TeachersRepository>();
            services.AddTransient<IGradesRepository, GradesRepository>();
            services.AddTransient<ILessonClassesRepository, LessonClassesRepository>();
            services.AddTransient<IStudentsRepository, StudentsRepository>();

            services.AddTransient<ISchoolTerminal, SchoolTerminal>();

            var provider = services.BuildServiceProvider();

            return provider.GetService<ISchoolTerminal>();
        }

        interface IFoo
        {

        }

        class Foo : IFoo
        {

        }

        private static ServiceCollection collection = new ServiceCollection();

        private static void DemoTransient() => collection.AddTransient<IFoo, Foo>();
        private static void DemoScoped() => collection.AddScoped<IFoo, Foo>();
        private static void DemoSingleton() => collection.AddSingleton<IFoo, Foo>();
    }
}
