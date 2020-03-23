using BootCamp.Chapter.StudentInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.SchoolInfo
{
    interface ISchool<TStudent, TId> where TStudent : Student
    {
        TStudent Get(TId id);
        IList<TStudent> Get();
        void Add(TStudent student);
    }
}
