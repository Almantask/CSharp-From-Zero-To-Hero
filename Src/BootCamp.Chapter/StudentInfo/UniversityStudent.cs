using BootCamp.Chapter.SchoolInfo;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.StudentInfo
{
    class UniversityStudent<TTeacher> : IStudent<TTeacher> where TTeacher : UniversityTeacher
    {
        public TId Id { get;  set; }

        public void LearnFrom(TTeacher teacher)
        {
            Console.WriteLine($"I learn something from my {teacher}");
        }
    }
}
