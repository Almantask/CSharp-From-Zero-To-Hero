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
            List<ISchool<IStudent, ITeacher<ISubject>>> schools = new List<ISchool<IStudent, ITeacher<ISubject>>>();

            English english = new English();
            HighSchoolTeacher teach = new HighSchoolTeacher("John", english);
            HighSchoolStudent jan = new HighSchoolStudent("Max");
            HighSchool kicker = new HighSchool();
            School<IStudent, ITeacher<ISubject>> school1 = new School<IStudent, ITeacher<ISubject>>();

            kicker = school1;
            school1 = kicker;

            jan.LearnFrom<ITeacher<ISubject>, ISubject>(teach);

            students.Add(jan);
            subjects.Add(english);

            jan.GetSubjectsLearnt();
            kicker.AddStudent(jan);
            kicker.AddTeacher(teach);

            schools.Add(kicker);
            schools.Add(school1);

            foreach (ISchool <IStudent, ITeacher<ISubject>> school in schools)
            {

            }


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
