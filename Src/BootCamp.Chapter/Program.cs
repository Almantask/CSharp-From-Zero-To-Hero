using System;
using BootCamp.Chapter.Hints;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher<Math> like = new Teacher<Math>();
            like.ProduceMaterial(); //welcome to Math lesson

            var yanan = new Student(123);
            yanan.LearnFrom<Teacher<Math>,Math>(like); //student 123 learn from Math teacher

            List<HighSchoolStudent> list = new List<HighSchoolStudent> { new HighSchoolStudent(1), new HighSchoolStudent(2) };
            var school = new HighSchool(list);
            school.Add(new HighSchoolStudent(3));
            Console.WriteLine(school.Student.Count);  //3

            Student st = school.Get(1);
            Console.WriteLine(st.Id); //1

        }
    }
}
