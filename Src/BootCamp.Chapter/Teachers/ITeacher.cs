using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    interface ITeacher<Subject>
    {
       Subject ProduceSubjectMaterial();
    }
}
