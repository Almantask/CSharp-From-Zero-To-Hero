using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    public abstract class HighSchoolTeacher : Teacher<Subject>
    {
        public abstract override Subject ProduceSubjectMaterial();
    }
}
