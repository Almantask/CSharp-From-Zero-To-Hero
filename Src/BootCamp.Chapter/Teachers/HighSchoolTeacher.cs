using BootCamp.Chapter.SchoolSubjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    class HighSchoolTeacher<TSubject> : ITeacher<ISubject> where TSubject : ISubject
    {
        string Name { get; }
        private TSubject _Teachings;

        public HighSchoolTeacher(string name, TSubject subject)
        {
            Name = name;
            _Teachings = subject;
        }

        public ISubject ProduceMaterial()
        {
            Console.WriteLine($"{Name}:");
            _Teachings.ProduceMaterial();
            return _Teachings;
        }
    }
}
