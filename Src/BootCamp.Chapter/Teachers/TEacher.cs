using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    public abstract class Teacher<TSubject> : ITeacher<TSubject> where TSubject : Subject, new()
    { 
        public abstract TSubject ProduceSubjectMaterial();
    }
}
