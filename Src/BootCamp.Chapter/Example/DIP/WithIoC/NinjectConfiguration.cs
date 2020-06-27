using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Application;
using BootCamp.Chapter.Ref.Repository.InMemory;
using BootCamp.Chapter.Ref.Repository.InMemory.Repositories;
using BootCamp.Chapter.Ref.Repository.Interfaces;
using Ninject;

namespace BootCamp.Chapter.Example.DIP.WithIoC
{
    public static class NinjectConfiguration
    {
        public static ISchoolTerminal InitializeSchoolTerminal()
        {
            var kernel = new StandardKernel();
            kernel.Bind<ISchoolMemoryContext>().To<SchoolMemoryContext>();
            kernel.Bind<ITeachersRepository>().To<TeachersRepository>();
            kernel.Bind<IGradesRepository>().To<GradesRepository>();
            kernel.Bind<ILessonClassesRepository>().To<LessonClassesRepository>();
            kernel.Bind<IStudentsRepository>().To<StudentsRepository>();

            kernel.Bind<ISchoolTerminal>().To<SchoolTerminal>();

            return kernel.Get<ISchoolTerminal>();
        }
    }
}
