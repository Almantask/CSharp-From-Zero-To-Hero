using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
    class Student : IStudent
    {
        private long _Id;
        string Name { get; }
        long IStudent.Id { get { return _Id; } set { _Id = value; } }

        List<ISubject> learntSubjects;

        public Student(string name)
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

        public void LearnFrom(ITeacher<ISubject> teacher)
        {
            learntSubjects.Add(teacher.ProduceMaterial());
        }
    }
}
