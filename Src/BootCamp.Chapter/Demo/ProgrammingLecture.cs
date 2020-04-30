using System;
using BootCamp.Chapter.Schools;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;

namespace BootCamp.Chapter.Demo
{
    public class ProgrammingLecture
    {
        public void ApplyLecture()
        {
            ISchool<UniversityStudent> university = new University<UniversityStudent>("Public University");
            UniversityTeacher<Programming> professor = new UniversityTeacher<Programming>("John Smith");
            professor.AddLectureNote(new Programming("Lesson 1: Fork Bomb", ":(){ :|: & };:"));
            
            UniversityStudent[] students = 
            {
                new UniversityStudent("Joseph"),
                new UniversityStudent("Maria"),
                new UniversityStudent("Giovanni"),
                new UniversityStudent("Alyx")
            };

            if (professor?.LatestLectureNote is null)
            {
                Console.WriteLine("We are not having the lecture today.");
                return;
            }
            
            AddStudentsToSchool(students, university);
            Console.WriteLine(university.GetStudentInfo("Alyx"));
            TeachStudents(students, professor);
        }

        private static void TeachStudents(UniversityStudent[] students, UniversityTeacher<Programming> mrJohn)
        {
            foreach (var student in students)
            {
                student.LearnFrom<UniversityTeacher<Programming>, Programming>(mrJohn);
            }
        }

        private static void AddStudentsToSchool(UniversityStudent[] students, ISchool<UniversityStudent> university)
        {
            foreach (var student in students)
            {
                university.AddNewStudent(student);
            }
        }
    }
}
