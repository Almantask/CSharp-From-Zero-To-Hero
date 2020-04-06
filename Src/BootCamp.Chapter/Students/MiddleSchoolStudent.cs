using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
    class MiddleSchoolStudent : Student
    {

        public MiddleSchoolStudent(string name) : base(name)
        {
        }
        /*
        public long Id;
        string Name { get; }
        List<ISubject> learntSubjects;
        public MiddleSchoolStudent(string name)
        {
            Name = name;
            learntSubjects = new List<ISubject>();
        }
        public void GetSubjectsLearnt()
        {
            Console.WriteLine($"{Name}:");
            foreach (ISubject subject in learntSubjects)
            {
                Console.WriteLine(subject.GetMessage());
            }
        }

        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
            learntSubjects.Add(teacher.ProduceMaterial());
        }*/
    }
}
