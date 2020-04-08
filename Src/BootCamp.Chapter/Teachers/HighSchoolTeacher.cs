using BootCamp.Chapter.SchoolSubjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    class HighSchoolTeacher : ITeacher<ISubject>
    {
        string Name { get; }
        private ISubject _Teachings;

        public HighSchoolTeacher(string name, ISubject subject)
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
