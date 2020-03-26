using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers.HighSchool
{
    public class HighSchoolArtTeacher<Art> : HighSchoolTeacher
    {
        public override Subject ProduceSubjectMaterial()
        {
            return new Art();
        }
    }
}
