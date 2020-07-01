using BootCamp.Chapter.Schools;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Simulation
    {
        public static void Run()
        {
            ISchool<UniversityStudent> university = new University<UniversityStudent>("Coventry University", "UK");
            var universitySubject = new Music("Bushcraft Melodies 101", "Learn the sounds of the forest!");
            UniversityTeacher<Music> universityTeacher = new UniversityTeacher<Music>("David Attenborough", universitySubject);

            UniversityStudent[] universityStudents = new UniversityStudent[]
            {
                new UniversityStudent("Matthew"),
                new UniversityStudent("Soap"),
                new UniversityStudent("Ghost"),
                new UniversityStudent("Capt Price")
            };

            AddArrayOfStudentsToSchool(universityStudents, university);
            DeliverTeachingMaterialToStudents(universityTeacher, universityStudents);

        }

        private static void AddArrayOfStudentsToSchool(UniversityStudent[] universityStudents, ISchool<UniversityStudent> university)
        {
            foreach (var student in universityStudents)
            {
                university.AddStudent(student);
            }
        }

        private static void DeliverTeachingMaterialToStudents(UniversityTeacher<Music> musicTeacher, UniversityStudent[] universityStudents)
        {
            ISubject subjectMaterial = musicTeacher.ProduceTeachingMaterial();

            foreach(var student in universityStudents)
            {
                Console.WriteLine($"Teaching {student.Name}: {subjectMaterial.Description}!");
            }
        }
    }
}
