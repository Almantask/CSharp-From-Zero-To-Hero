using BootCamp.Chapter.StudentInfo;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.SchoolInfo
{
    interface ISchool<TStudent, TTeacher, TSubject>
                   where TStudent : IStudent<TTeacher>
                   where TTeacher : ITeacher<TSubject>
                   where TSubject : Subject
    {

    }
}
