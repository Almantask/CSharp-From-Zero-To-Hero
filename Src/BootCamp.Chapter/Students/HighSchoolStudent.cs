using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
    class HighSchoolStudent : IStudent
    {
        public long Id => throw new NotImplementedException();

        List<ISubject> learntSubjects;

        public void GetSubjectsLearnt()
        {
            foreach (ISubject subject in learntSubjects)
            {
                Console.WriteLine(subject.GetMessage());
            }
        }
        public HighSchoolStudent()
        {
            learntSubjects = new List<ISubject>();
        }


        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
            learntSubjects.Add(teacher.ProduceMaterial());
        }
    }
}
