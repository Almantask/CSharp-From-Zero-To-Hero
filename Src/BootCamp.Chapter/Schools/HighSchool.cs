using System.Collections.Generic;
using BootCamp.Chapter.Hints;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class HighSchool : ISchool<HighSchoolStudent, HighSchoolStudent>
    {
        private readonly List<HighSchoolStudent> _students = new List<HighSchoolStudent>();
        
        public void AddStudent(HighSchoolStudent student)
        {
            _students.Add(student);
        }

        public List<HighSchoolStudent> GetStudents()
        {
            return _students;
        }
    }
}