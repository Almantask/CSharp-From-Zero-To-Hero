using BootCamp.Chapter.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers.HighSchool
{
    public class HighSchoolPETeacher : HighSchoolTeacher
    {
        public override Subject ProduceSubjectMaterial()
        {
            return new PE();
        }
    }
}
