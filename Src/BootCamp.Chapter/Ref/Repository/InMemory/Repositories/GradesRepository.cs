using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Repository.InMemory.Repositories
{
    public class GradesRepository : Repository<Entities.Grade, Models.Grade>, IGradesRepository
    {
        public GradesRepository(ISchoolMemoryContext context)
        {
            Context = context.Grades;
        }
    }
}
