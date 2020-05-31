using System;
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
            University<UniversityStudent> university = new University<UniversityStudent>();
            HighSchool<HighSchoolStudent> highSchool = new HighSchool<HighSchoolStudent>();

            UniversityTeacher<ProgrammingSubject> programmingTeacher = new UniversityTeacher<ProgrammingSubject>("Professor McGill");

            UniversityStudent universityStudent1 = new UniversityStudent(1);
            UniversityStudent universityStudent2 = new UniversityStudent(2);

            HighSchoolStudent highSchoolStudent1 = new HighSchoolStudent(1);

            university.AddStudent(universityStudent1);
            university.AddStudent(universityStudent2);

            programmingTeacher.addLessonNote(new ProgrammingSubject("Generics"));

            programmingTeacher.Teach<ProgrammingSubject, UniversityStudent,UniversityTeacher<ProgrammingSubject>>(university, programmingTeacher);
        }
    }
}
