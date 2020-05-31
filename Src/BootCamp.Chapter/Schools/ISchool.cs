using System.Collections.Generic;

using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public interface ISchool<TStudent> where TStudent : IStudent
    {
        List<TStudent> Students { get; set; }
        void AddStudent(TStudent student);
        TStudent GetStudentById(long id);

    }
}
