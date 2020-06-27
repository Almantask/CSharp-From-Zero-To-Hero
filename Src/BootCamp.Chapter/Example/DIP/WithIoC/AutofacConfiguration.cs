using Autofac;
using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Application;
using BootCamp.Chapter.Ref.Repository.InMemory;
using BootCamp.Chapter.Ref.Repository.InMemory.Repositories;
using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Example.DIP.WithIoC
{
    internal static class AutofacConfiguration
    {
        public static ISchoolTerminal InitializeSchoolTerminal()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TeachersRepository>().As<ITeachersRepository>();
            builder.RegisterType<SchoolMemoryContext>().As<ISchoolMemoryContext>();
            builder.RegisterType<GradesRepository>().As<IGradesRepository>(); 
            builder.RegisterType<LessonClassesRepository>().As<ILessonClassesRepository>(); 
            builder.RegisterType<StudentsRepository>().As<IStudentsRepository>(); 

            builder.RegisterType<SchoolTerminal>().As<ISchoolTerminal>(); 

             var container = builder.Build();

            return container.Resolve<ISchoolTerminal>();
        }
    }
}
