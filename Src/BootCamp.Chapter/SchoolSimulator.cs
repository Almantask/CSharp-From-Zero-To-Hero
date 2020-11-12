using BootCamp.Chapter.Interface;
using BootCamp.Chapter.Schools;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class SchoolSimulator
    {
        List<ISchool<IStudent>> schools = new List<ISchool<IStudent>>();

        English english = new English();

        public void Run()
        {
            CreateAndPopulateSchools();
            CreateStudentsAndLearnEnglish();
        }

        private void CreateAndPopulateSchools()
        {
            // Adding schools and teachers.

            ISchool<IStudent> highSchool = new School<HighSchool>();
            ITeacher<ISubject> highSchoolTeacher = new HighSchoolTeacher(english);
            highSchool.AddTeacher(highSchoolTeacher);

            var middleSchool = new School<MiddleSchool>();
            var middleSchoolTeacher = new MiddleSchoolTeacher(english);
            middleSchool.AddTeacher(middleSchoolTeacher);

            var universitySchool = new School<UniversitySchool>();
            var universityTeacher = new UniversityTeacher(english);
            universitySchool.AddTeacher(universityTeacher);

            schools.Add(highSchool);
            schools.Add(middleSchool);
            schools.Add(universitySchool);
        }

        private void CreateStudentsAndLearnEnglish()
        {
            List<IStudent> englishStudents = new List<IStudent>();
            englishStudents.Add(new HighSchoolStudent());
            englishStudents.Add(new MiddleSchoolStudent());
            englishStudents.Add(new UniversityStudent());
            for (int i = 0; i < englishStudents.Count; i++)
            {
                englishStudents[i].LearnFrom<ITeacher<ISubject>, ISubject>(schools[i].GetTeacher(english));
            }
        }
    }
}
