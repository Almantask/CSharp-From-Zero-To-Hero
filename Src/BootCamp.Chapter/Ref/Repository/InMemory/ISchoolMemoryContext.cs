using System.Collections.Generic;
using BootCamp.Chapter.Ref.Repository.InMemory.Entities;

namespace BootCamp.Chapter.Ref.Repository.InMemory
{
    public interface ISchoolMemoryContext
    {
        List<Student> Students { get; set; }
        List<Teacher> Teachers { get; set; }
        List<Grade> Grades { get; set; }
        List<LessonClass> Lessons { get; set; }
    }
}