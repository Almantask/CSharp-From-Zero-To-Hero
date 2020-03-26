using BootCamp.Chapter.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers.HighSchool
{
    public class UniversityProgrammingTeacher : UniversityTeacher
    {
        public override Subject ProduceSubjectMaterial()
        {
            return new Programming(); 
        }
    }
}
