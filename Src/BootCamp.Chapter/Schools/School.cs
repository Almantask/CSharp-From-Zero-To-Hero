using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    class School<TStudent> : ISchool<TStudent> where TStudent : IStudent
    {
        public string Name { get; }
        public string Location { get; }

        public List<TStudent> StudentsList { get; }

        public School(string name, string location)
        {
            Name = name;
            Location = location;
            StudentsList = new List<TStudent>();
        }

        public TStudent this[int index]
        {
            get { return StudentsList[index]; }
            set { StudentsList[index] = value; }
        }

        public void AddStudent(TStudent student)
        {
            StudentsList?.Add(student);
        }

        public TStudent GetStudent(Guid guid)
        {
            foreach(var student in StudentsList)
            {
                if (student.Guid == guid)
                {
                    return student;
                }
                else
                {
                    continue;
                }
            }
            return default;
        }

        public TStudent GetStudent(string student_name)
        {
            foreach (var student in StudentsList)
            {
                if (student.Name == student_name)
                {
                    return student;
                }
                else
                {
                    continue;
                }
            }
            return default;
        }

    }
}
