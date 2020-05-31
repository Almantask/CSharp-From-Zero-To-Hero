using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Students;
using ISubject = BootCamp.Chapter.Subjects.ISubject;

namespace BootCamp.Chapter.Teachers
{
    public abstract class TeacherBase<TSubject> : ITeacher<TSubject> where TSubject : ISubject
    {
        public TSubject Subject { get; private set; }
        public string Name { get; }

        protected TeacherBase(string name)
        {
            Name = name;
        }

        public void addLessonNote(TSubject subject)
        {
            Subject = subject;
        }

        public TSubject produceMetarial()
        {
            return Subject;
        }

        public void Teach<TSubject, TStudent, TTeacher>(Schools.ISchool<TStudent> school, TTeacher teacher)
            where TStudent : IStudent

            where TSubject : ISubject
            where TTeacher : ITeacher<TSubject>
        {
            if (school.Students?.Count == 0)
                throw new ArgumentNullException("No stundents to teach!") ??
                      throw new ArgumentException("Student list is null.");

            foreach (TStudent schoolStudent in school.Students)
            {
                schoolStudent.LearnFrom<TTeacher, TSubject>(teacher);
            }
        }
    }
}
