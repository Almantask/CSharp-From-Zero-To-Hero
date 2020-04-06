using BootCamp.Chapter.Schools;
using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISubject> subjects = new List<ISubject>();
            List<IStudent> students = new List<IStudent>();



            List<ISchool<IStudent>> InterfaceSchools = new List<ISchool<IStudent>>();
            List<School<IStudent>> genericSchools = new List<School<IStudent>>();
            List<HighSchool<IStudent>> highSchools = new List<HighSchool<IStudent>>();

            School<IStudent> schoolWithIStudent = new School<IStudent>();
            School<HighSchoolStudent> schoolWithHighSchoolStudent = new School<HighSchoolStudent>();
            HighSchool<IStudent> highSchoolWithIStudent = new HighSchool<IStudent>();
            HighSchool<Student> highSchoolWithGenericstudent = new HighSchool<Student>();
            HighSchool<HighSchoolStudent> highSchoolWithHighSchoolStudent = new HighSchool<HighSchoolStudent>();



            //Trying to add differet schools to generic lists.
            InterfaceSchools.Add(schoolWithIStudent);
            InterfaceSchools.Add(schoolWithHighSchoolStudent);
            InterfaceSchools.Add(highSchoolWithIStudent);
            InterfaceSchools.Add(highSchoolWithGenericstudent);
            InterfaceSchools.Add(highSchoolWithHighSchoolStudent);

            genericSchools.Add(schoolWithIStudent);
            genericSchools.Add(schoolWithHighSchoolStudent);
            genericSchools.Add(highSchoolWithIStudent);
            genericSchools.Add(highSchoolWithGenericstudent);
            genericSchools.Add(highSchoolWithHighSchoolStudent);

            highSchools.Add(schoolWithIStudent);
            highSchools.Add(schoolWithHighSchoolStudent);
            highSchools.Add(highSchoolWithIStudent);
            highSchools.Add(highSchoolWithGenericstudent);
            highSchools.Add(highSchoolWithHighSchoolStudent);
           


            English english = new English();
            HighSchoolTeacher<ISubject> teach = new HighSchoolTeacher<ISubject>("John", english);
            HighSchoolStudent jan = new HighSchoolStudent("Max");
            UniversityStudent bill = new UniversityStudent("Kai");

            
            

            //kicker = school1;
            //school1 = kicker;

            jan.LearnFrom(teach);
            //jan.LearnFrom<ITeacher<ISubject>, ISubject>(teach);

            students.Add(jan);
            students.Add(bill);
            subjects.Add(english);

            jan.GetSubjectsLearnt();
            //kicker.AddStudent(jan);
            //kicker.AddTeacher(teach);


            //TODO these things:
            /*
             * 
             * You are told to implement a simulation where:

            Students can learn from any teacher (by consuming the material a teacher produced)
            Specific teachers produce material for a specific subject
            Specific schools have ability to add or get specific students

            Students :
            
            Middleschool student
            HighSchool Student
            University Student

            And different kinds of schools:
            Middle School
            High School
            Univeristy

            And different kinds of teachers:
            High School Teacher
            Middle School Teacher
            University Teacher

            And different kinds of subjects (and material for each subject):
            Maths
            Art
            Music
            PE
            English
            Programming
             */
        }
    }
}
