using BootCamp.Chapter.SchoolSubjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    interface ITeacher< out TSubject> where TSubject : ISubject
    {
        TSubject ProduceMaterial();
    }
}
