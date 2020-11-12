using BootCamp.Chapter.Interface;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public class School<T> : ISchool<IStudent>
    {
        List<ITeacher<ISubject>> teachers = new List<ITeacher<ISubject>>();

        public void AddTeacher(ITeacher<ISubject> teacher)
        {
            teachers.Add(teacher);
        }

        public ITeacher<ISubject> GetTeacher(ISubject subject)
        {
            return teachers.Where(x => x.ProduceMaterial().ToString() == subject.ToString()).FirstOrDefault();
        }
    }
}
