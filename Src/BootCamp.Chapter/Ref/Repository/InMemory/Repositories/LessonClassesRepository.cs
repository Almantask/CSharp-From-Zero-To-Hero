using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Repository.InMemory.Repositories
{
    public class LessonClassesRepository: Repository<Entities.LessonClass, Models.LessonClass>, ILessonClassesRepository
    {
        public LessonClassesRepository(ISchoolMemoryContext context)
        {
            Context = context.Lessons;
        }
    }
}
