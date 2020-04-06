using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    class School<TStudent> : ISchool<TStudent> where TStudent : IStudent
    {
        List<TStudent> students;
        //List<TTeacher> teachers;
        long Id { get; set; }
        public School()
        {
            Id = 0;
            students = new List<TStudent>();
            //teachers = new List<TTeacher>();
        }
        /*
        public void AddTeacher(TTeacher teacher)
        {
            teachers.Add(teacher);
        }
        */
        public void AddStudent(TStudent student)
        {
            students.Add(student);
            student.Id = Id;
            Id++;
        }

        public TStudent GetStudent(long id)
        {
            throw new NotImplementedException();
        }
    }
}
