using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.StudentInfo
{
    class MiddleSchoolStudent<TTeacher> : IStudent<TTeacher> where TTeacher : MiddleSchoolTeacher
    {
        public void LearnFrom(TTeacher teacher)
        {
            Console.WriteLine($"I learn something from my {teacher}");
        }
    }
}
