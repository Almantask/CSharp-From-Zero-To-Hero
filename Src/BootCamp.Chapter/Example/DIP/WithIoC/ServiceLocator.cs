using BootCamp.Chapter.Ref;
using BootCamp.Chapter.Ref.Application;
using BootCamp.Chapter.Ref.Repository.InMemory;
using BootCamp.Chapter.Ref.Repository.InMemory.Repositories;
using BootCamp.Chapter.Ref.Repository.Interfaces;
using Unity;

namespace BootCamp.Chapter.Example.DIP.WithIoC
{
    public interface IService
    {
    }

    public class ServiceLocator
    {
        public TService Resolve<TService>() where TService : IService
            => _container.Resolve<TService>();

        public static ServiceLocator Instance => _instance ??= new ServiceLocator();
        private static ServiceLocator _instance;
        private UnityContainer _container;


        private ServiceLocator()
        {
            _container = new UnityContainer();

            _container.RegisterType<ISchoolMemoryContext, SchoolMemoryContext>();
            _container.RegisterType<ITeachersRepository, TeachersRepository>();
            _container.RegisterType<IGradesRepository, GradesRepository>();
            _container.RegisterType<ILessonClassesRepository, LessonClassesRepository>();
            _container.RegisterType<IStudentsRepository, StudentsRepository>();

            _container.RegisterType<ISchoolTerminal, SchoolTerminal>();
        }
    }
}
