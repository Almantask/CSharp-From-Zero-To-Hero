using BootCamp.Chapter.SchoolInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.StudentInfo
{
    class UniversityStudent : IStudent<University>
    {
        public void LearnFrom(University teacher)
        {
            Console.WriteLine("Learn something on the university");
        }
    }
}
