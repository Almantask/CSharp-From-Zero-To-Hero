using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.StudentInfo
{
    class HighSchoolStudent<TTeacher> : IStudent<TTeacher> where TTeacher : HighSchoolTeacher
    {
        public void LearnFrom(TTeacher teacher)
        {
            Console.WriteLine($"I learn something from my {teacher}");
        }
    }

}
