using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Repository.InMemory.Repositories
{
    public class StudentsRepository: Repository<Entities.Student, Models.Student>, IStudentsRepository
    {
        public StudentsRepository(ISchoolMemoryContext context)
        {
            Context = context.Students;
        }
    }
}
