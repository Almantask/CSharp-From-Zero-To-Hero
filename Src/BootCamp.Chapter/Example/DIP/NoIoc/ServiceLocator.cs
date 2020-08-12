using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Application;
using BootCamp.Chapter.Ref.Repository.InMemory;
using BootCamp.Chapter.Ref.Repository.InMemory.Repositories;

namespace BootCamp.Chapter.Example.DIP.NoIoc
{
    public class ServiceLocator
    {
        public ISchoolTerminal Terminal { get; }
        public static ServiceLocator Instance => _instance ??= new ServiceLocator();
        private static ServiceLocator _instance;


        private ServiceLocator()
        {
            var context = new SchoolMemoryContext();

                ISchoolTerminal app = new SchoolTerminal(
                    new StudentsRepository(context),
                    new TeachersRepository(context),
                    new GradesRepository(context),
                    new LessonClassesRepository(context));

                Terminal = app;
        }
    }
}
