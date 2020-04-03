using BootCamp.Chapter.SchoolSubjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    interface ITeacher<TSubject> where TSubject : ISubject
    {
        // TODO teacher produces material from subject.
        TSubject ProduceMaterial();
    }
}
