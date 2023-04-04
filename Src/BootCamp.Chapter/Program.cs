using System;
using BootCamp.Chapter.Hints;
using BootCamp.Chapter.Schools;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Programming();
            var teacher = new UniversityTeacher(subject);
            teacher.ProduceMaterial();

            var student = new UniversityStudent(1);
            student.LearnFrom<UniversityTeacher, ISubject>(teacher);
            var student2 = new UniversityStudent(2);
            student.LearnFrom<UniversityTeacher, ISubject>(teacher);

            var school = new University();
            school.AddStudent(student);
            school.AddStudent(student2);

            var students = school.GetStudents();
            Console.WriteLine($"School has {students.Count} students");
        }
    }
}
