using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.StudentInfo
{
    interface IStudent<TTeacher>
    {
        void LearnFrom(TTeacher teacher);
    }
}
