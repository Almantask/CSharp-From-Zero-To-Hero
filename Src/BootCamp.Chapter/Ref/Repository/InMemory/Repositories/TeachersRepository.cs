using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Repository.InMemory.Repositories
{
    public class TeachersRepository : Repository<Entities.Teacher, Models.Teacher>, ITeachersRepository
    {
        public TeachersRepository(ISchoolMemoryContext context)
        {
            Context = context.Teachers;
        }
    }
}