using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    public abstract class MiddleSchoolTeacher : Teacher<Subject>
    {
        public abstract override Subject ProduceSubjectMaterial(); 
    }
}
