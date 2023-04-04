using System.Collections.Generic;
using BootCamp.Chapter.Hints;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class University : ISchool<UniversityStudent, UniversityStudent>
    {
        private readonly List<UniversityStudent> _students = new List<UniversityStudent>();
        
        public void AddStudent(UniversityStudent student)
        {
            _students.Add(student);
        }

        public List<UniversityStudent> GetStudents()
        {
            return _students;
        }
    }
}