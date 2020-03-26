using BootCamp.Chapter.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers.HighSchool
{
    public class UniversitySchoolEnglishTeacher : UniversityTeacher
    {
        public override Subject ProduceSubjectMaterial()
        {
            return new English();
        }
    }
}
