using BootCamp.Chapter.StudentInfo;
using BootCamp.Chapter.Teachers;
using BootCamp.Chapter.Teachers.HighSchool;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new HighSchoolMathsTeacher();
            Console.WriteLine(teacher.ProduceSubjectMaterial());

            var student = new HighSchoolStudent<HighSchoolMathsTeacher>();
            student.LearnFrom(teacher); 
                         
        }
    }
}
