using BootCamp.Chapter.Ref.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCamp.Chapter.Example.NotDip.JustCodingToAnInterface
{
    // We're still coupled with infrastructure (EF's DbSet)
    // The only benifit this gives us is a way of slightly easier testing.
    // Not everything must be unit tested. In this case I'd stick with no interface (and integration tests)
    // Because we don't escape a dependency and it is fine, because we are using EF to implement feature X.
    public interface ISchoolMemoryContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Grade> Grades { get; set; }
        DbSet<LessonClass> Lessons { get; set; }
    }

    public class SchoolMemoryContext : ISchoolMemoryContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<LessonClass> Lessons { get; set; }
    }
}
