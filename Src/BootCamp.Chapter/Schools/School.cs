using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Schools
{
    public class School<TStudent> : ISchool<TStudent> where TStudent : IStudent
    {
        public string Name { get; }

        public string Location { get; }

        public List<TStudent> StudentList => new List<TStudent>();

        public School(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public TStudent this[int index]
        {
            get => StudentList[index];
            set => StudentList[index] = value;
        }

        public TStudent GetStudent(string studentName)
        {
            foreach (TStudent student in StudentList)
            {
                if (student.Name == studentName) return student;
            }

            return default;
        }

        public TStudent GetStudent(Guid guid)
        {
            foreach (TStudent student in StudentList)
            {
                if (student.guid == guid) return student;
            }

            return default;
        }

        public void RegisterStudent(TStudent student)
        {
            StudentList.Add(student);
        }
    }
}
