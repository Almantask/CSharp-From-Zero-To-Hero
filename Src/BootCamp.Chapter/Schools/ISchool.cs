using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Schools
{
    public interface ISchool<TStudent> where TStudent : IStudent
    {
        string Name { get; }
        string Location { get; }
        List<TStudent> StudentList { get; }

        TStudent this[int index]
        {
            get;
            set;
        }

        void RegisterStudent(TStudent student);
        TStudent GetStudent(string studentName);
        TStudent GetStudent(Guid guid);
    }
}
