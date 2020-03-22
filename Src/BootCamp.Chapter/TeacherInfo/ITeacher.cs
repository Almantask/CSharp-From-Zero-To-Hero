using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.TeacherInfo
{
    interface ITeacher<TSubjectMaterial>
    {
         TSubjectMaterial ProduceSubjectMaterial();
    }
}
