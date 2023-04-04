using System.Collections.Generic;
using BootCamp.Chapter.Hints;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class MiddleSchool : ISchool<MiddleSchoolStudent, MiddleSchoolStudent>
    {
        private readonly List<MiddleSchoolStudent> _students = new List<MiddleSchoolStudent>();
        
        public void AddStudent(MiddleSchoolStudent student)
        {
            _students.Add(student);
        }

        public List<MiddleSchoolStudent> GetStudents()
        {
            return _students;
        }
    }
}