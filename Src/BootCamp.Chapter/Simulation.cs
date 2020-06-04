using BootCamp.Chapter.Schools;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;
using System;

namespace BootCamp.Chapter
{
    public class Simulation
    {
        public static void Run()
        {
            ISchool<UniversityStudent> university = new University<UniversityStudent>("Massachusetts Institute of Technology", "Cambridge, Massachusetts, United States");
            var universitySubject = new Programming("Generics: Covariance & Contravariance", "Basics of Generics, and the usage of covariance and contravariance when working with them.");
            UniversityTeacher<Programming> universityTeacher = new UniversityTeacher<Programming>("Kaisinnel", universitySubject);

            UniversityStudent[] universityStudents = new UniversityStudent[]
            {
                new UniversityStudent("Fat Mike"),
                new UniversityStudent("Big Joe"),
                new UniversityStudent("Tiny Tina"),
                new UniversityStudent("Mad Moxxy")
            };

            RegisterStudentsToSchool(universityStudents, university);
            TeachStudents(universityTeacher, universityStudents);
        }

        private static void RegisterStudentsToSchool(UniversityStudent[] universityStudents, ISchool<UniversityStudent> university)
        {
            foreach (var student in universityStudents)
            {
                university.RegisterStudent(student);
            }
        }

        private static void TeachStudents(UniversityTeacher<Programming> teacher, UniversityStudent[] universityStudents)
        {
            ISubject subject = teacher.ProduceMaterial();

            foreach (var student in universityStudents)
            {
                Console.WriteLine($"Teaching: {student.Name}.");
            }
        }
    }
}
