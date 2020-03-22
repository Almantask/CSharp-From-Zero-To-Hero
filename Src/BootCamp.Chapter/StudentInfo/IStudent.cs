using BootCamp.Chapter.TeacherInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.StudentInfo
{
    interface IStudent<TTeacher> where TTeacher: Teacher
    {
        void LearnFrom(TTeacher teacher);
    }
}
