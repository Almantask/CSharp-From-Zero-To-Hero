using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public abstract class SchoolBase<TStudent> : ISchool<TStudent> where TStudent : IStudent
    {
        public List<TStudent> Students { get; set; }

        public SchoolBase()
        {
            Students = new List<TStudent>();
        }

        public void AddStudent(TStudent student)
        {
            Students.Add(student);
        }

        public TStudent GetStudentById(long id)
        {
            return (TStudent)Students.Where(s => s.Id == id);
        }
    }
}
