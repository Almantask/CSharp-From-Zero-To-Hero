using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    interface ISchool<TStudent> where TStudent : IStudent
    {
        string Name { get; }
        string Location { get; }
        List<TStudent> StudentsList { get; }

        TStudent this[int index] { get; set; }

        void AddStudent(TStudent student);

        /// <summary>
        /// Returns Student with Guid as input
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        TStudent GetStudent(Guid guid);

        /// <summary>
        /// Returns Student with Students Name as input
        /// </summary>
        /// <param name="student_name"></param>
        /// <returns></returns>
        TStudent GetStudent(string student_name);
    }
}
