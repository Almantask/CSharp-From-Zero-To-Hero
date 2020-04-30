using System;
using System.Collections.Generic;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class School<TStudent> : ISchool<TStudent> where TStudent : IStudent
    {
        public string SchoolName { get; }
        public List<TStudent> StudentList { get; } = new List<TStudent>();

        protected School(string schoolName)
        {
            SchoolName = schoolName;
        }
        
        public void AddNewStudent(TStudent student)
        {
            StudentList.Add(student);
        }

        public string GetStudentInfo(string studentName)
        {
            foreach (var student in StudentList)
            {
                if (!student.Name.Equals(studentName)) continue;
                
                var message = $"ID:{student.Id}{Environment.NewLine}NAME: {student.Name}";
                return message;
            }

            return "Student not found.";
        }
    }
}
