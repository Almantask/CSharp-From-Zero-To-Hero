using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    interface ITeacher<out TSubject> where TSubject : ISubject
    {
        public string Name { get; }
        public TSubject SubjectTaught { get; }
        TSubject ProduceTeachingMaterial();   
    }
}
