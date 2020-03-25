using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    public abstract class Teacher<TSubject> : ITeacher<TSubject> where TSubject : Subject
    {
        public abstract TSubject ProduceSubjectMaterial();
    }
}
