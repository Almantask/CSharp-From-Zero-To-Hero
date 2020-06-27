using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Application;
using BootCamp.Chapter.Ref.Repository.InMemory;
using BootCamp.Chapter.Ref.Repository.InMemory.Repositories;
using BootCamp.Chapter.Ref.Repository.Interfaces;
using Unity;

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
    }
}
